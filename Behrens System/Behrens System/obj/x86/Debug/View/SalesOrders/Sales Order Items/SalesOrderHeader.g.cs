﻿#pragma checksum "C:\Users\Ryan\Source\Repos\Behrens\Behrens System\Behrens System\View\SalesOrders\Sales Order Items\SalesOrderHeader.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3E8393C46B622ECCF1ED5839C4E3F9AA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Behrens_System.View.SalesOrders.Sales_Order_Items
{
    partial class SalesOrderHeader : 
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
                    this.stkQuoteProjects = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 2:
                {
                    this.grdQuoteItems = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3:
                {
                    this.btnAdditionalNotes = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 257 "..\..\..\..\..\View\SalesOrders\Sales Order Items\SalesOrderHeader.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAdditionalNotes).Click += this.btnAdditionalNotes_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.btnQuoteStatus = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 261 "..\..\..\..\..\View\SalesOrders\Sales Order Items\SalesOrderHeader.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnQuoteStatus).Click += this.btnQuoteStatus_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.btnQuoteDocs = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 265 "..\..\..\..\..\View\SalesOrders\Sales Order Items\SalesOrderHeader.xaml"
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
                    this.tbCustomerName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.tbCustomerPosition = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9:
                {
                    this.tbEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10:
                {
                    this.tbTelephone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11:
                {
                    this.tbAddressLine1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12:
                {
                    this.tbAddressLine2 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13:
                {
                    this.tbAddressLine3 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14:
                {
                    this.tbCountry = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15:
                {
                    this.tbPostcode = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 16:
                {
                    this.tbCompany = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 17:
                {
                    this.tbAccountNumber = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 18:
                {
                    this.tbAccountManager = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 19:
                {
                    this.tbQuoteNumber = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 20:
                {
                    this.tbQuoteSubject = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 21:
                {
                    this.tbQuoteStatus = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 22:
                {
                    this.btnAddItem = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 23:
                {
                    this.btnGetCostings = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 24:
                {
                    this.btnSaveQuote = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 25:
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

