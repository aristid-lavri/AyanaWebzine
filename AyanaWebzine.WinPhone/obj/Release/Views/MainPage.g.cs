﻿

#pragma checksum "E:\Projects\ayanaWebzine_New\AyanaWebzine\AyanaWebzine.WinPhone\Views\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BA30DFA05C37E0319962DB38878C2224"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AyanaWebzine.WinPhone.Views
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 36 "..\..\Views\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Reload;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 82 "..\..\Views\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.ListCategories_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 91 "..\..\Views\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.EditoPage_Tapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

