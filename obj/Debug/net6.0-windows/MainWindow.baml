   M S B A M L   `   `   `  ����H  DFolderBrowser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FolderBrowserFolderBrowser  5   	       FolderBrowser.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:FolderBrowser     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�65   .��5	      � .+�5
   
   �� -   5         ��Name$ 	MainLabel��5
      $��Folder Browser��6#   $��Center=�6<   $��0,9,0,0q�6Y   $	��Top=�6j   $��35(�6�   $
��Bold"�6�   �� 5   
   -   5        $ FolderNameLabel��5      $��Folder Name��6)   $
��Left=�6?   $��	75,72,0,0q�6Z   $	��Top=�6m   $��20(�6�   $
��Bold"�6�    J� RenderTransformOrigin$ 0.502,1.039&�6�   $	��149��6�   � 5   
   .+�5      �� -   5         ��Name$ DirectoryTextbox��5      $
��Left=�60   $��
264,76,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��462��6�   $��20(�6�   5      �� 5   
   -   5         ��Name$ BrowseFilesButton��5      $��Browse Files...��6,   $
��Left=�6F   $��264,117,0,0q�6a   $	��Top=�6v   $��20(�6�   $	��151��6�   
����������	#FF007AC16�   �� 5   
   -   5         ��Name$ FileSystemEntryListView��5      $��	0,170,0,0q�5      $��16(�5       �� View 5      �� 5      .P�5      �� $
��Icon��6%   	 �� Width$	 50��63   
 �� CellTemplate
 5      �� 5      .R�5   "   �� ��6(   �� *icon+6B   5      5      �� 5      $
��Name��6%   $		 300��63    �� DisplayMemberBinding 6?   �� *
fileName+�� 5      $
��Path��6%   $		 450��63    6?   �� *
filePath+5      5!      �� 5"   
   -   5        $ DeleteFileButton��5"      $��Delete��6+   $
��Left=�6<   $��633,117,0,0q�6W   $	��Top=�6l   $��20(�6�   $��93��6�   
����������	#FFDA08086�   �� 5#   
   -   5        $ CreateFileButton��5#      $��Create ��6+   $
��Left=�6=   $��435,117,0,0q�6X   $	��Top=�6m   $��20(�6�   $��94��6�   
����������	#FF08DA726�   �� 5$   
   -   5        $ RenameFileButton��5$      $��Rename��6+   $
��Left=�6<   $��534,117,0,0q�6W   $	��Top=�6l   $��20(�6�   $��94��6�   
����������	#FF0DC8CE6�   5%      5&      