﻿#pragma checksum "C:\Users\rcurran\Documents\GitHub\Behrens\Behrens System\Behrens System\View\Projects\Projects.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E9507CC5C37872D9FA0BDC9E9209709A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Behrens_System.View.Projects
{
    partial class Projects : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.btnViewAllProjects = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 86 "..\..\..\..\View\Projects\Projects.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnViewAllProjects).Click += this.btnViewAllProjects_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.btnViewProjectsProgress = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 95 "..\..\..\..\View\Projects\Projects.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnViewProjectsProgress).Click += this.btnViewProjectsProgress_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnViewQuotesSent = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 4:
                {
                    this.btnViewQuotesCalledIn = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 5:
                {
                    this.btnNewProject = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 37 "..\..\..\..\View\Projects\Projects.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnNewProject).Click += this.btnNewProject_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.btnNewProjectQ = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 50 "..\..\..\..\View\Projects\Projects.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnNewProjectQ).Click += this.btnNewProjectQ_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.btnViewProject = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 63 "..\..\..\..\View\Projects\Projects.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnViewProject).Click += this.btnViewProject_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

