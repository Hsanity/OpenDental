﻿#pragma checksum "..\..\..\Frms\FrmEClipboardDefEdit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8C5F7C20E55C804D8E2553ACBF332A0D5840E7FB6E22C2B8DDE23DABD5FCCA30"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OpenDental;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using WpfControls.UI;


namespace OpenDental {
    
    
    /// <summary>
    /// FrmEClipboardDefEdit
    /// </summary>
    public partial class FrmEClipboardDefEdit : OpenDental.FrmODBase, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Frms\FrmEClipboardDefEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfControls.UI.Button butSave;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Frms\FrmEClipboardDefEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfControls.UI.Button butDelete;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Frms\FrmEClipboardDefEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfControls.UI.TextBox textName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Frms\FrmEClipboardDefEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfControls.UI.TextBox textPatInstructions;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfControlsOD;component/frms/frmeclipboarddefedit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Frms\FrmEClipboardDefEdit.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.butSave = ((WpfControls.UI.Button)(target));
            return;
            case 2:
            this.butDelete = ((WpfControls.UI.Button)(target));
            return;
            case 3:
            this.textName = ((WpfControls.UI.TextBox)(target));
            return;
            case 4:
            this.textPatInstructions = ((WpfControls.UI.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

