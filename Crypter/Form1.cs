using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Crypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Enabling default path
        public static
        string pathWithEnv = @"%USERPROFILE%\Downloads";
        string fullpath = Environment.ExpandEnvironmentVariables(pathWithEnv);

        public void ShowFiles(String pathFrom, Boolean incDirs)
        {
            // If subdir is active
            if (incDirs)
                {
                string[] allfiles = Directory.GetFiles(pathFrom, "*.*", SearchOption.AllDirectories);
                // Set minimum value for bar
                progressBar.Minimum = 0;
                // Set max length bar value related to files found
                progressBar.Maximum = allfiles.Length;
                // Action for each file
                foreach (var file in allfiles)
                {
                    // Increase bar for each file found
                    progressBar.Increment(1);
                    FileInfo info = new FileInfo(file);
                }
                    // Sump up files
                    resum.Text = "# of Files Read = " + progressBar.Value.ToString();
                    System.Windows.Forms.MessageBox.Show("Files found: " + allfiles.Length.ToString(), "Message");
                    // Restart bar
                    progressBar.Value = 0;
                }
            else
            {
                // Get files
                string[] files = Directory.GetFiles(pathFrom);
                // Set minimum value for bar
                progressBar.Minimum = 0;
                // Set max length bar value related to files found
                progressBar.Maximum = files.Length;
                foreach (var file in files)
                {
                    // Increase bar for each file found
                    progressBar.Increment(1);
                    FileInfo info = new FileInfo(file);
                }
                // Sump up files
                resum.Text = "# of Files Read = " + progressBar.Value.ToString();
                System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                // Restart bar
                progressBar.Value = 0;
            }
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (incDirs.Checked)
            {
                // Count files
                ShowFiles(fullpath, true);
            }
            else
            {
                // Count files
                ShowFiles(fullpath, false);
            }
        }

        private void Dir_Click(object sender, EventArgs e)
        {
            textBox1.Text = fullpath;
            FolderBrowserDialog folderDlg = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };

            // Show the FolderBrowserDialog.

            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)

            {

                textBox1.Text = folderDlg.SelectedPath;

                Environment.SpecialFolder root = folderDlg.RootFolder;

                fullpath = folderDlg.SelectedPath;

            }
        }
    }
 }
