﻿#pragma checksum "..\..\..\Window_Canvas.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35DFABA9D89453CB1198A0849BE3C2679E1A32A0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MyApplicationWPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace MyApplicationWPF {
    
    
    /// <summary>
    /// Window_Canvas
    /// </summary>
    public partial class Window_Canvas : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Window_Canvas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDisplay;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Window_Canvas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblInstructions;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Window_Canvas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCarName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Window_Canvas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCarName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Window_Canvas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblColor;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Window_Canvas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtColor;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Window_Canvas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblBrand;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Window_Canvas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBrand;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MyApplicationWPF;V1.0.0.0;component/window_canvas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Window_Canvas.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnDisplay = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Window_Canvas.xaml"
            this.btnDisplay.Click += new System.Windows.RoutedEventHandler(this.btnDisplay_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblInstructions = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblCarName = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtCarName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.lblColor = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txtColor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.lblBrand = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.txtBrand = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

