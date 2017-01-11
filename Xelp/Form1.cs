using System;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Diagnostics;
using System.IO;
using System.Configuration;

namespace Xelp
{
    public partial class Xelp : MetroForm
    {
        #region Declare Variables
        static string sSource = "Xelp";
        static string sLog = "Application";
        static int pCount = 0;
        public static string Keytemploc = "TempLocation";
        public static string Keyreadyloc = "ReadyLocation";
        public static string Keyignoredir = "IgnoreDirs";
        public static string Keyignorefiles = "IgnoreFiles";
        public static string exLocation;
        public static string exTempLocation;
        public static string[] Ignoredirs;
        public static string[] IgnoreFiles;
        public bool Zip = true;
        public bool Handbrake = true;
        #endregion

        public Xelp()
        {
            InitializeComponent();
        }

        public void SaveKey(string Key, String Value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Remove(Key);
            config.AppSettings.Settings.Add(Key, Value);
            config.Save(ConfigurationSaveMode.Modified);
        }

        public void LoadConfig()
        {
            var reader = new AppSettingsReader();
            UpdateLog("Loading Config File");
            exTempLocation = reader.GetValue("TempLocation", typeof(string)).ToString();
            txtbxTemploc.Text = exTempLocation;
            exLocation = reader.GetValue("ReadyLocation", typeof(string)).ToString();
            txtbxReadyloc.Text = exLocation;
            string Ignoredirsstring = reader.GetValue("IgnoreDirs", typeof(string)).ToString().ToLower();
            Ignoredirs = Ignoredirsstring.Split(',');
            txtbxIgnoreDir.Text = Ignoredirsstring;
            string IgnoreFilesString = reader.GetValue("IgnoreFiles", typeof(string)).ToString().ToLower();
            IgnoreFiles = IgnoreFilesString.Split(',');
            txtbxIgnoreFiles.Text = IgnoreFilesString;
        }

        public void precheck()
        {
            if (!File.Exists(@"C:\Program Files\7-Zip\7z.exe"))
            {
                Zip = false;
                link7zip.Visible = true;
            }
            if (!File.Exists(@"C:\media\Scripts\HandBrakeCLI\HandBrakeCLI.exe"))
            {
                Handbrake = false;
                linkHanbrake.Visible = true;
            }
        }

        public void Form1_Load(object sender, EventArgs args)
        {
            LoadConfig();
            precheck();
            if (!Directory.Exists(exTempLocation))
            {
                Directory.CreateDirectory(exTempLocation);
            }
            if (!Directory.Exists(exLocation))
            {
                Directory.CreateDirectory(exLocation);
            }
            pCount = 0;
            //Create Event log if needed
            if (!EventLog.SourceExists(sSource))
                EventLog.CreateEventSource(sSource, sLog);
            WriteEventinfo("Xelp Started");
            btnSaveChanges.Visible = false;
            LblStatus.Text = "Waiting....";

        }

        public void Autorun(string [] args)
        {
            if (args.Count() > 0)
            {
                string wdir = args[0].ToString();

                if (Directory.Exists(wdir))
                {
                    ProcessFolder(wdir);
                }
                if (File.Exists(wdir))
                {
                    ProcessFiles(wdir);
                }

                if (pCount < 1)
                {
                    WriteEventerr("No files found to process.... Please check: " + wdir);
                }
                WriteEventinfo("Xelp Closing");
            }
        }

