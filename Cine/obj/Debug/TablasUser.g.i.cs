﻿#pragma checksum "..\..\TablasUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5F7407AC361489C78A054DB0EF970C3A48A5CFE5EB740B69483CDC5A8924337F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Cine;
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


namespace Cine {
    
    
    /// <summary>
    /// TablasUser
    /// </summary>
    public partial class TablasUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\TablasUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid MoviesDataGrid;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\TablasUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddMovies;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\TablasUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAbrirGUI3;
        
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
            System.Uri resourceLocater = new System.Uri("/Cine;component/tablasuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TablasUser.xaml"
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
            this.MoviesDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 16 "..\..\TablasUser.xaml"
            this.MoviesDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 16 "..\..\TablasUser.xaml"
            this.MoviesDataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.selectMovieClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddMovies = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\TablasUser.xaml"
            this.AddMovies.Click += new System.Windows.RoutedEventHandler(this.addMovieBtn);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 37 "..\..\TablasUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.logOutClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonAbrirGUI3 = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\TablasUser.xaml"
            this.ButtonAbrirGUI3.Click += new System.Windows.RoutedEventHandler(this.ButtonAbrirGUI3_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

