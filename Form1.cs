using System;
// Need this for adding/manipulating/reading form elements
using System.Windows.Forms;
// Need this to use the Path object
using System.IO;
// Need this to use Windows Principal, WindowsIdentiy and WindowsBuiltInRole objects
using System.Security.Principal;
// Needed to use the Process object to load apps from c#, particularly cmd.exe
using System.Diagnostics;

// These can probably be removed but leaving them here in case I need any of them later (they're common but not neccessary right now)
// using System.Collections.Generic;
// using System.ComponentModel;
// using System.Data;
// using System.Drawing;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace SendToPath
{
    
    public partial class Form1 : Form
    {
        // Path to edit System variables in the registry:
        // HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment
        // Backup Info:
        // String Variable - 
        // Name: Path
        // Type: Reg_Expand_Sz
        // Data: C:\Program Files (x86)\NVIDIA Corporation\PhysX\Common;%SystemRoot%\system32;%SystemRoot%;%SystemRoot%\System32\Wbem;%SYSTEMROOT%\System32\WindowsPowerShell\v1.0\;C:\Program Files\TortoiseSVN\bin;C:\Program Files\Calibre2\;C:\Program Files\Microsoft\Web Platform Installer\;C:\Program Files (x86)\Microsoft ASP.NET\ASP.NET Web Pages\v1.0\;C:\Program Files\Microsoft SQL Server\110\Tools\Binn\;C:\Program Files (x86)\Windows Kits\8.1\Windows Performance Toolkit\;C:\Program Files (x86)\Microsoft SDKs\TypeScript\1.0\
        public Form1()
        {
                InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // hide the form onload.
            // Form hide wasn't doing the job, this seems to better
            // Although this won't be there after I get the settings part implemented
            this.Opacity = 0.0f;

            // Hides the icon from displaying in the taskbar and only in the system tray.
            this.ShowInTaskbar = false; 

            // Testing
            // MessageBox.Show(GetCurrentPathString());

            // Get the arguments passed when clicking SendTo in the windows cascading menu
            string[] args = Environment.GetCommandLineArgs();
            
            // 2 lines of test code to use when not trying the sendto way
            // string folderPathOnly = @"C:\@Temp\RadAsm\RadASM.exe";
            // AddPathToSystemPathVariableInWin8(folderPathOnly);


            try
            {
                // Gets the path from path + filename
                // Uncomment these 2 lines when ready to test outside of vs
                string folderPathOnly = GetCurrentPath(args[1]);
                AddPathToSystemPathVariableInWin8(folderPathOnly);
            }
            catch
            {
                showNotifyBalloon("Couldn't get the path for some reason, maybe running it from visual studios?");
            }
            ExitForm();
        }

        /// <summary>
        /// This will convert an entire path + filename into just the path it resides in, without the filename.
        /// </summary>
        /// <param name="pathWithFilename">Full path</param>
        /// <returns>Just the path without the filename</returns>
        private string GetCurrentPath(string pathWithFilename)
        {
            try
            {
                // Current path of the item sent through send to
                return Path.GetDirectoryName(pathWithFilename).ToString();
            }
            catch
            {
                showNotifyBalloon("I could not retrieve the current path for some reason.");
                return "";
            }
        }


        // If windows 8 (not implemented yet)
        // For now this works with win 8, not sure what else
        private void AddPathToSystemPathVariableInWin8(string pathToAdd)
        {
            // System key to add to path vars, this is not a per user setting but global
            // string keyName = @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment";

            // Check to make sure this item isn't already in the registry
            // If this returns true false, then that means it's not already in the registry and can be added
            // If it returns true, then it's already there and all this can be skipped
            if (!isAlreadyInPathVariable(pathToAdd))
            {

                try
                {
                    // get non-expanded PATH environment variable    
                    // Need to find a new way to get the path info in order to not require admin privs
                    // string oldPath = (string)Registry.LocalMachine.CreateSubKey(keyName).GetValue("Path", "", RegistryValueOptions.DoNotExpandEnvironmentNames);
                    // MessageBox.Show(GetCurrentPathString());

                    // Test to make sure we have the proper info before adding to registry
                    // MessageBox.Show("Update we're going to add: \r\n" + oldPath + ";" + pathToAdd);

                    // create an object to start a new process
                    // ProcessStartInfo np = new ProcessStartInfo();
                    
                    // This will redirect the output so that we know exactly what happened
                    // np.RedirectStandardOutput = true;

                    // Makes sure that we're using a system shell, not just a child copy
                    // np.UseShellExecute = true;

                    // This is the parameters sent right after cmd.exe is launched
                    // string toExecute = "/K SETX PATH \"%Path%;" + pathToAdd + "\" /M";

                    // shows the exact text sent into the cmd.exe window, only needed for debugging
                    // MessageBox.Show(toExecute);

                    // Launches cmd.exe and passes paramters
                    // Process.Start("CMD.EXE", toExecute);

                    Process p = new Process();
                    p.StartInfo.UseShellExecute = true;
                    p.StartInfo.FileName = "CMD.EXE";
                    p.StartInfo.Arguments = "/K SETX PATH \"%Path%;" + pathToAdd + "\" /M";
                    p.Start();

                    string output = p.StandardOutput.ReadToEnd();

                    // it's not waiting for exit or something
                    p.WaitForExit();

                    // This doesn't seem to be working for some reason
                    MessageBox.Show(output);

                    // Updates the user to changes to %path%
                    showNotifyBalloon(output);

                    // showNotifyBalloon(pathToAdd + " added to the %Path% environment variable.  Should be useable from anywhere now.");
                }
                catch
                {
                    showNotifyBalloon("Not added for some reason.  You may not have the command line tool SETX, it comes with xp sp2 and anything later I believe.  Let me know if it doesn't work and your os and I'll fix it!");
                }

            }
                else
            {
                // Show tooltip with this message
                showNotifyBalloon(pathToAdd + " duplicate not allowed.");
            }

            // Then it will need to add a close method so that we never see the form and it closes
            // Closes the form since we're done with it.
            ExitForm();
        }

        // Check to see if we're running as admin
        private bool IsRunAsAdministrator()
        {
            var wi = WindowsIdentity.GetCurrent();
            var wp = new WindowsPrincipal(wi);

            return wp.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void showNotifyBalloon(string textToShow)
        {


            int msToShowTooltip = 5000;
            notifyInfo.BalloonTipText = textToShow;

            notifyInfo.ShowBalloonTip(msToShowTooltip);
        }

        // Calls the timer to start, interval is set in the timer control on the form, or can be set here technically
        private void ExitForm()
        {
            timerClose.Enabled = true;
        }

        // Closes after 5 seconds by default
        private void timerClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool isAlreadyInPathVariable(string pathToCheck)
        {
            // Registry path to find the key we want
            // string keyName = @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment";

            // Getting access denied it would seem
            string oldPathValue = Environment.GetEnvironmentVariable("Path");

            // Sets the variable info to oldPath so we can read it and see if it has the item already in it
            // string oldPathValue = (string)Registry.LocalMachine.CreateSubKey(keyName).GetValue("Path", "", RegistryValueOptions.DoNotExpandEnvironmentNames);

            // Check the string to see if pathToCheck is in it
            int checkForPath = oldPathValue.IndexOf(pathToCheck);

            // If the path to check was not in the current PATH variable, than return false so it can add it to the path
            if (checkForPath < 0)
                return false;
            // Otherwise return true because it's already in it so it won't add a second one to the path environment variable
            else
                return true;

        }

        
    }
}
