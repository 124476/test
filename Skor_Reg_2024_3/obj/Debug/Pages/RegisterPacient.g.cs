﻿#pragma checksum "..\..\..\Pages\RegisterPacient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "41F807D665ECFD6FAF0C31D64F0EE3530475C0106B026CC6FA336A928A0271A0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Skor_Reg_2024_3.Pages;
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


namespace Skor_Reg_2024_3.Pages {
    
    
    /// <summary>
    /// RegisterPacient
    /// </summary>
    public partial class RegisterPacient : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\Pages\RegisterPacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateBorn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\RegisterPacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboPols;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\RegisterPacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateStart;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Pages\RegisterPacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateEnd;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Pages\RegisterPacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateNext;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Pages\RegisterPacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePolis;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Pages\RegisterPacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GotPhoto;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Pages\RegisterPacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GotQr;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Pages\RegisterPacient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
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
            System.Uri resourceLocater = new System.Uri("/Skor_Reg_2024_3;component/pages/registerpacient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\RegisterPacient.xaml"
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
            this.DateBorn = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.ComboPols = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.DateStart = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.DateEnd = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.DateNext = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.DatePolis = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.GotPhoto = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\Pages\RegisterPacient.xaml"
            this.GotPhoto.Click += new System.Windows.RoutedEventHandler(this.GotPhoto_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.GotQr = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\Pages\RegisterPacient.xaml"
            this.GotQr.Click += new System.Windows.RoutedEventHandler(this.GotQr_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Save = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\Pages\RegisterPacient.xaml"
            this.Save.Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

