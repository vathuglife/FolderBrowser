using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Runtime.InteropServices;
using System.Windows.Media;
using System.Runtime;

namespace FolderBrowser.Utils
{
    public class DirectoryUtils
    {
        public static List<string> getFilesAndFolders(string path)
        {
            string[] files = getFiles(path);
            string[] folders = getFolders(path);
            List<string> result = files.Concat(folders).ToList();
            return result;
        }
        public static List<string> getFilesNames(List<string> files)
        {
            List<string> names = new List<string>();
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                names.Add(name);
            }
            return names;

        }
        public static List<ImageSource> getFilesIcons(List<string> files)
        {

            List<ImageSource> icons = new List<ImageSource>();
            foreach (string file in files)
            {
                ImageSource icon = IconUtils.GetIcon(file, false);
                icons.Add(icon);
            }

            return icons;
        }
        private static string[] getFiles(string path)
        {
            return Directory.GetFiles(path);
        }
        private static string[] getFolders(string path)
        {
            return Directory.GetDirectories(path);
        }
    }

}
