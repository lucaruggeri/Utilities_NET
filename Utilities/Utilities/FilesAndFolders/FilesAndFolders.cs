using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.IO;

namespace Utilities
{
    public class FilesAndFolders
    {
        private string path { get; set; }
        private List<string> foldersIgnore { get; set; }
        private List<string> extensionsToFind { get; set; }

        public FilesAndFolders()
        {
            this.path = @"C:\IT\";
            this.foldersIgnore = new List<string>(new string[] { "_DA SMISTARE" });
            this.extensionsToFind = new List<string>(new string[] { "mp4", "avi" });
        }

        public List<string> SearchForLocalFiles()
        {
            List<string> filesFound = new List<string>();
            List<string> folders = Directory.GetDirectories(path).ToList();

            if (folders != null)
            {
                if (folders.Count() > 0)
                {
                    foreach(string folder in folders)
                    {
                        List<string> files = Directory.GetFiles(folder).ToList();

                        foreach (string file in files)
                        {
                            string extension = file.Substring(file.Length - 3);

                            if (this.extensionsToFind.Contains(extension))
                            {
                                filesFound.Add(Path.GetFileNameWithoutExtension(file));
                            }
                        }
                    }
                }
            }
            return filesFound;
        }
    }
}

