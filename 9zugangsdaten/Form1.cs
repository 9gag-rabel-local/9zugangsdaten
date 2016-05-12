using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Diagnostics;
using System.Net;

namespace _9zugangsdaten
{
    public partial class Form1 : Form
    {

        Dictionary<String, Project> Projects = new Dictionary<String, Project>();

        public Form1()
        {
            InitializeComponent();

            openInExplorer.BackgroundImage = Image.FromFile("../../graphic/folder.png");

            // Prüfen ob VM1 Projekte gefunden werden
            if (!Directory.Exists(Program.RootDir))
            {
                MessageBox.Show("Der Projekte-Ordner unter " + Program.RootDir + " konnte nicht gefunden werden.", "VM1 Projekte nicht gefunden!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(1);
            }

            // Version Check
            using (System.Net.WebClient client = new WebClient())
            {
                try
                {
                    String LatestVersion = client.DownloadString("http://9gag.rabel.local/9zugangsdaten/version.txt");
                    if (LatestVersion != Program.Version)
                    {
                        this.Text += " (Outdated!)";
                    }
                }
                catch (Exception e)
                {

                }
            }

            String[] ProjectFolders = Directory.GetDirectories(Program.RootDir);
            Array.Sort(ProjectFolders);
            foreach (String ProjectFolderName in ProjectFolders)
            {
                String ProjectName = ProjectFolderName.Split('/').Last();
                Project NewProject = new Project(ProjectFolderName);
                if (NewProject.ZdFiles.Any())
                {
                    projectExplorer.Nodes.Add(new TreeNode(ProjectName));
                    Projects.Add(ProjectName, NewProject);
                }
            }
            
        }

        private void projectExplorer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Project Project = Projects[e.Node.Text];

            fileSelector.Items.Clear();

            if (Project.ZdFiles.Count > 0)
            {
                String zugangsdatenText = Project.ZdFiles[0][0];
                Byte[] UTF8Bytes = Encoding.UTF8.GetBytes(zugangsdatenText);
                zugangsdaten.Text = File.ReadAllText(Encoding.UTF8.GetString(UTF8Bytes));

                int pos = 0;
                foreach (String ZdFile in Project.ZdFiles.SelectMany(i => i))
                {
                    fileSelector.Items.Insert(pos++, ZdFile.Substring(Program.RootDir.Length, ZdFile.Length - Program.RootDir.Length));
                }

                fileSelector.SelectedIndex = 0;
            }
        }

        private void fileSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            zugangsdaten.Text = File.ReadAllText(Program.RootDir + "/" + fileSelector.Text);
        }

        private void openInExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Program.RootDirWin + projectExplorer.SelectedNode.Text);
        }
        
    }
}
