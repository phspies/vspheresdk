using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace vspheresdk
{
    public partial class vSphereException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public IReadOnlyCollection<HeaderParameter> Headers { get; private set; }

        public vSphereException(string message, int statusCode, string response, IReadOnlyCollection<HeaderParameter> headers, Exception innerException)
            : base(message + " - " + innerException.innerExceptions<Exception>().Last().Message + "\n\nStatus: " + statusCode + "\nResponse: \n" + response, innerException.innerExceptions<Exception>().Last().InnerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;

        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    public static class ExceptionExtensions
    {
        public static IEnumerable<T> innerExceptions<T>(this Exception ex) where T : Exception
        {
            var rVal = new List<T>();

            Action<Exception> lambda = null;
            lambda = (x) =>
            {
                var xt = x as T;
                if (xt != null)
                    rVal.Add(xt);

                if (x.InnerException != null)
                    lambda(x.InnerException);

                var ax = x as AggregateException;
                if (ax != null)
                {
                    foreach (var aix in ax.InnerExceptions)
                        lambda(aix);
                }
            };

            lambda(ex);

            return rVal;
        }
    }
}
