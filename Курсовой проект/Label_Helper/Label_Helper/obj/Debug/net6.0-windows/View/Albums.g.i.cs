﻿#pragma checksum "..\..\..\..\View\Albums.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "158FEE389A6CFEA3696F99D546E4F6FC7B93A81C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Label_Helper.ViewModel;
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


namespace Label_Helper.View {
    
    
    /// <summary>
    /// Albums
    /// </summary>
    public partial class Albums : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\View\Albums.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ChooseArtists;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\View\Albums.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView AlbumListView;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\View\Albums.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView TrackListView;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\View\Albums.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AlbumNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\View\Albums.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TrackTitleTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Label_Helper;V1.0.0.0;component/view/albums.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Albums.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ChooseArtists = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.AlbumListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.TrackListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.AlbumNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TrackTitleTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 75 "..\..\..\..\View\Albums.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddAlbum_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 77 "..\..\..\..\View\Albums.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditAlbum_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 79 "..\..\..\..\View\Albums.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddTrack_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 81 "..\..\..\..\View\Albums.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditTrack_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 83 "..\..\..\..\View\Albums.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteAlbum_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 85 "..\..\..\..\View\Albums.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteTrack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

