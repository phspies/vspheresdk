using CaseExtensions;
using Nustache.Core;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using NSwag;
using NJsonSchema;
using NJsonSchema.References;
using System.Net;
using System.Web;
using System.Text;
using NSwag.Collections;
using System.Collections;

namespace SDK
{
    class Program
    {
        static string projectDirectory = @"C:\Users\Phillip\source\repos\vspheresdk\vspheresdk";
        static string generatorDirectory = @"C:\Users\Phillip\source\repos\vspheresdk\SDKGenerator";
        static string templatesDirectory = @"C:\Users\Phillip\source\repos\vspheresdk\Templates";

        static Dictionary<string, string> models = new Dictionary<string, string>();



        static void Main(string[] args)
        {


            Helpers.Register(nameof(ToXmlDoc), ToXmlDoc);
            Helpers.Register(nameof(GetMethodName), GetMethodName);
            Helpers.Register(nameof(GetDotNetName), GetDotNetName);
            Helpers.Register(nameof(GetDotNetType), GetDotNetType);
            Helpers.Register(nameof(GetOperationPathParams), GetOperationPathParams);
            Helpers.Register(nameof(GetOperationPathInjectionCode), GetOperationPathInjectionCode);
            Helpers.Register(nameof(GetOperationHttpMethod), GetOperationHttpMethod);
            Helpers.Register(nameof(GetOperationReturnType), GetOperationReturnType);
            Helpers.Register(nameof(GetResponseType), GetResponseType);
            Helpers.Register(nameof(GetPSValueDefinition), GetPSValueDefinition);
            Helpers.Register(nameof(GetResponseTypeName), GetResponseTypeName);
            Helpers.Register(nameof(GetPSVerb), GetPSVerb);
            Helpers.Register(nameof(GetBool), GetBool);
            Helpers.Register(nameof(GetTuple), GetTuple);
            Helpers.Register(nameof(GetLowerCase), GetLowerCase);
            Helpers.Register(nameof(GetCmdLetReturnCode), GetCmdLetReturnCode);
            Helpers.Register(nameof(GetServiceUrl), GetServiceUrl);
            Helpers.Register(nameof(GetResponseName), GetResponseName);
            Helpers.Register(nameof(GetParameterPascalCase), GetParameterPascalCase);
            Helpers.Register(nameof(SetDefaultValue), SetDefaultValue);
            Helpers.Register(nameof(GetEvaluateResponse), GetEvaluateResponse);




            var jsonFiles = Directory.GetFiles(generatorDirectory, "*.json");
            Dictionary<string, OpenApiDocument> apiDocuments = new Dictionary<string, OpenApiDocument>();
            foreach (var file in jsonFiles)
            {
                var simpleFileName = Path.GetFileNameWithoutExtension(file);
                var apidoc = OpenApiDocument.FromFileAsync(file).Result;
                JsonSchemaReferenceUtilities.UpdateSchemaReferencePaths(apidoc);
                apiDocuments.Add(simpleFileName.ToPascalCase(), apidoc);
                Directory.CreateDirectory(Path.Combine(projectDirectory, simpleFileName.ToPascalCase()));
                Directory.CreateDirectory(Path.Combine(projectDirectory, simpleFileName.ToPascalCase(), "Models"));
                Directory.CreateDirectory(Path.Combine(projectDirectory, simpleFileName.ToPascalCase(), "Models", "Enums"));
                Directory.CreateDirectory(Path.Combine(projectDirectory, simpleFileName.ToPascalCase(), "Modules"));
            }

            Directory.CreateDirectory(Path.Combine(projectDirectory, "Models"));

            foreach (var apiDoc in apiDocuments)
            {
                foreach (var model in apiDoc.Value.Definitions)
                {
                    string className = model.Key.EndsWith("type", StringComparison.InvariantCultureIgnoreCase) ? PascalCase(model.Key) : PascalCase(model.Key + "Type");
                    if (models.Any(x => x.Value.Equals(className, StringComparison.CurrentCultureIgnoreCase)))
                    {
                        className = $"{className}" + "A";

                    }
                    if (!models.Any(x => x.Key.Equals(model.Key, StringComparison.InvariantCulture)))
                    {
                        models.Add(model.Key, className);
                    }
                }
            }

            foreach (var apiDoc in apiDocuments)
            {
                foreach (var model in apiDoc.Value.Definitions.Where(x => x.Value.Type == JsonObjectType.Object))
                {
                    string className = LookupClassName(model.Key);

                    Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "Model.cs.template"), new
                    {
                        clz = className,
                        module = model,
                        rootmodule = apiDoc.Key,
                        properties = model.Value.Properties,
                    }, Path.Combine(projectDirectory, apiDoc.Key, "Models", $"{ className}.cs"));

                }
                foreach (var model in apiDoc.Value.Definitions.Where(x => x.Value.Type != JsonObjectType.Object && x.Value.Enumeration.Count > 0))
                {
                    EnumType currentEnum = new EnumType();
                    if (models.ContainsKey(model.Key))
                    {
                        currentEnum.EnumName = models.Single(x => x.Key.Equals(model.Key, StringComparison.Ordinal)).Value;
                    }


                    currentEnum.Description = model.Value.Description;
                    foreach (var enumValue in model.Value.Enumeration)
                    {
                        int index = 1;
                        if (currentEnum.Values.Count > 0)
                        {
                            index = (string)model.Value.Default == (string)enumValue ? 0 : currentEnum.Values.Last().EnumIndex + 1;
                        }
                        currentEnum.Values.Add(new EnumValueType() { EnumValue = char.IsDigit(((string)enumValue)[0]) ? "A" + PascalCase(enumValue as string) : PascalCase(enumValue as string), JsonEnumValue = (enumValue as string).Replace(" ", "_").ToUpper(), EnumIndex = index });
                    }
                    if (currentEnum.EnumName.Contains("vcentervmpowerstatetype", StringComparison.OrdinalIgnoreCase))
                    {

                    }
                    Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "EnumModel.cs.template"), new
                    {
                        rootmodule = apiDoc.Key,
                        currentEnum
                    }, Path.Combine(projectDirectory, apiDoc.Key, "Models", "Enums", $"{currentEnum.EnumName}.cs"));
                }

                var tags = apiDoc.Value.Paths.Values.SelectMany(x => x.SelectMany(y => y.Value.Tags.Select(z => z.ToString()))).Distinct().Select(x => new { tag = x, pascalname = PascalCase(x) });
                foreach (var tag in tags)
                {
                    var operations = apiDoc.Value.Paths.SelectMany(x => x.Value.Select(y => new Tuple<string, OpenApiPathItem, string, OpenApiOperation>(x.Key, x.Value, y.Key, y.Value)).Where(x => x.Item4.Tags.Contains(tag.tag) && x.Item1.StartsWith("/api")));
                    Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "Module.cs.template"), new
                    {
                        rootmodule = apiDoc.Key,
                        module = tag.pascalname,
                        operations = operations,
                    }, Path.Combine(projectDirectory, apiDoc.Key, "Modules", $"{tag.pascalname}.cs")); ;
                }

                Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "SubModule.cs.template"), new
                {
                    rootmodule = apiDoc.Key,
                    modules = tags.Select(x => x.pascalname),
                }, Path.Combine(projectDirectory, $"{apiDoc.Key}Module.cs")); ;


            }
            Render.FileToFile(Path.Combine(generatorDirectory, "Templates", "RootModule.cs.template"), new
            {
                submodules = apiDocuments.Keys,
            }, Path.Combine(projectDirectory, "vSphereClient.cs")); ;


            var test = models.Where(x => x.Value.Equals("VcenterVMsummary", StringComparison.InvariantCultureIgnoreCase));
        }

        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_. ]+", "", RegexOptions.Compiled);
        }
        private static void GetEvaluateResponse(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            int code = int.Parse((string)((DictionaryEntry)arguments[0]).Key);
            OpenApiResponse response = (OpenApiResponse)((DictionaryEntry)arguments[0]).Value;
            if (!(200 <= code && code <= 300))
            {
                context.Write("else if ((int)response.StatusCode == " + code + ") { throw new vSphereException(" + $"\"{ RemoveSpecialCharacters(response.Description)}\"" + ", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }");
            }
            else
            {
                if (String.IsNullOrWhiteSpace(response.Description)  && response.Schema == null)
                {
                    context.Write("if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }");
                }
                else
                {
                    context.Write("if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }");
                }
            }
        }

        private string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value == null)
            {
                return "";
            }

            if (value is System.Enum)
            {
                var name = System.Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                            as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value != null ? attribute.Value : name;
                        }
                    }

                    var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                    return converted == null ? string.Empty : converted;
                }
            }
            else if (value is bool)
            {
                return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return System.Convert.ToBase64String((byte[])value);
            }
            else if (value.GetType().IsArray)
            {
                var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
                return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }

            var result = System.Convert.ToString(value, cultureInfo);
            return result == null ? "" : result;
        }
        private static void GetServiceUrl(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var argumentsObject = (Tuple<string, OpenApiPathItem, string, OpenApiOperation>)arguments[0];
            var url = (string)argumentsObject.Item1;
            context.Write($"{url}");
        }
        private static void SetDefaultValue(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            //var (method, operation) = ((KeyValuePair<string, OpenApiPathItem>)arguments[0]);
            context.Write($"test");
        }
        private static void GetCmdLetReturnCode(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var parameter = (OpenApiParameter)arguments[0];
            context.Write($"{GetDotNetType(parameter)} {PascalCase(parameter.Name)}");
        }
        private static void GetParameterPascalCase(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var parameter = (string)arguments[0];
            context.Write($"{PascalCase(parameter)}");
        }
        private static void GetPSValueDefinition(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var parameter = (OpenApiParameter)arguments[0];
            context.Write($"{GetDotNetType(parameter)} {PascalCase(parameter.Name)}");
        }
        private static void GetPSVerb(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var (method, operation) = (KeyValuePair<string, OpenApiOperation>)arguments[0];
            string module = arguments[1] as string;
            List<string> list = StringSplitter(operation.OperationId);
            context.Write($"\"{list[0]}\",\"{module}{PascalCase(string.Join("", list.GetRange(1, list.Count - 1)))}\"");
        }
        private static void GetResponseTypeName(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var response = (OpenApiResponse)arguments[0];
            string typeName = LookupClassName(((IJsonReferenceBase)response.Schema).ReferencePath.Split("/")[3]);

            context.Write(typeName);
        }
        private static void ToXmlDoc(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            if (arguments != null && arguments.Count > 0 && arguments[0] != null && arguments[0] is string)
            {
                var first = true;
                using (var reader = new StringReader(arguments[0] as string))
                {
                    string line = null;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (arguments.Count > 1 && arguments[1] as string == "wrap")
                        {
                            foreach (var wline in WordWrap(line, 120))
                            {
                                if (!first)
                                {
                                    context.Write("\r\n        /// ");
                                }
                                else
                                {
                                    first = false;
                                }

                                context.Write(HttpUtility.HtmlDecode(wline));
                            }
                        }
                        else
                        {
                            context.Write(SecurityElement.Escape(line.Replace("\n", "").Replace("\r", "")));
                        }
                    }
                }
            }
        }

        private static void GetOperationPathParams(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var argumentsObject = (Tuple<string, OpenApiPathItem, string, OpenApiOperation>)arguments[0];
            var method = (string)argumentsObject.Item3;
            var operation = (OpenApiOperation)argumentsObject.Item4;

            List<string> returnList = new();
            foreach (var parameter in operation.Parameters.OrderByDescending(x => x.IsRequired))
            {
                returnList.Add($"{(GetDotNetType(parameter))} {PascalCase(parameter.Name)}" + (parameter.IsRequired ? "" : " = null"));
            }
            context.Write(string.Join(", ", returnList));
        }

        private static void GetOperationReturnType(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {

            var argumentsObject = (Tuple<string, OpenApiPathItem, string, OpenApiOperation>)arguments[0];
            var method = (string)argumentsObject.Item3;
            var operation = (OpenApiOperation)argumentsObject.Item4;
            var response = operation.Responses.FirstOrDefault(x => x.Key.StartsWith("20"));


            if (response.Value.Schema != null)
            {
                if (response.Value.Schema?.Reference != null)
                {
                    string className = LookupClassName(((IJsonReferenceBase)response.Value.Schema).ReferencePath.Split("/").Last());

                    if (arguments[1] as string == "full")
                    {
                        context.Write($"Task<{className}>");
                    }
                    else if (arguments[1] as string == "bare")
                    {
                        context.Write($"<{className}>");
                    }
                    else if (arguments[1] as string == "init")
                    {
                        context.Write($"{className} returnValue = default({className});");
                    }
                    else if (arguments[1] as string == "cast")
                    {
                        context.Write($"returnValue = JsonConvert.DeserializeObject<{className}>(response.Content, defaultSerializationSettings);");
                    }
                    else if (arguments[1] as string == "return")
                    {
                        var okResponse = operation.Responses.FirstOrDefault(x => x.Key.StartsWith("20"));
                        if (okResponse.Value.Schema != null)
                        {
                            context.Write("return response.Data;");
                        }
                    }
                    else if (arguments[1] as string == "cmdlet")
                    {
                        context.Write($"[OutputType(typeof({className}))]");
                    }
                }
                else if (response.Value.Schema?.Type != JsonObjectType.None)
                {
                    string className = "";
                    if (response.Value.Schema.Type == JsonObjectType.Array)
                    {

                        if (response.Value.Schema.Reference != null)
                        {
                            string casting = LookupClassName(((IJsonReferenceBase)response.Value).ReferencePath.Split("/")[3]);

                            className = $"List<{casting}";
                        }
                        else if (response.Value.Schema.Item.Reference != null)
                        {
                            string casting = LookupClassName(((IJsonReferenceBase)response.Value.Schema.Item).ReferencePath.Split("/")[3]);
                            className = $"List<{casting}>";

                        }
                        else
                        {
                            className = $"List<{response.Value.Schema.Item.Type.ToString().ToLower()}>";
                        }
                    }
                    else
                    {
                        if (response.Value.Schema.Type == JsonObjectType.Integer)
                        {
                            className = $"long";
                        }
                        else
                        {
                            className = $"{response.Value.Schema.Type.ToString().ToLower()}";
                        }
                    }

                    if (arguments[1] as string == "full")
                    {
                        context.Write($"Task<{className}>");
                    }
                    else if (arguments[1] as string == "bare")
                    {
                        context.Write($"<{className}>");
                    }
                    else if (arguments[1] as string == "init")
                    {
                        context.Write($"{className} returnValue  = default({className});");
                    }
                    else if (arguments[1] as string == "cast")
                    {
                        context.Write($"returnValue = JsonConvert.DeserializeObject<{className}>(response.Content, defaultSerializationSettings);");
                    }
                    else if (arguments[1] as string == "return")
                    {
                        var okResponse = operation.Responses.FirstOrDefault(x => x.Key.StartsWith("20"));
                        if (okResponse.Value.Schema != null)
                        {
                            context.Write("return response.Data;");
                        }
                    }
                }
            }
            else
            {
                if (arguments[1] as string == "full")
                {
                    context.Write("Task");
                }
                else if (arguments[1] as string == "bare")
                {
                }
                else if (arguments[1] as string == "init")
                {
                }
                else if (arguments[1] as string == "cast")
                {
                }
                else if (arguments[1] as string == "return")
                {
                }

            }

        }
        private static void GetOperationHttpMethod(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var argumentsObject = (Tuple<string, OpenApiPathItem, string, OpenApiOperation>)arguments[0];
            var method = (string)argumentsObject.Item3;
            var operation = (OpenApiOperation)argumentsObject.Item4;


            context.Write(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(method));

        }
        private static void GetResponseType(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            ObservableDictionary<string, OpenApiResponse> responseList = arguments[0] as ObservableDictionary<string, OpenApiResponse>;
            var okResponse = responseList.FirstOrDefault(x => x.Key.StartsWith("20"));

            //if (okResponse.Value.Schema != null)
            //{
            //    if (okResponse.Value.Schema?.Reference != null)
            //    {
            //        context.Write($"returnValue = JsonConvert.DeserializeObject<NSXT{((IJsonReferenceBase)okResponse.Value.Schema).ReferencePath.Split("/")[3]}Type>(response.Content, defaultSerializationSettings);");
            //    }
            //    else if (okResponse.Value.Schema?.Type != JsonObjectType.None)
            //    {
            //        context.Write($"returnValue = JsonConvert.DeserializeObject<{okResponse.Value.Schema.Type.ToString().ToLower()}>(response.Content, defaultSerializationSettings);");
            //    }
            //}

        }

        private static void GetOperationPathInjectionCode(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var parameter = (arguments[0] as OpenApiParameter);
            if (parameter.Kind == OpenApiParameterKind.Path)
            {
                context.Write($"{PascalCase((parameter.Parent as OpenApiOperation).OperationId)}ServiceURL.Replace(\"{{{parameter.Name}}}\", System.Uri.EscapeDataString(Helpers.ConvertToString({PascalCase(parameter.Name)}, System.Globalization.CultureInfo.InvariantCulture)));");
            }
            if (parameter.Kind == OpenApiParameterKind.Query)
            {
                context.Write($"if ({PascalCase(parameter.Name)} != null) {{ request.AddQueryParameter(\"{parameter.Name}\", {PascalCase(parameter.Name)}.ToString()); }}");
            }
            if (parameter.Kind == OpenApiParameterKind.Body)
            {
                context.Write($"request.AddJsonBody({PascalCase(parameter.Name)});");
            }
        }

        private static void GetLowerCase(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var test = arguments[0];
            context.Write(arguments[0]?.ToString()?.ToLower());
        }
        private static void GetBool(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var test = arguments[0];
            context.Write(Boolean.Parse(arguments[0]?.ToString()).ToString());
        }
        private static void GetTuple(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            if (arguments != null && arguments.Count > 0 && arguments[0] is ITuple && options.TryGetValue("index", out var indexObj) && int.TryParse(indexObj?.ToString(), out var index))
            {
                var pair = (ITuple)arguments[0];
                var value = pair[index];
                context.Write(value.ToString());
            }
        }

        private static void GetMethodName(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            var argumentsObject = (Tuple<string, OpenApiPathItem, string, OpenApiOperation>)arguments[0];
            var method = (string)argumentsObject.Item3;
            var operation = (OpenApiOperation)argumentsObject.Item4;

            context.Write(PascalCase(operation.OperationId));


        }
        private static void GetResponseName(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {

            var (_response, _operation) = ((DictionaryEntry)arguments[0]);
            var response = (string)_response;
            var operation = (OpenApiResponse)_operation;
            context.Write(PascalCase(response));
        }


        private static void GetDotNetType(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            if (arguments != null && arguments.Count > 0 && arguments[0] != null && arguments[0] is JsonSchemaProperty)
            {
                var parameter = arguments[0] as JsonSchemaProperty;
                context.Write(GetDotNetType(parameter, arguments));
            }
        }
        private static string GetDotNetType(OpenApiParameter parameter)
        {
            switch (parameter.Type)
            {
                case JsonObjectType.Boolean:
                    return $"bool{(parameter.IsRequired ? "" : "?")}";
                    break;
                case JsonObjectType.Integer:
                    switch (parameter.Format)
                    {
                        case "int64":
                            return $"long{(parameter.IsRequired ? "" : "?")}";
                        case "int32":
                        default:
                            return $"int{(parameter.IsRequired ? "" : "?")}";
                    }
                    break;

                case JsonObjectType.Number:
                    return $"double{(parameter.IsRequired ? "" : "?")}";
                    break;

                case JsonObjectType.String:
                    switch (parameter.Format)
                    {
                        case "byte":
                            return "byte[]";
                        case "date-time":
                            return $"DateTime{(parameter.IsRequired ? "" : "?")}";
                    }
                    return parameter.IsRequired ? "string" : "string?";
                    break;

                case JsonObjectType.File:
                    return $"string{(parameter.IsRequired ? "" : "?")}";
                    break;

                case JsonObjectType.Object:


                    return $"{parameter.AdditionalItemsSchema.Reference}{(parameter.IsRequired ? "" : "?")}";
                    break;

                case JsonObjectType.None:
                    if (parameter.Schema.Reference.Type != null && parameter.Schema.Reference.Type != JsonObjectType.Object)
                    {
                        return $"{parameter.Schema.Reference.Type.ToString().ToLower()}";
                    }
                    var returnType = LookupClassName(((IJsonReferenceBase)parameter.Schema).ReferencePath.Split("/")[3]);
                    return returnType;
                    break;

                case JsonObjectType.Array:
                    if (((IJsonReferenceBase)parameter.Item).ReferencePath != null)
                    {
                        var returnType1 = LookupClassName(((IJsonReferenceBase)parameter.Schema).ReferencePath.Split("/")[3]);
                        return returnType1;
                    }
                    else
                    {
                        string returnType1 = parameter.Item.Type.ToString().ToLower();
                        return $"{returnType1}";
                    }


                    break;

                default:
                    //throw new NotSupportedException();
                    Console.WriteLine($"{parameter.Type} for {parameter.Name} not handeled");
                    return "object";
                    break;


            }
        }
        private static string GetDotNetType(JsonSchemaProperty jsonType, IList<object> arguments)
        {
            if (jsonType.Name.Contains("Cdroms", StringComparison.OrdinalIgnoreCase))
            {

            }

            switch (jsonType.Type)
            {
                case JsonObjectType.Boolean:
                    if (jsonType.IsRequired)
                    {
                        return "bool";
                    }
                    else
                    {
                        return "bool?";
                    }

                case JsonObjectType.Integer:
                    switch (jsonType.Format)
                    {
                        case "int64":
                            if (jsonType.IsRequired)
                            {
                                return "long";
                            }
                            else
                            {
                                return "long?";
                            }
                        case "int32":
                        default:
                            if (jsonType.IsRequired)
                            {
                                return "int";
                            }
                            else
                            {
                                return "int?";
                            }
                    }

                case JsonObjectType.Number:
                    if (jsonType.IsRequired)
                    {
                        return "double";
                    }
                    else
                    {
                        return "double?";
                    }

                case JsonObjectType.String:
                    switch (jsonType.Format)
                    {
                        case "byte":
                            return "byte[]";
                        case "date-time":
                            if (jsonType.IsRequired)
                            {
                                return "DateTime";
                            }
                            else
                            {
                                return "DateTime?";
                            }
                    }
                    return jsonType.IsRequired ? "string" : "string?";
                case JsonObjectType.Array:
                    if (jsonType.Item?.Reference != null)
                    {
                        var _type = LookupClassName(((IJsonReferenceBase)jsonType.Item).ReferencePath.Split("/")[3]);
                        var returnType = $"Dictionary<string,{_type}>";
                        return returnType;
                    }
                    else
                    {
                        if (jsonType.Type == JsonObjectType.Array)
                        {
                            if (jsonType.Item.Type == JsonObjectType.Integer)
                            {
                                switch (jsonType.Item.Format)
                                {
                                    case "int64":
                                        if (jsonType.IsRequired)
                                        {
                                            return "long";
                                        }
                                        else
                                        {
                                            return "long?";
                                        }
                                    case "int32":
                                    default:
                                        if (jsonType.IsRequired)
                                        {
                                            return "int";
                                        }
                                        else
                                        {
                                            return "int?";
                                        }
                                }
                            }
                            if (jsonType.Item.Type == JsonObjectType.String)
                            {
                                return $"IList<string>";

                            }

                            else
                            {
                                if (jsonType.Item.Reference != null)
                                {
                                    var _type = LookupClassName(((IJsonReferenceBase)jsonType.Item).ReferencePath.Split("/")[3]);
                                    return $"IList<{_type}Type>";
                                }
                                else
                                {
                                    string _type = jsonType.Item.Type.ToString().ToLower();
                                    if (_type == "number")
                                    {
                                        _type = "float";
                                    }
                                    return $"IList<{_type}>";
                                }
                            }
                        }
                        else
                        {
                            throw new NotSupportedException();

                        }
                    }
                case JsonObjectType.Object:
                    if (jsonType.AdditionalPropertiesSchema != null && ((IJsonReferenceBase)jsonType.AdditionalPropertiesSchema).ReferencePath != null)
                    {
                        var returnType = LookupClassName(((IJsonReferenceBase)jsonType.AdditionalPropertiesSchema).ReferencePath.Split("/")[3]);
                        return $"Dictionary<string,{returnType}>{(jsonType.IsRequired ? "" : "?")}";
                    }
                    else
                    {
                        return "object";
                    }
                case JsonObjectType.None:

                    if (jsonType.Reference != null)
                    {
                        var _type = LookupClassName(((IJsonReferenceBase)jsonType).ReferencePath.Split("/")[3]);
                        return _type;
                    }
                    else
                    {
                        return "object";
                    }
                default:
                    throw new NotSupportedException();
            }
        }



        private static void GetDotNetName(RenderContext context, IList<object> arguments, IDictionary<string, object> options, RenderBlock fn, RenderBlock inverse)
        {
            if (arguments != null && arguments.Count > 0 && arguments[0] != null && arguments[0] is JsonSchemaProperty)
            {
                var parameter = arguments[0] as JsonSchemaProperty;
                context.Write(PascalCase(parameter.Name));
            }
            else if (arguments != null && arguments.Count > 0 && arguments[0] != null && arguments[0] is OpenApiParameter)
            {
                var parameter = arguments[0] as OpenApiParameter;
                context.Write(GetDotNetName(parameter.Name));
                if (arguments.Count > 1 && arguments[1] as string == "true" && !parameter.IsRequired)
                {
                    context.Write($" = null");
                }
            }
            else if (arguments != null && arguments.Count > 0 && arguments[0] != null && arguments[0] is string)
            {
                var style = "parameter";
                if (arguments.Count > 1)
                {
                    style = arguments[1] as string;
                }

                context.Write(GetDotNetName((string)arguments[0], style));
            }
            else
            {
                context.Write("fieldname");
            }
        }

        private static string GetDotNetName(string jsonName, string style = "parameter")
        {

            switch (style)
            {
                case "parameter":
                    if (jsonName == "namespace")
                    {
                        return "namespaceParameter";
                    }
                    else if (jsonName == "continue")
                    {
                        return "continueParameter";
                    }

                    break;

                case "fieldctor":
                    if (jsonName == "namespace")
                    {
                        return "namespaceProperty";
                    }
                    else if (jsonName == "continue")
                    {
                        return "continueProperty";
                    }
                    else if (jsonName == "__referencePath")
                    {
                        return "refProperty";
                    }
                    else if (jsonName == "default")
                    {
                        return "defaultProperty";
                    }
                    else if (jsonName == "operator")
                    {
                        return "operatorProperty";
                    }
                    else if (jsonName == "$schema")
                    {
                        return "schema";
                    }
                    else if (jsonName == "enum")
                    {
                        return "enumProperty";
                    }
                    else if (jsonName == "object")
                    {
                        return "objectProperty";
                    }
                    else if (jsonName == "readOnly")
                    {
                        return "readOnlyProperty";
                    }
                    else if (jsonName == "from")
                    {
                        return "fromProperty";
                    }
                    return jsonName.ToCamelCase();
                case "field":
                    return PascalCase(GetDotNetName(jsonName, "fieldctor"));
            }
            return PascalCase(jsonName);
        }
        public static string LookupClassName(string str)
        {

            if (models.ContainsKey(str))
            {
                return models.Single(x => x.Key.Equals(str, StringComparison.CurrentCulture)).Value;
            }
            else
            {
                Console.WriteLine(str);
                return $"fixme{str}";
            }
        }
        public static string PascalCase(string str)
        {
            if (str != null)
            {
                str = str.Replace("$", " ");
                TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
                str = Regex.Replace(str, "([A-Z]+)", " $1");
                str = cultInfo.ToTitleCase(str);

                str = str.Replace(" ", "");
                str = str.Replace("_", "");
                str = str.Replace("-", "");
                str = str.Replace("+", "");
                str = str.Replace(".", "");
                str = str.Replace("/", "");
            }
            return str;
        }

        public static IEnumerable<string> WordWrap(string text, int width)
        {
            var lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            foreach (var line in lines)
            {
                var processedLine = line.Trim();

                // yield empty lines as they are (probably) intensional
                if (processedLine.Length == 0)
                {
                    yield return processedLine;
                }

                // feast on the line until it's gone
                while (processedLine.Length > 0)
                {
                    // determine potential wrapping points
                    var whitespacePositions = Enumerable
                        .Range(0, processedLine.Length)
                        .Where(i => char.IsWhiteSpace(processedLine[i]))
                        .Concat(new[] { processedLine.Length })
                        .Cast<int?>();
                    var preWidthWrapAt = whitespacePositions.LastOrDefault(i => i <= width);
                    var postWidthWrapAt = whitespacePositions.FirstOrDefault(i => i > width);

                    // choose preferred wrapping point
                    var wrapAt = preWidthWrapAt ?? postWidthWrapAt ?? processedLine.Length;

                    // wrap
                    yield return processedLine.Substring(0, wrapAt);
                    processedLine = processedLine.Substring(wrapAt).Trim();
                }
            }
        }
        static List<string> StringSplitter(string stringToSplit)
        {
            List<string> result = new List<string>();
            bool wasPreviousUppercase = false;
            StringBuilder current = new StringBuilder();

            foreach (char c in stringToSplit)
            {
                if (char.IsUpper(c))
                {
                    if (wasPreviousUppercase)
                    {
                        current.Append(c);
                    }
                    else
                    {
                        if (current.Length > 0)
                        {
                            result.Add(current.ToString());
                            current.Length = 0;
                        }

                        current.Append(c);
                    }

                    wasPreviousUppercase = true;
                }
                else  // lowercase
                {
                    if (wasPreviousUppercase)
                    {
                        if (current.Length > 1)
                        {
                            char carried = current[current.Length - 1];
                            --current.Length;
                            result.Add(current.ToString());
                            current.Length = 0;
                            current.Append(carried);
                        }
                    }

                    wasPreviousUppercase = false;

                    if (current.Length == 0)
                    {
                        current.Append(char.ToUpper(c));
                    }
                    else
                    {
                        current.Append(c);
                    }
                }
            }

            if (current.Length > 0)
            {
                result.Add(current.ToString());
            }

            return result;
        }
        public class EnumType
        {
            public EnumType()
            {
                Values = new List<EnumValueType>();
            }
            public string EnumName { get; set; }
            public string Description { get; set; }
            public List<EnumValueType> Values { get; set; }
        }
        public class EnumValueType
        {
            public string EnumValue { get; set; }
            public string JsonEnumValue { get; set; }
            public int EnumIndex { get; set; }
        }
    }
}
