﻿#pragma checksum "..\..\FormularioCambio.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0400EC313D8ADA96E59636AEE3631A9E34A61A960ADFD1E6233AF984CDE8A5AB"
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
    /// FormularioCambio
    /// </summary>
    public partial class FormularioCambio : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\FormularioCambio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TituloTextBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\FormularioCambio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdiomaTextBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\FormularioCambio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DuracionTextBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\FormularioCambio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SalaTextBox;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\FormularioCambio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker FechaInicioPicker;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\FormularioCambio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker FechaFinPicker;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\FormularioCambio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox GeneroListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Cine;component/formulariocambio.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FormularioCambio.xaml"
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
            this.TituloTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.IdiomaTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DuracionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.SalaTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.FechaInicioPicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.FechaFinPicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.GeneroListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            
            #line 100 "..\..\FormularioCambio.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addMovieBtn);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 101 "..\..\FormularioCambio.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.closeFormBtn);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

