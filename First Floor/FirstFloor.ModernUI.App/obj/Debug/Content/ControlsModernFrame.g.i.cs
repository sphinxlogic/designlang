﻿#pragma checksum "..\..\..\Content\ControlsModernFrame.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3549ADC36F3D13B86D987EB499F8C81D7D0B1CDD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Converters;
using FirstFloor.ModernUI.Windows.Navigation;
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


namespace FirstFloor.ModernUI.App.Content {
    
    
    /// <summary>
    /// ControlsModernFrame
    /// </summary>
    public partial class ControlsModernFrame : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Content\ControlsModernFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FirstFloor.ModernUI.Windows.Controls.ModernFrame Frame;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Content\ControlsModernFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextEvents;
        
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
            System.Uri resourceLocater = new System.Uri("/ModernUIDemo;component/content/controlsmodernframe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Content\ControlsModernFrame.xaml"
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
            this.Frame = ((FirstFloor.ModernUI.Windows.Controls.ModernFrame)(target));
            
            #line 17 "..\..\..\Content\ControlsModernFrame.xaml"
            this.Frame.FragmentNavigation += new System.EventHandler<FirstFloor.ModernUI.Windows.Navigation.FragmentNavigationEventArgs>(this.Frame_FragmentNavigation);
            
            #line default
            #line hidden
            
            #line 18 "..\..\..\Content\ControlsModernFrame.xaml"
            this.Frame.Navigated += new System.EventHandler<FirstFloor.ModernUI.Windows.Navigation.NavigationEventArgs>(this.Frame_Navigated);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\Content\ControlsModernFrame.xaml"
            this.Frame.Navigating += new System.EventHandler<FirstFloor.ModernUI.Windows.Navigation.NavigatingCancelEventArgs>(this.Frame_Navigating);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\Content\ControlsModernFrame.xaml"
            this.Frame.NavigationFailed += new System.EventHandler<FirstFloor.ModernUI.Windows.Navigation.NavigationFailedEventArgs>(this.Frame_NavigationFailed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextEvents = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

