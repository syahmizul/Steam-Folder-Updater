using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace SteamFolderUpdater
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetConsoleWindow();

        [DllImport("User32.dll")]
        static extern int ShowWindow(IntPtr hwnd, int nShow);

        private FileOperations fileOperations;

        public Form1()
        {
            AllocConsole();
            ShowWindow(GetConsoleWindow(), 0);
            InitializeComponent();
        }

        private void InitSettings()
        {
            closeSteam_CheckBox.Checked = Properties.Settings1.Default.restartsteam_cb;
            steam_TextBox.Text = Properties.Settings1.Default.steam_path;
            from_TextBox.Text = Properties.Settings1.Default.from_path;
            to_TextBox.Text = Properties.Settings1.Default.to_path;
            watcherCheckBox.Checked = Properties.Settings1.Default.watcher_cb;
            consoleEnable.Checked = Properties.Settings1.Default.consolelog_cb;
        }
        /*
         * All the boilerplate stuff.
         */
        private void from_TextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(from_TextBox, "Folder where files will be copied from.");
        }
        private void to_TextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(to_TextBox, "Folder where each of it's sub-directories will be replaced by contents from the \" From : \" folder.");
        }
        private void watcherCheckBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(watcherCheckBox, "Automatically transfer the files after a new folder appears at the \" To : \" path.");
        }
        private void consoleEnable_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(consoleEnable, "Display all fired events to a console.");
        }
        private void btn_BrowseFrom_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            from_TextBox.Text = folderBrowserDialog1.SelectedPath;
            folderBrowserDialog1.Dispose();
        }
        private void btn_BrowseTo_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            to_TextBox.Text = folderBrowserDialog1.SelectedPath;
            folderBrowserDialog1.Dispose();
        }
        private void consoleEnable_CheckedChanged(object sender, EventArgs e)
        {
            IntPtr hwnd = GetConsoleWindow();

            if (consoleEnable.Checked)
                ShowWindow(hwnd, 5);
            else
                ShowWindow(hwnd, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            steam_TextBox.Text = folderBrowserDialog1.SelectedPath;
            folderBrowserDialog1.Dispose();
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(from_TextBox.Text))
            {
                MessageBox.Show("\" From \": path not found.");
                return;
            }
            if (!Directory.Exists(to_TextBox.Text))
            {
                MessageBox.Show("\" To \": path not found.");
                return;
            }

            foreach (DirectoryInfo directoryInfo in new DirectoryInfo(to_TextBox.Text).GetDirectories())
            {
                FileOperations.Copy(from_TextBox.Text, directoryInfo.FullName);
            }


        }

        private void watcherCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (watcherCheckBox.Checked)
            {
                if (!Directory.Exists(from_TextBox.Text))
                {
                    MessageBox.Show("\" From \": path not found.");
                    watcherCheckBox.Checked = false;
                    return;
                }

                if (!Directory.Exists(to_TextBox.Text))
                {
                    MessageBox.Show("\" To \": path not found.");
                    watcherCheckBox.Checked = false;
                    return;
                }
                fileOperations = new FileOperations(to_TextBox.Text);
                if (GetConsoleWindow() != IntPtr.Zero)
                {
                    Console.WriteLine("Enabled watcher.");
                }
            }
            else
            {
                if (fileOperations != null)
                {
                    fileOperations.Dispose();
                    fileOperations = null;
                }
            }


        }

        private void from_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (GetConsoleWindow() != IntPtr.Zero)
            {
                if (fileOperations != null)
                {
                    Console.WriteLine("Paths are modified.Turning off watcher");
                    fileOperations.Dispose();
                    fileOperations = null;
                    watcherCheckBox.Checked = false;
                }
            }
        }

        private void to_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (GetConsoleWindow() != IntPtr.Zero)
            {

                if (fileOperations != null)
                {
                    Console.WriteLine("Paths are modified.Turning off watcher");
                    fileOperations.Dispose();
                    fileOperations = null;
                    watcherCheckBox.Checked = false;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fileOperations != null)
            {
                fileOperations.Dispose();
                fileOperations = null;
            }
                FreeConsole();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings1.Default.watcher_cb = watcherCheckBox.Checked ;
            Properties.Settings1.Default.consolelog_cb = consoleEnable.Checked ;
            Properties.Settings1.Default.restartsteam_cb = closeSteam_CheckBox.Checked ;
            Properties.Settings1.Default.steam_path = steam_TextBox.Text ;
            Properties.Settings1.Default.from_path = from_TextBox.Text ;
            Properties.Settings1.Default.to_path = to_TextBox.Text ;
            Properties.Settings1.Default.Save();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings1.Default.Reset();
            watcherCheckBox.Checked = Properties.Settings1.Default.watcher_cb;
            consoleEnable.Checked = Properties.Settings1.Default.consolelog_cb;
            closeSteam_CheckBox.Checked = Properties.Settings1.Default.restartsteam_cb;
            steam_TextBox.Text = Properties.Settings1.Default.steam_path;
            from_TextBox.Text = Properties.Settings1.Default.from_path;
            to_TextBox.Text = Properties.Settings1.Default.to_path;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitSettings();
        }
    }
}
