using BMICalculator.Utils;
using FolderBrowser.Models;
using FolderBrowser.Utils;
using FolderBrowser.Windows;
using FolderBrowser.Windows.NewFileSystemEntryPopup;
using FolderBrowser.Windows.RenameFileSystemEntryPopup;
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
        private NewFileSystemEntryPopup? newFileSystemEntryPopup;
        private string? path;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void refreshListView()
        {
            listViewEntries = new List<ListViewEntry>();
            loadFileSystemEntriesIntoListView(path!);
        }

        private void browseFiles(object sender, RoutedEventArgs e)
        {
            reset();
            path = FolderBrowserDialogUtils.getPath();
            if (isPathLoaded())
            {
                loadPathIntoDirectoryTextbox(path);
                loadFileSystemEntriesIntoListView(path);
            }
        }
        private void createFile(object sender, RoutedEventArgs e)
        {
            if (!isPathLoaded())
            {
                showPathNotLoadedMessage();
                return;
            }
            showNewFileSystemEntryPopup(path!);
        }
        private void deleteFile(object sender, RoutedEventArgs e)
        {
            if (!isOkToDeleteFile()) return;
            ListViewEntry selectedFileSystemEntry = (ListViewEntry)FileSystemEntryListView.SelectedItem!;
            string fileSystemEntryName = selectedFileSystemEntry.fileName!;            
            string fileSystemEntryPath = selectedFileSystemEntry.filePath!;
            
            if (ValidationUtils.isValidFileName(fileSystemEntryName))
            {
                DirectoryUtils.deleteFile(fileSystemEntryPath);
            }
            else
            {
                DirectoryUtils.deleteFolder(fileSystemEntryPath);
            }
            refreshListView();
        }
        private void renameFile(object sender, RoutedEventArgs e)
        {
            ListViewEntry selectedFileSystemEntry = (ListViewEntry)FileSystemEntryListView.SelectedItem!;
            showRenameFileSystemEntryPopup(selectedFileSystemEntry);
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
        private void loadFileSystemEntriesIntoListView(string path)
        {
            List<string> files = getFileSystemEntries(path);
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
            FileSystemEntryListView.ItemsSource = listViewEntries;

        }
        private bool isPathLoaded()
        {
            if (String.IsNullOrEmpty(path)) return false;
            return true;
        }
        private void showPathNotLoadedMessage()
        {
            DefaultMessageBoxArguments defaultMessageBoxArguments =
               new DefaultMessageBoxArguments(
                   "You haven't selected a Directory. Try again.", "Warning",
                   MessageBoxButton.OK, MessageBoxImage.Error
                );
            MessageBoxUtils.showDefaultMessageBox(defaultMessageBoxArguments);
        }
        private void showFileSystemEntryNotSelectedMessage()
        {
            DefaultMessageBoxArguments defaultMessageBoxArguments =
               new DefaultMessageBoxArguments(
                   "You haven't seleceted a file or folder. Try again.", "Warning",
                   MessageBoxButton.OK, MessageBoxImage.Error
                );
            MessageBoxUtils.showDefaultMessageBox(defaultMessageBoxArguments);
        }
        private bool isDeleteFileSystemEntry()
        {
            DefaultMessageBoxArguments defaultMessageBoxArguments =
              new DefaultMessageBoxArguments(
                  "You are about to permanently delete a file/folder. " +
                    "Do you really want to continue?.",
                  "Warning",
                  MessageBoxButton.OKCancel, MessageBoxImage.Warning
               );
            MessageBoxResult result = MessageBoxUtils.getYesNoMessageBoxResult(defaultMessageBoxArguments);
            if (result == MessageBoxResult.Yes) { return true; }
            return false;
        }
        private void showNewFileSystemEntryPopup(string path)
        {
            newFileSystemEntryPopup = new NewFileSystemEntryPopup(path,this);
            newFileSystemEntryPopup.Show();
        }
        private bool isOkToDeleteFile()
        {
            if (!isPathLoaded())
            {
                showPathNotLoadedMessage();
                return false;
            }

            ListViewEntry selectedFileSystemEntry = (ListViewEntry)FileSystemEntryListView.SelectedItem!;
            if (selectedFileSystemEntry == null)
            {
                showFileSystemEntryNotSelectedMessage();
                return false;
            }

            if (!isDeleteFileSystemEntry())
            {
                return false;
            }
            return true;
        }

        private List<string> getFileSystemEntries(string path)
        {
            string[] files = DirectoryUtils.getFiles(path);
            string[] folders = DirectoryUtils.getFolders(path);
            List<string> result = files.Concat(folders).ToList();
            return result;
        }
        private void showRenameFileSystemEntryPopup(ListViewEntry selectedFileSystemEntry)
        {
            RenameFileSystemEntryPopup renameFileSystemEntryPopup = new RenameFileSystemEntryPopup(selectedFileSystemEntry,this);
            renameFileSystemEntryPopup.Show();
        }



    }
}
