using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;

namespace smartCopyWatcher
{
        public class Watcher
        {
            private FileSystemWatcher watcher = new FileSystemWatcher();
            private IniFileReader inireader = new IniFileReader(Environment.CurrentDirectory + "\\resources\\settings.ini");
            public string path { get; set; }
            private string tmp;
            private string destPath;
            private FileInfo info;
            private string name;

            public void watch()
            {
                this.path = this.inireader.Read("filedestination", "settings");
                if (!Directory.Exists(this.path))
                    Directory.CreateDirectory(this.path);
                this.watcher.Path = this.path;
                this.watcher.NotifyFilter = NotifyFilters.LastWrite;
                this.watcher.Filter = "*.exe";
                this.watcher.Changed += new FileSystemEventHandler(this.OnChanged);
                this.watcher.EnableRaisingEvents = true;
            }

            private void OnChanged(object source, FileSystemEventArgs e)
            {
                while (File.Exists(e.FullPath) && this.CheckFileOpen(e.FullPath))
                    Thread.Sleep(500);

                this.watcher.EnableRaisingEvents = false;

                this.destPath = this.path + e.Name;

                try
                {
                    this.info = new FileInfo(this.destPath);
                    this.tmp = string.Format("{0:yyyy-MM-dd_HH-mm}", (object) this.info.LastWriteTime);
                    this.name = Path.GetFileNameWithoutExtension(this.destPath) + "_" + this.tmp +
                                Path.GetExtension(this.destPath);
                    string str;
                    Console.WriteLine(e.Name.Substring(0, 30));

                    #region smartPerformCollabApp

                    if (e.Name.Substring(0, 24).Equals("smartPerformCollabApp_RC"))
                    {
                        if (!Directory.Exists(this.path + "smartPerformCollabApp_RC\\"))
                        {
                            Directory.CreateDirectory(this.path + "smartPerformCollabApp_RC\\");
                        }

                        str = this.path + "smartPerformCollabApp_RC\\" + this.name;
                    }
                    else if (e.Name.Substring(0, 26).Equals("smartPerformCollabApp_Beta"))
                    {
                        if (!Directory.Exists(this.path + "smartPerformCollabApp_Beta\\"))
                        {
                            Directory.CreateDirectory(this.path + "smartPerformCollabApp_Beta\\");
                        }

                        str = this.path + "smartPerformCollabApp_Beta\\" + this.name;
                    }
                    else if (e.Name.Length >= 39 && Regex.IsMatch(e.Name.Substring(0, 39),
                        @"smartPerformCollabApp_\d\d\d\d_\d_\d_\d\d\d\d_x\d\d"))
                    {
                        if (!Directory.Exists(this.path + "smartPerformCollabApp_Release\\"))
                        {
                            Directory.CreateDirectory(this.path + "smartPerformCollabApp_Release\\");
                        }

                        str = this.path + "smartPerformCollabApp_Release\\" + this.name;
                    }

                    #endregion

                    #region smartPerform

                    else if (e.Name.Substring(0, 15).Equals("smartPerform_RC"))
                    {

                        if (!Directory.Exists(this.path + "smartPerform_RC\\"))
                        {
                            Directory.CreateDirectory(this.path + "smartPerform_RC\\");
                        }

                        str = this.path + "smartPerform_RC\\" + this.name;
                    }
                    else if (e.Name.Substring(0, 17).Equals("smartPerform_Beta"))
                    {
                        if (!Directory.Exists(this.path + "smartPerform_Beta\\"))
                        {
                            Directory.CreateDirectory(this.path + "smartPerform_Beta\\");
                        }

                        str = this.path + "smartPerform_Beta\\" + this.name;
                    }
                    else if (Regex.IsMatch(e.Name.Substring(0, 30), @"smartPerform_\d\d\d\d_\d_\d_\d\d\d\d_x\d\d"))
                    {
                        if (!Directory.Exists(this.path + "smartPerform_Release\\"))
                        {
                            Directory.CreateDirectory(this.path + "smartPerform_Release\\");
                        }

                        str = this.path + "smartPerform_Release\\" + this.name;
                    }

                    #endregion

                    #region DataVision

                    else if (Regex.IsMatch(e.Name.Substring(0, 19), @"DataVisionICU_RC\d_"))
                    {
                        if (!Directory.Exists(this.path + "DataVisionICU_RC\\"))
                        {
                            Directory.CreateDirectory(this.path + "DataVisionICU_RC\\");
                        }

                        str = this.path + "DataVisionICU_RC\\" + this.name;
                    }
                    else if (e.Name.Substring(0, 18).Equals("DataVisionICU_Beta"))
                    {
                        if (!Directory.Exists(this.path + "DataVisionICU_Beta\\"))
                        {
                            Directory.CreateDirectory(this.path + "DataVisionICU_Beta\\");
                        }

                        str = this.path + "DataVisionICU_Beta\\" + this.name;
                    }
                    else if (e.Name.Length >= 31 &&
                             Regex.IsMatch(e.Name.Substring(0, 31), @"DataVisionICU_\d\d\d\d_\d_\d_\d\d\d\d_x\d\d"))
                    {
                        if (!Directory.Exists(this.path + "DataVisionICU_Release\\"))
                        {
                            Directory.CreateDirectory(this.path + "DataVisionICU_Release\\");
                        }

                        str = this.path + "DataVisionICU_Release\\" + this.name;
                    }

                    #endregion

                    else
                    {
                        str = this.path + "\\" + this.name;
                    }

                    if (File.Exists(str))
                        File.Delete(str);
                    File.Move(this.info.FullName, str);
                }
                finally
                {
                    this.watcher.EnableRaisingEvents = true;
                }
            }

            public bool CheckFileOpen(string path)
            {
                try
                {
                    new FileStream(path, FileMode.Open).Close();
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return true;
                }
            }
        }
    }