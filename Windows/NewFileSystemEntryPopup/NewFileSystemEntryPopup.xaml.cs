using BMICalculator.Utils;
using FolderBrowser.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FolderBrowser.Windows.NewFileSystemEntryPopup
{
    /// <summary>
    /// Interaction logic for NewFileSystemEntryPopup.xaml
    /// </summary>
    public partial class NewFileSystemEntryPopup : Window
    {
        private string? path;
        private MainWindow? mainWindow;
        public NewFileSystemEntryPopup(string path, MainWindow? mainWindow)
        {
            InitializeComponent();
            this.path = path;
            this.mainWindow = mainWindow;
        }

        private void CreateFileSystemEntryButton_Click(object sender, RoutedEventArgs e)
        {
            string fileSystemEntryName = getFileSystemEntryName();
            string fullPath = getFullPath(fileSystemEntryName);
            if(ValidationUtils.isValidFileName(fileSystemEntryName))
            {
                DirectoryUtils.createNewFile(fullPath);
            }
            else
            {
                DirectoryUtils.createNewFolder(fullPath);
            }
            
            finalize();
        }
        private string getFileSystemEntryName()
        {
            string rawFileSystemEntryName = FileSystemEntryNameTextbox.Text;
            string fileSystemEntryName = StringUtils.removeCarriageReturnAndNewLine(rawFileSystemEntryName);    
            return fileSystemEntryName;
        }
        private string getFullPath(string fileSystemEntryName)
        {
            return string.Concat(path, "\\", fileSystemEntryName);
        }
        private void finalize() {
            mainWindow!.refreshListView();
            this.Close();
        }
    }
}
