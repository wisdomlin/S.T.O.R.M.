using System;
using System.Diagnostics;
using System.IO;

namespace Asc
{
    public class PythonRunner
    {

        public string my_full_path_to_python_exe = "C:\\python37-32\\python.exe";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd">python script</param>
        /// <param name="args">args for that python script</param>
        public void run_cmd(string cmd, string args)
        {
            // TODO: Should catch Script Not Found exception
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = my_full_path_to_python_exe;
            start.Arguments = string.Format("{0} {1}", cmd, args);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
        }
    }
}
