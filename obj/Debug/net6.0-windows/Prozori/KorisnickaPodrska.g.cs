﻿#pragma checksum "..\..\..\..\Prozori\KorisnickaPodrska.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ACB7BF4073BB83DE22D8AD1CCFD715C869EEFBF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using NISsoftver.Prozori;
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


namespace NISsoftver.Prozori {
    
    
    /// <summary>
    /// KorisnickaPodrska
    /// </summary>
    public partial class KorisnickaPodrska : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\..\Prozori\KorisnickaPodrska.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ChatListBox;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Prozori\KorisnickaPodrska.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MessageTextBox;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Prozori\KorisnickaPodrska.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Posalji;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NISsoftver;component/prozori/korisnickapodrska.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Prozori\KorisnickaPodrska.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ChatListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.MessageTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Btn_Posalji = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\..\Prozori\KorisnickaPodrska.xaml"
            this.Btn_Posalji.Click += new System.Windows.RoutedEventHandler(this.Btn_PosaljiTekst);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 99 "..\..\..\..\Prozori\KorisnickaPodrska.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_PovratakNaLogin);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
