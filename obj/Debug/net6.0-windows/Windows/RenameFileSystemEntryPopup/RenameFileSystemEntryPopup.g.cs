﻿#pragma checksum "..\..\..\..\..\Windows\RenameFileSystemEntryPopup\RenameFileSystemEntryPopup.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56EFBE3EECFCF9488996D81166D5C17C94F9B0EC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FolderBrowser.Windows.RenameFileSystemEntryPopup;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace FolderBrowser.Windows.RenameFileSystemEntryPopup {
    
    
    /// <summary>
    /// RenameFileSystemEntryPopup
    /// </summary>
    public partial class RenameFileSystemEntryPopup : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\Windows\RenameFileSystemEntryPopup\RenameFileSystemEntryPopup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FileSystemEntryNewNameTextbox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\Windows\RenameFileSystemEntryPopup\RenameFileSystemEntryPopup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RenameFileSystemEntryButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FolderBrowser;component/windows/renamefilesystementrypopup/renamefilesystementry" +
                    "popup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\RenameFileSystemEntryPopup\RenameFileSystemEntryPopup.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FileSystemEntryNewNameTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.RenameFileSystemEntryButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\..\Windows\RenameFileSystemEntryPopup\RenameFileSystemEntryPopup.xaml"
            this.RenameFileSystemEntryButton.Click += new System.Windows.RoutedEventHandler(this.RenameFileSystemEntry);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
