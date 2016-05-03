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

namespace _9zugangsdaten
{
    public partial class Form1 : Form
    {

        Dictionary<String, Project> Projects = new Dictionary<String, Project>();

        public Form1()
        {
            InitializeComponent();

            openInExplorer.BackgroundImage = Image.FromFile("../../graphic/folder.png");

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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Project Project = Projects[e.Node.Text];

            fileSelector.Items.Clear();

            if (Project.ZdFiles.Count > 0)
            {
                zugangsdaten.Text = File.ReadAllText(Project.ZdFiles[0][0]);

                int pos = 0;
                foreach (String ZdFile in Project.ZdFiles.SelectMany(i => i))
                {
                    fileSelector.Items.Insert(pos++, ZdFile.Substring(Program.RootDir.Length, ZdFile.Length - Program.RootDir.Length));
                }

                fileSelector.SelectedIndex = 0;

            }
        }

        private void zugangsdaten_TextChanged(object sender, EventArgs e)
        {

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