        public void ProcessFiles(String directory)
        {
            String[] Filelist = Directory.GetFiles(directory);

            try
            {
                foreach (string file in Filelist)
                {
                    string fExt = Path.GetExtension(file).ToString().ToLower();
                    //if the file is zipped then unzip it.
                    if (fExt == ".rar" || fExt == ".zip")
                    {
                        pCount++;
                        string wfile = Path.GetFileName(file).ToString().ToLower();
                        WriteEventinfo("Found RAR: " + wfile);
                        //Check for 7zip location
                        if (Zip)
                        {
                            ProcessStartInfo startInfo = new ProcessStartInfo();
                            startInfo.CreateNoWindow = true;//Set to False to show 7zip log
                            startInfo.UseShellExecute = false;
                            startInfo.FileName = @"C:\Program Files\7-Zip\7z.exe";
                            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo.Arguments = "e " + '"' + directory + @"\" + wfile + '"' + " -y -o" + exTempLocation;
                            WriteEventinfo("Unzipping w/ the following Arguments: " + startInfo.Arguments.ToString());
                            try
                            {
                                // Start the process with the info we specified.
                                // Call WaitForExit and then the using-statement will close.
                                using (Process exeProcess = Process.Start(startInfo))
                                {
                                    WriteEventinfo("Unzipping: " + wfile);
                                    exeProcess.WaitForExit();
                                }
                                WriteEventinfo("Finished Processing: " + wfile);
                            }
                            catch (Exception e)
                            {

                                WriteEventerr("Error: " + e.Message.ToString());
                            }
                        }
                        else
                        {
                            WriteEventerr("Can't find 7Zip. Please check");
                        }

                    }
                    else if (fExt == ".jpg" || fExt == ".mkv" || fExt == ".avi" || fExt == ".mp4")
                    {
                        string wFile = Path.GetFileName(file).ToString().ToLower();
                        if (!IgnoreFiles.Any(s => wFile.Contains(s)))
                        {
                            pCount++;

                            WriteEventinfo("Found JPG: " + wFile);

                            WriteEventinfo("Copying: " + wFile);
                            if (fExt == ".mp4")
                            {
                                File.Copy(directory + @"\" + wFile, exLocation + @"\" + wFile, true);
                            }
                            else File.Copy(directory + @"\" + wFile, exTempLocation + @"\" + wFile, true);
                            WriteEventinfo("Finished Copying: " + wFile);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                WriteEventerr(ex.Message.ToString());
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void ProcessFolder(String targetdir)
        {
            ProcessFiles(targetdir);

            string[] subDirectoryEntries = Directory.GetDirectories(targetdir);
            foreach (string subDir in subDirectoryEntries)
            {
                string dir = subDir.ToString().ToLower();
                if (!Ignoredirs.Any(s => dir.Contains(s)))
                {
                    ProcessFolder(subDir);
                }
            }

        }
        public void copyfile(String source, String dest)
        {
            //Still not sure about this.... Debating adding versioning to files if they need overwritten.
            if (File.Exists(dest))
            {
                string fname = Path.GetFileNameWithoutExtension(source);
                string extension = Path.GetExtension(source);
                

            }
            else File.Copy(source, dest, true);
        }
        public void WriteEventinfo(string sMessage)
        {
            
            EventLog.WriteEntry(sSource, sMessage, EventLogEntryType.Information, 15);
            UpdateLog(sMessage);
            LblStatus.Text = sMessage;
            
        }
        private void UpdateLog(string message)
        {
            rtxtbxlog.Text += DateTime.Now.ToShortDateString() + " " + message;
            rtxtbxlog.Text += Environment.NewLine;
        }
        private void WriteEventerr(string sMessage)
        {
            EventLog.WriteEntry(sSource, sMessage, EventLogEntryType.Error, 4);
            UpdateLog("Error: " + sMessage);
        }

        public void mediacheck()
        {
            if (Handbrake)
            {
                String[] toConvert = Directory.GetFiles(exTempLocation);
                foreach (string file in toConvert)
                {
                    string fExt = Path.GetExtension(file);
                    string fullName = Path.GetFileName(file);
                    if (fExt == ".mp4")
                    {
                        File.Move(file, exLocation + @"\" + fullName);
                    }
                    else
                    {
                        string fName = Path.GetFileNameWithoutExtension(file);
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.CreateNoWindow = true;// Set to false to show Handbrake verbose
                        startInfo.UseShellExecute = false;
                        startInfo.FileName = @"C:\media\Scripts\HandBrakeCLI\HandBrakeCLI.exe";
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        startInfo.Arguments = "-i " + file + " -f av_mp4 -e x264 -E av_aac -o " + exLocation + @"\" + fName + ".mp4";
                        try
                        {
                            // Start the process with the info we specified.
                            //Call WaitForExit and then the using-statement will close.
                            using (Process exeProcess = Process.Start(startInfo))
                            {
                                WriteEventinfo("MP4 Conversion: " + fullName);
                                exeProcess.WaitForExit();
                            }
                            WriteEventinfo("Finished Processing: " + fullName);
                            File.Delete(file);
                        }
                        catch (Exception e)
                        {

                            WriteEventerr("Error: " + e.Message.ToString());
                        }
                    }
                }
            }
            else
            {
                WriteEventerr("Can't find HandBrake. Please check");
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            mediacheck();
        }

        private void txtbxTemploc_CausesValidationChanged(object sender, EventArgs e)
        {
        }

        private void txtbxTemploc_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Visible = true;
        }

        private void txtbxReadyloc_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Visible = true;
        }

        private void tooltipSubdir_Popup(object sender, PopupEventArgs e)
        {
        }

        private void txtbxIgnoreDir_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Visible = true;
        }

        private void txtbxIgnoreFiles_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Visible = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            SaveKey(Keytemploc, txtbxTemploc.Text);
            SaveKey(Keyreadyloc, txtbxReadyloc.Text);
            SaveKey(Keyignoredir, txtbxIgnoreDir.Text);
            SaveKey(Keyignorefiles, txtbxIgnoreFiles.Text);
            MessageBox.Show("Changes Sucessfully Changed.");
        }

        private void btnprocfolder_Click(object sender, EventArgs e)
        {
            metroProgressSpinner1.Visible = true;
            string wdir = txtbxstartfolder.Text;
            if (Directory.Exists(wdir))
            {
                ProcessFolder(wdir);
            }
            if (File.Exists(wdir))
            {
                ProcessFiles(wdir);
            }
            mediacheck();
            metroProgressSpinner1.Visible = false;
        }

        private void link7zip_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.7-zip.org/download.html");
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.7-zip.org/download.html");
        }

        private void linkHanbrake_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://handbrake.fr/");
        }
    }
}
