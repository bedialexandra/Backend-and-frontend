﻿#pragma checksum "..\..\..\..\Pages\LeadasokPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "930669E8066860576F1CA06BD61E4743D9FA5F47"
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
using wpf17_papirgyujtes.Pages;
using wpf17_papirgyujtes.ValidationRules;


namespace wpf17_papirgyujtes.Pages {
    
    
    /// <summary>
    /// LeadasokPage
    /// </summary>
    public partial class LeadasokPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\Pages\LeadasokPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SP_osztalyTanulo;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Pages\LeadasokPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBO_osztaly;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Pages\LeadasokPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBO_tanulo;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Pages\LeadasokPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DG_leadasok;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Pages\LeadasokPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SP_ujLeadas;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Pages\LeadasokPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_mennyiseg;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Pages\LeadasokPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_ujMennyiseg;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\Pages\LeadasokPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBL_osszesMennyiseg;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/wpf17_papirgyujtes;V1.0.0.0;component/pages/leadasokpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\LeadasokPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SP_osztalyTanulo = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.CBO_osztaly = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\..\Pages\LeadasokPage.xaml"
            this.CBO_osztaly.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CBO_osztaly_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CBO_tanulo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\..\..\Pages\LeadasokPage.xaml"
            this.CBO_tanulo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CBO_tanulo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DG_leadasok = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.SP_ujLeadas = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.TB_mennyiseg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.BTN_ujMennyiseg = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\..\Pages\LeadasokPage.xaml"
            this.BTN_ujMennyiseg.Click += new System.Windows.RoutedEventHandler(this.BTN_ujMennyiseg_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TBL_osszesMennyiseg = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

