﻿#pragma checksum "..\..\DoktorHastaBilgileri.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "060EDDB699C98A241E7F6FA0B7AE0B96C2375E56C61D9D6E8765ABBC8B69CDF6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
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
using WPFHastaneOtomasyon;


namespace WPFHastaneOtomasyon {
    
    
    /// <summary>
    /// DoktorHastaBilgileri
    /// </summary>
    public partial class DoktorHastaBilgileri : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\DoktorHastaBilgileri.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataView;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\DoktorHastaBilgileri.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hastaemail;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\DoktorHastaBilgileri.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hastaad;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\DoktorHastaBilgileri.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hastasoyad;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\DoktorHastaBilgileri.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hastaadres;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\DoktorHastaBilgileri.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker hastadogum;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\DoktorHastaBilgileri.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hastasifre;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFHastaneOtomasyon;component/doktorhastabilgileri.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DoktorHastaBilgileri.xaml"
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
            
            #line 11 "..\..\DoktorHastaBilgileri.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 12 "..\..\DoktorHastaBilgileri.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DataView = ((System.Windows.Controls.DataGrid)(target));
            
            #line 13 "..\..\DoktorHastaBilgileri.xaml"
            this.DataView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.hastaemail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.hastaad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.hastasoyad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.hastaadres = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.hastadogum = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            
            #line 25 "..\..\DoktorHastaBilgileri.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 26 "..\..\DoktorHastaBilgileri.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_5);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 27 "..\..\DoktorHastaBilgileri.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 28 "..\..\DoktorHastaBilgileri.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 13:
            this.hastasifre = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

