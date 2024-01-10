using BMICalculator.Utils;
using FolderBrowser.Models;
using FolderBrowser.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FolderBrowser.Windows.RenameFileSystemEntryPopup
{
    /// <summary>
    /// Interaction logic for RenameFileSystemEntryPopup.xaml
    /// </summary>
    public partial class RenameFileSystemEntryPopup : Window
    {
        
        private ListViewEntry? listViewEntry;
        private MainWindow? mainWindow;
        public RenameFileSystemEntryPopup(ListViewEntry listViewEntry,MainWindow mainWindow)
        {
            InitializeComponent();            
            this.listViewEntry = listViewEntry;   
            this.mainWindow = mainWindow;
        }

        private void RenameFileSystemEntry(object sender, RoutedEventArgs e)
        {
            string newName = getFileSystemEntryNewName();
            string oldPath = listViewEntry!.filePath!;
            string newPath = getFileSystemEntryNewPath(newName);
            if (ValidationUtils.isValidFileName(newName))
            {
                DirectoryUtils.renameFile(oldPath, newPath);
            }
            else
            {
                DirectoryUtils.renameFolder(oldPath,newPath);
            }

            finalize();
        }
        private string getFileSystemEntryNewName()
        {
            string rawFileSystemEntryNewNameTextbox = FileSystemEntryNewNameTextbox.Text;
            string fileSystemEntryNewNameTextbox = 
                StringUtils.removeCarriageReturnAndNewLine(rawFileSystemEntryNewNameTextbox);
            return fileSystemEntryNewNameTextbox;
        }
       
        private string getFileSystemEntryNewPath(string newFileSystemEntryPath)
        {
            string oldPath = listViewEntry!.filePath!;
            string oldName = listViewEntry!.fileName!;
            return oldPath.Replace(oldName, newFileSystemEntryPath);    
        }
        private void finalize()
        {
            mainWindow!.refreshListView();
            this.Close();
        }
    }
}
