﻿#pragma checksum "C:\Users\Ryan\Source\Repos\Behrens\Behrens System\Behrens System\View\Quotes\Quote Items\QuoteHeader.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3FC06C296E3D26B9441871F2EF6262B5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Behrens_System.View.Quotes.Quote_Items
{
    partial class QuoteHeader : 
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
                    this.grdQuoteItems = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 2:
                {
                    this.btnTracking = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 159 "..\..\..\..\..\View\Quotes\Quote Items\QuoteHeader.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnTracking).Click += this.btnTracking_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnAmendments = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 164 "..\..\..\..\..\View\Quotes\Quote Items\QuoteHeader.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAmendments).Click += this.btnAmendments_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.btnQuoteStatus = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 168 "..\..\..\..\..\View\Quotes\Quote Items\QuoteHeader.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnQuoteStatus).Click += this.btnQuoteStatus_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.btnQuoteDocs = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 173 "..\..\..\..\..\View\Quotes\Quote Items\QuoteHeader.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnQuoteDocs).Click += this.btnQuoteDocs_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.BHQAdditionalInfo = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 7:
                {
                    this.btnCustomerInformation = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 114 "..\..\..\..\..\View\Quotes\Quote Items\QuoteHeader.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCustomerInformation).Click += this.btnCustomerInformation_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.btnQuoteInformation = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 124 "..\..\..\..\..\View\Quotes\Quote Items\QuoteHeader.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnQuoteInformation).Click += this.btnQuoteInformation_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.QuoteHeaderBox1 = (global::Windows.UI.Xaml.Controls.Frame)(target);
                    #line 134 "..\..\..\..\..\View\Quotes\Quote Items\QuoteHeader.xaml"
                    ((global::Windows.UI.Xaml.Controls.Frame)this.QuoteHeaderBox1).Loaded += this.btnCustomerInformation_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.tbQuoteNumber = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11:
                {
                    this.tbQuoteSubject = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12:
                {
                    this.tbQuoteStatus = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13:
                {
                    this.btnAddItem = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 40 "..\..\..\..\..\View\Quotes\Quote Items\QuoteHeader.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAddItem).Click += this.btnAddItem_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.btnGetCostings = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 15:
                {
                    this.btnSaveQuote = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 16:
                {
                    this.btnExitQuote = (global::Windows.UI.Xaml.Controls.Button)(target);
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

