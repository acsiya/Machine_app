﻿#pragma checksum "E:\开发文件\Machine_APP\Machine_APP\MyPay.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7FF8D70BD5304B31FE52FBFD21E23DA00FEFE629A6000EFEA529F079F5F60AD6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Machine_APP
{
    partial class MyPay : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MyPay.xaml line 53
                {
                    this.but_car = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.but_car).Click += this.but_car_Click;
                }
                break;
            case 3: // MyPay.xaml line 48
                {
                    this.pccode = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // MyPay.xaml line 33
                {
                    this.sp_1_1 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5: // MyPay.xaml line 35
                {
                    this.but_wx = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.but_wx).Click += this.but_wx_Click;
                }
                break;
            case 6: // MyPay.xaml line 41
                {
                    this.but_zfb = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.but_zfb).Click += this.but_zfb_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

