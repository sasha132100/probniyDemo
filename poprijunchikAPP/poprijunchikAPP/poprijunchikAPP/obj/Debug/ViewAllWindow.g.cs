﻿#pragma checksum "..\..\ViewAllWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AB1795CF6B0D6993F49BA8EB17805E4EC23229303BB01AB7FB360A48348B709F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace poprijunchikAPP {
    
    
    /// <summary>
    /// ViewAllWindow
    /// </summary>
    public partial class ViewAllWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\ViewAllWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchingTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ViewAllWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SortComboBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ViewAllWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FiltrComboBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ViewAllWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid mainDataGrid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ViewAllWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewAgent;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ViewAllWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeAgent;
        
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
            System.Uri resourceLocater = new System.Uri("/poprijunchikAPP;component/viewallwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ViewAllWindow.xaml"
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
            this.SearchingTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\ViewAllWindow.xaml"
            this.SearchingTextBox.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.SearchingTextBox_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 12 "..\..\ViewAllWindow.xaml"
            this.SearchingTextBox.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SearchingTextBox_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 12 "..\..\ViewAllWindow.xaml"
            this.SearchingTextBox.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.SearchingTextBox_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 12 "..\..\ViewAllWindow.xaml"
            this.SearchingTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchingTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SortComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\ViewAllWindow.xaml"
            this.SortComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FiltrComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\ViewAllWindow.xaml"
            this.FiltrComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FiltrComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.mainDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.AddNewAgent = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\ViewAllWindow.xaml"
            this.AddNewAgent.Click += new System.Windows.RoutedEventHandler(this.AddNewAgent_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ChangeAgent = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\ViewAllWindow.xaml"
            this.ChangeAgent.Click += new System.Windows.RoutedEventHandler(this.ChangeAgent_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

