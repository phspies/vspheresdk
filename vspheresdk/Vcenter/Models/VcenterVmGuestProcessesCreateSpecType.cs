using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterVmGuestProcessesCreateSpecType 
    {
        /// <summary>
        /// The absolute path to the program to start.
        /// For Linux guest operating systems, /bin/bash is used to start the program.
        /// 
        /// For Solaris guest operating systems, if /bin/bash exists, its used to start the program, otherwise /bin/sh is used. If
        /// /bin/sh is used, then the process ID returned by Processes.create will be that of the shell used to start the program,
        /// rather than the program itself, due to the differences in how /bin/sh and /bin/bash work. This PID will still be usable
        /// for watching the process with Processes.list to find its exit code and elapsed time.
        /// 
        /// For Windows, no shell is used. Using a simple batch file instead by prepending c:\windows\system32\cmd.exe /c will allow
        /// stdio redirection to work if passed in the Processes.CreateSpec.arguments parameter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "path", Required = Required.AllowNull)]
        public string Path { get; set; }
        /// <summary>
        /// The arguments to the program.
        /// Characters which must be escaped to the shell should also be escaped in Processes.CreateSpec.arguments.
        /// 
        /// In Linux and Solaris guest operating systems, stdio redirection arguments may be used.
        /// 
        /// For Windows, stdio redirection can be added to the argments if Processes.CreateSpec.path is prefixed with
        /// c:\windows\system32\cmd.exe /c.
        /// 
        /// If unset no arguments are passed to the program.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "arguments")]
        public string? Arguments { get; set; }
        /// <summary>
        /// The absolute path of the working directory for the program to be run. VMware recommends explicitly setting the working
        /// directory for the program to be run.
        /// If unset or is an empty string, the behavior depends on the guest operating system. For Linux guest operating systems,
        /// if unset or is an empty string, the working directory will be the home directory of the user associated with the guest
        /// authentication. For other guest operating systems, if unset, the behavior is unspecified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "working_directory")]
        public string? WorkingDirectory { get; set; }
        /// <summary>
        /// A map of environment variables, specified using the guest OS rules (for example PATH, c:\bin;c:\windows\system32 or
        /// LD_LIBRARY_PATH,/usr/lib:/lib), to be set for the program being run. Note that these are not additions to the default
        /// environment variables; they define the complete set available to the program.
        /// If unset, the environment variables used are guest dependent defaults.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "environment_variables")]
        public object EnvironmentVariables { get; set; }
        /// <summary>
        /// Makes any program window start minimized in Windows operating systems. Returns an error if set for non-Windows guests.
        /// Defaults to false.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "start_minimized")]
        public bool? StartMinimized { get; set; }
    }
}
