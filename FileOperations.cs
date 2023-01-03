using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamFolderUpdater
{
    class FileOperations
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetConsoleWindow();

        private FileSystemWatcher watcher;
        public FileOperations(String Path)
        {

            watcher = new FileSystemWatcher(Path);

            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size
                                 | NotifyFilters.DirectoryName;
    

            /*watcher.Changed += OnChanged;
            watcher.Deleted += OnDeleted;
            watcher.Renamed += OnRenamed;*/
            watcher.Created += OnCreated;
            watcher.Error += OnError;
            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = false;
            watcher.EnableRaisingEvents = true;
        }

        /*private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            if (GetConsoleWindow() != IntPtr.Zero)
            {
                Console.WriteLine($"Changed: {e.FullPath}");
            }

        }*/

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            if (!File.GetAttributes(e.FullPath).HasFlag(FileAttributes.Directory))
                return;
            string value = $"Created: {e.FullPath}";
            if (GetConsoleWindow() != IntPtr.Zero)
            {
                Console.WriteLine(value);
            }
            String from_Path = ((TextBox)Application.OpenForms["Form1"].Controls.Find("from_TextBox", true)[0]).Text;
            String to_Path = ((TextBox)Application.OpenForms["Form1"].Controls.Find("to_TextBox", true)[0]).Text;

            if (((CheckBox)Application.OpenForms["Form1"].Controls.Find("closeSteam_CheckBox", true)[0]).Checked)
            {
                Process[] processes = Process.GetProcessesByName("Steam");
                String steam_path = ((TextBox)Application.OpenForms["Form1"].Controls.Find("steam_TextBox", true)[0]).Text;
                String steam_exec = Path.Combine(steam_path, "steam.exe");
                try
                {
                    if (processes.Length > 0)
                    {
                        processes[0].Kill(); // Probably dangerous and might cause file corruption but meh.
                        processes[0].WaitForExit(30000);
                    }
                }
                catch(Exception exception)
                {
                    if (GetConsoleWindow() != IntPtr.Zero)
                        PrintException(exception);
                }
                
                    

                Copy(from_Path, e.FullPath);

                if (!Directory.Exists(steam_path))
                {
                    MessageBox.Show("Steam path not found.");
                    return;
                }
                if (!File.Exists(steam_exec))
                {
                    MessageBox.Show("Steam executable not found.");
                    return;
                }
                Process.Start(steam_exec);
                return;
            }


            Copy(from_Path, e.FullPath);
            /*MessageBox.Show(value);*/
        }

        /*private static void OnDeleted(object sender, FileSystemEventArgs e)
        {
            if (GetConsoleWindow() != IntPtr.Zero)
            {
                Console.WriteLine($"Deleted: {e.FullPath}");
            }
        }*/

            

        /*private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            if (GetConsoleWindow() != IntPtr.Zero)
            {
                Console.WriteLine($"Renamed:");
                Console.WriteLine($"    Old: {e.OldFullPath}");
                Console.WriteLine($"    New: {e.FullPath}");
            }
        }*/

        private static void OnError(object sender, ErrorEventArgs e) =>
            PrintException(e.GetException());

        private static void PrintException(Exception ex)
        {
            if (ex != null)
            {
                if (GetConsoleWindow() != IntPtr.Zero)
                {
                    Console.WriteLine($"Message: {ex.Message}");
                    Console.WriteLine("Stacktrace:");
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine();
                    PrintException(ex.InnerException);
                }
            }
        }

        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);
            CopyAll(diSource, diTarget);
            
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            try
            {
                Directory.CreateDirectory(target.FullName);

                // Copy each file into the new directory.
                foreach (FileInfo fi in source.GetFiles())
                {
                    if (GetConsoleWindow() != IntPtr.Zero)
                    {
                        Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                    }
                    fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
                }

                // Copy each subdirectory using recursion.
                foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                    CopyAll(diSourceSubDir, nextTargetSubDir);
                }
            }
            catch(Exception e)
            {
                PrintException(e);
                MessageBox.Show(e.Message);
            }
        }
        public void Dispose()
        {
            this.watcher.Dispose();
        }
    }
}
