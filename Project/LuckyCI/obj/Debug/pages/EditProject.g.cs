﻿#pragma checksum "..\..\..\pages\EditProject.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3B2B634385101A0F1F42C39D39CEE985"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace LuckyCI.pages {
    
    
    /// <summary>
    /// EditProject
    /// </summary>
    public partial class EditProject : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\pages\EditProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem All;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\pages\EditProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Add;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\pages\EditProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Preferences;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\pages\EditProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FramePage;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\pages\EditProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ProjectName;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\pages\EditProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgSource;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\pages\EditProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Datetime;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\pages\EditProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BuildDuration;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LuckyCI;component/pages/editproject.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\EditProject.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.All = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\..\pages\EditProject.xaml"
            this.All.Click += new System.Windows.RoutedEventHandler(this.btnToAllProjects_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Add = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\..\pages\EditProject.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.btnToAdd_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Preferences = ((System.Windows.Controls.MenuItem)(target));
            
            #line 21 "..\..\..\pages\EditProject.xaml"
            this.Preferences.Click += new System.Windows.RoutedEventHandler(this.btnToPreferences_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 24 "..\..\..\pages\EditProject.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnToHelp_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FramePage = ((System.Windows.Controls.Frame)(target));
            return;
            case 6:
            this.ProjectName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.ImgSource = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.Datetime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.BuildDuration = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

