using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;
using System.Runtime.InteropServices;

namespace OstPathHelper
{
    public partial class mainForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private  String source_file_path;
        private String target_file_path;
        private String complete_target_file_path;


        [DllImport("kernel32.dll")]
        static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, int dwFlags);
        static int SYMLINK_FLAG_DIRECTORY = 1;
        static int SYMLINK_FLAG_FILE = 0;
        public mainForm()
        {
            InitializeComponent();

            if (checkProcessRunning("outlook")){
                status_label.Text = "Found Outlook Running Process!";
                status_label.ForeColor = Color.Red;
                close_outlook_process_btn.Enabled = true;
                go_btn.Enabled = false;
            }
            else
            {
                status_label.Text = "Outlook process not found.";
                status_label.ForeColor = Color.Green;
                close_outlook_process_btn.Enabled = false;
                go_btn.Enabled = true;

            }
        }


        private Boolean checkProcessRunning(string process_name)
        {
            Process[] pname = Process.GetProcessesByName(process_name);
            if (pname.Length == 0)
                return false;
            else
                return true;
        }
        private void Close_outlook_process_btn_Click(object sender, EventArgs e)
        {
            if (killProcess("outlook"))
            {
                status_label.Text = "Outlook process not found.";
                status_label.ForeColor = Color.Green;
                close_outlook_process_btn.Enabled = false;
                go_btn.Enabled = true;

            }
            else
            {
                MessageBox.Show("Outlook process could not be kille, please close Outlook manually.");
            }
        }
        private Boolean killProcess(string process_name)
        {
            try
{
                foreach (Process proc in Process.GetProcessesByName(process_name))
                {
                    proc.Kill();
                  
                }
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(process_name + " process could not be killed");
                logger.Error(ex.StackTrace);
                return true;
            }
        }

        private String select_directory()
        {

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return dialog.FileName;
            }
            return null;
        }

        private String select_file()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    return openFileDialog.FileName;

                }
            }
            return null;
        }

        private void Original_file_path_btn_Click(object sender, EventArgs e)
        {
           
            

            source_file_path = select_file();
            if (!string.IsNullOrEmpty(source_file_path))
            {
                original_file_path_txt.Text = source_file_path;
            }
        }

        private void Target_file_path_btn_Click(object sender, EventArgs e)
        {
            target_file_path = select_directory();
            if (!string.IsNullOrEmpty(target_file_path))
            {
                target_file_path_txt.Text = target_file_path;
            }
        }

        private void Go_btn_Click(object sender, EventArgs e)
        {

            if ((!string.IsNullOrEmpty(source_file_path)) && (!string.IsNullOrEmpty(target_file_path))){
                if (moveFile())
                {
                    if (CreateSymbolicLink(source_file_path, complete_target_file_path, SYMLINK_FLAG_FILE))
                    {
                        MessageBox.Show("Process done !.");
                    }
                    else
                    {
                        MessageBox.Show("Failed creating link: " + source_file_path + " <===> " + complete_target_file_path);
                    }
                }
                else
                {
                    MessageBox.Show("Failed moving File: " + source_file_path + " to " + complete_target_file_path);
                }
            }
            else
            {
                MessageBox.Show("You must select the source file and destination folder");
            }

        }

        private Boolean moveFile()
        {
            try
            {
                complete_target_file_path = Path.Combine(target_file_path, Path.GetFileName(source_file_path));
                File.Move(source_file_path, complete_target_file_path);
                logger.Info("Moved file " + source_file_path + " to " + complete_target_file_path);
                return true;
            }
            catch (IOException ex)
            {
                logger.Info("Failed to move file " + source_file_path + " to " + complete_target_file_path);
                return false;
            }
        }
    }
}
