﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "03B8DC3399764F68EDD23F2FDB7D2813"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace Crypt {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt1;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb1;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb2;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb3;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar pb1;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb1;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt3;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid1;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt6;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt4;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt2;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt5;
        
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
            System.Uri resourceLocater = new System.Uri("/Minestrone;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 4 "..\..\MainWindow.xaml"
            ((Crypt.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bt1 = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\MainWindow.xaml"
            this.bt1.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rb1 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 55 "..\..\MainWindow.xaml"
            this.rb1.Checked += new System.Windows.RoutedEventHandler(this.rb1_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rb2 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 57 "..\..\MainWindow.xaml"
            this.rb2.Checked += new System.Windows.RoutedEventHandler(this.rb2_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rb3 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 58 "..\..\MainWindow.xaml"
            this.rb3.Checked += new System.Windows.RoutedEventHandler(this.rb3_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.pb1 = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 7:
            this.lb1 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.bt3 = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\MainWindow.xaml"
            this.bt3.Click += new System.Windows.RoutedEventHandler(this.bt3_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.datagrid1 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 66 "..\..\MainWindow.xaml"
            this.datagrid1.Drop += new System.Windows.DragEventHandler(this.datagrid1_Drop);
            
            #line default
            #line hidden
            
            #line 66 "..\..\MainWindow.xaml"
            this.datagrid1.LoadingRowDetails += new System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs>(this.datagrid1_LoadingRowDetails);
            
            #line default
            #line hidden
            
            #line 66 "..\..\MainWindow.xaml"
            this.datagrid1.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.DataGrid_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 10:
            this.bt6 = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\MainWindow.xaml"
            this.bt6.Click += new System.Windows.RoutedEventHandler(this.bt6_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.bt4 = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\MainWindow.xaml"
            this.bt4.Click += new System.Windows.RoutedEventHandler(this.bt4_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.bt2 = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\MainWindow.xaml"
            this.bt2.Click += new System.Windows.RoutedEventHandler(this.bt2_Click_1);
            
            #line default
            #line hidden
            return;
            case 13:
            this.bt5 = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\MainWindow.xaml"
            this.bt5.Click += new System.Windows.RoutedEventHandler(this.bt5_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

