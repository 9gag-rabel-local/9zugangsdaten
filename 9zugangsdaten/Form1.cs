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

namespace _9zugangsdaten
{
    public partial class Form1 : Form
    {

        Dictionary<String, Project> Projects = new Dictionary<String, Project>();

        public Form1()
        {
            InitializeComponent();

            String[] ProjectFolders = Directory.GetDirectories("//vm1/media/workspace/projekte/"); // should be Program.RootDir
            Array.Sort(ProjectFolders);
            foreach (String ProjectFolderName in ProjectFolders)
            {
                String ProjectName = ProjectFolderName.Split('/').Last();
                Project NewProject = new Project(ProjectFolderName);
                if (NewProject.ZdFiles.Any())
                {
                    treeView1.Nodes.Add(new TreeNode(ProjectName));
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
                    fileSelector.Items.Insert(pos++, ZdFile);
                }

                fileSelector.SelectedIndex = 0;

            }
        }

        private void zugangsdaten_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            zugangsdaten.Text = File.ReadAllText(fileSelector.Text);
        }
    }
}
