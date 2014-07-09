using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendToPath
{
    class Class1
    {
        // Get current path environment variables to string

        //private string GetCurrentPathString()
        //{
        //    Process p = new Process();
        //    string filename = "cmd.exe";  // holds the filename we're going to call

        //    // /c Carries out the command specified by string and then terminates
        //    string arguments = "/c echo %PATH%"; // holds the arguments to call

        //    p.StartInfo.CreateNoWindow = true;
        //    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        //    p.StartInfo.UseShellExecute = false;

        //    p.StartInfo.RedirectStandardError = true;
        //    p.StartInfo.RedirectStandardOutput = true;
        //    var stdOutput = new StringBuilder();
        //    p.OutputDataReceived += (sender, args) => stdOutput.Append(args.Data);

        //    string stdError = null;

        //    try
        //    {
        //        p.Start();
        //        p.BeginOutputReadLine();
        //        stdError = p.StandardError.ReadToEnd();
        //        p.WaitForExit();
        //    }
        //    catch (Exception e)
        //    {
        //        // Formats the error 
        //        throw new Exception("OS error while executing " + Format(filename, arguments)+ ": " + e.Message, e);
        //    }

        //    if (p.ExitCode == 0)
        //    {
        //        return stdOutput.ToString();
        //    }
        //    else
        //    {
        //        var message = new StringBuilder();

        //        if (!string.IsNullOrEmpty(stdError))
        //        {
        //            message.AppendLine(stdError);
        //        }

        //        if (stdOutput.Length != 0)
        //        {
        //            message.AppendLine("Std output:");
        //            message.AppendLine(stdOutput.ToString());
        //        }

        //        throw new Exception(Format(filename, arguments) + " finished with exit code = " + p.ExitCode + ": " + message);
        //    }

        //}

        private string Format(string filename, string arguments)
        {
            return "'" + filename +
                ((string.IsNullOrEmpty(arguments)) ? string.Empty : " " + arguments) +
                "'";
        }
    }
}
