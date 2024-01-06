using FolderBrowser.Models;
using FolderBrowser.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace FolderBrowser
{
    public partial class MainWindow : Window
    {
        private List<ListViewEntry>? listViewEntries;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void browseFiles(object sender, RoutedEventArgs e)
        {
            reset();
            string path = FolderBrowserDialogUtils.getPath();
            loadPathIntoDirectoryTextbox(path);
            loadFilesAndFoldersIntoListView(path);

        }

        private void reset()
        {
            listViewEntries = new List<ListViewEntry>();
            DirectoryTextbox.Text = string.Empty;
        }
        private void loadPathIntoDirectoryTextbox(string path)
        {
            DirectoryTextbox.Text = path;
        }
        private void loadFilesAndFoldersIntoListView(string path)
        {
            List<string> files = DirectoryUtils.getFilesAndFolders(path);
            List<string> fileNames = DirectoryUtils.getFilesNames(files);
            List<ImageSource> fileIcons = DirectoryUtils.getFilesIcons(files);

            int totalFiles = files.Count();
            for (int fileIndex = 0; fileIndex < totalFiles; fileIndex++)
            {
                ListViewEntry listViewEntry = new ListViewEntry()
                {
                    icon = fileIcons[fileIndex],
                    fileName = fileNames[fileIndex],
                    filePath = files[fileIndex]
                };
                listViewEntries?.Add(listViewEntry);
            }
            FilesListView.ItemsSource = listViewEntries;

        }
    }
}
