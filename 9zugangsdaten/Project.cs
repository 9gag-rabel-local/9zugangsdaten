using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _9zugangsdaten
{

    class Project
    {

        public List<String[]> ZdFiles = new List<String[]>();

        public Project(String projectPathName)
        {
            foreach (String Path in Program.Paths)
            {
                if (Directory.Exists(projectPathName + "/" + Path)) {
                    String[] Files = Directory.GetFiles(projectPathName + "/" + Path, "*.TXT");
                    if (Files.Any()) ZdFiles.Add(Files);
                }
            }

        }

    }
}
