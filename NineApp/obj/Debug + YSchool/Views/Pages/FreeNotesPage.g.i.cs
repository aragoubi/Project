﻿#pragma checksum "..\..\..\..\Views\Pages\FreeNotesPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E7F715116486DC616C0400E1FACC557A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using Nine.Views.Controls;
using RadialMenu.Controls;
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
using System.Windows.Interactivity;
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


namespace Nine.Views.Pages {
    
    
    /// <summary>
    /// FreeNotesPage
    /// </summary>
    public partial class FreeNotesPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 81 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Nine.Views.Controls.AppBar AppBar;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Nine.Views.Controls.BottomSideBar BottomSideBar;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Nine.Views.Controls.SideBar LessonSidebar;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Nine.Views.Controls.RadialMenus RadialMenu;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Nine.Views.Controls.RadialMenuStateButton RadialMenuOpenButton;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Nine.Views.Controls.TouchScrollViewer LessonContainer;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LessonContent;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Nine.Views.Controls.DrawingAreaBackground DrawingAreaBound;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Nine.Views.Controls.LayerStack LayerStack;
        
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
            System.Uri resourceLocater = new System.Uri("/NineApp;component/views/pages/freenotespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
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
            
            #line 8 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
            ((Nine.Views.Pages.FreeNotesPage)(target)).PreviewTouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Page_PreviewTouchDown);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
            ((Nine.Views.Pages.FreeNotesPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AppBar = ((Nine.Views.Controls.AppBar)(target));
            return;
            case 3:
            this.BottomSideBar = ((Nine.Views.Controls.BottomSideBar)(target));
            return;
            case 4:
            this.LessonSidebar = ((Nine.Views.Controls.SideBar)(target));
            return;
            case 5:
            
            #line 123 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
            ((System.Windows.Controls.Grid)(target)).TouchUp += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.LessonContainer_TouchUp);
            
            #line default
            #line hidden
            
            #line 124 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
            ((System.Windows.Controls.Grid)(target)).ManipulationDelta += new System.EventHandler<System.Windows.Input.ManipulationDeltaEventArgs>(this.LessonContainer_ManipulationDelta);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RadialMenu = ((Nine.Views.Controls.RadialMenus)(target));
            return;
            case 7:
            this.RadialMenuOpenButton = ((Nine.Views.Controls.RadialMenuStateButton)(target));
            return;
            case 8:
            this.LessonContainer = ((Nine.Views.Controls.TouchScrollViewer)(target));
            return;
            case 9:
            this.LessonContent = ((System.Windows.Controls.Grid)(target));
            
            #line 158 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
            this.LessonContent.MouseRightButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.LessonContent_MouseRightButtonUp);
            
            #line default
            #line hidden
            
            #line 159 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
            this.LessonContent.TouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.LessonContainer_TouchDown);
            
            #line default
            #line hidden
            
            #line 160 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
            this.LessonContent.TouchMove += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.LessonContainer_TouchMove);
            
            #line default
            #line hidden
            
            #line 161 "..\..\..\..\Views\Pages\FreeNotesPage.xaml"
            this.LessonContent.StylusDown += new System.Windows.Input.StylusDownEventHandler(this.LessonContainer_StylusDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.DrawingAreaBound = ((Nine.Views.Controls.DrawingAreaBackground)(target));
            return;
            case 11:
            this.LayerStack = ((Nine.Views.Controls.LayerStack)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

