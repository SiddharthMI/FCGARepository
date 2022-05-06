﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Sid_FCGAProject.WC_Product
{
    public partial class Applicationpage
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void MergedUserCodeMethod(RepoItemInfo spantagInfo, RepoItemInfo inputtagInfo, RepoItemInfo spantagInfo1, RepoItemInfo inputtagInfo1, RepoItemInfo inputtagInfo2, RepoItemInfo inputtagInfo3, RepoItemInfo inputtagInfo4, RepoItemInfo webdocumentInfo, RepoItemInfo inputtagInfo5, RepoItemInfo spantagInfo2, RepoItemInfo inputtagInfo6, RepoItemInfo inputtagInfo7)
        {
        	if(AddAditionalInsured == "")
        	{
        		
        	}else {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'spantagInfo' at Center.", spantagInfo);
            spantagInfo.FindAdapter<SpanTag>().Click();
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo' at Center.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AddAditionalInsured' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys(AddAditionalInsured);
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys("{Return}");
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'spantagInfo1' at Center.", spantagInfo1);
            spantagInfo1.FindAdapter<SpanTag>().Click();
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo' at Center.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Relationshipdetails' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys(Relationshipdetails);
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys("{Return}");
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo1' at Center.", inputtagInfo1);
            inputtagInfo1.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Add_FTEmp' with focus on 'inputtagInfo1'.", inputtagInfo1);
            inputtagInfo1.FindAdapter<InputTag>().PressKeys(Add_FTEmp);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo2' at Center.", inputtagInfo2);
            inputtagInfo2.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Add_PTEmp' with focus on 'inputtagInfo2'.", inputtagInfo2);
            inputtagInfo2.FindAdapter<InputTag>().PressKeys(Add_PTEmp);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo3' at Center.", inputtagInfo3);
            inputtagInfo3.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$App_Address1' with focus on 'inputtagInfo3'.", inputtagInfo3);
            inputtagInfo3.FindAdapter<InputTag>().PressKeys(App_Address1);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo4' at Center.", inputtagInfo4);
            inputtagInfo4.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$App_Address2' with focus on 'webdocumentInfo'.", webdocumentInfo);
            webdocumentInfo.FindAdapter<WebDocument>().EnsureVisible();
            Keyboard.Press(App_Address2);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'webdocumentInfo' at Center.", webdocumentInfo);
            webdocumentInfo.FindAdapter<WebDocument>().Click();
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo5' at Center.", inputtagInfo5);
            inputtagInfo5.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'inputtagInfo5' at Center.", inputtagInfo5);
            inputtagInfo5.FindAdapter<InputTag>().DoubleClick();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$App_City' with focus on 'inputtagInfo5'.", inputtagInfo5);
            inputtagInfo5.FindAdapter<InputTag>().PressKeys(App_City);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'spantagInfo2' at Center.", spantagInfo2);
            spantagInfo2.FindAdapter<SpanTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$App_State' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().EnsureVisible();
            Keyboard.Press(App_State);
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys("{Return}");
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo6' at Center.", inputtagInfo6);
            inputtagInfo6.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$App_ZipCode' with focus on 'inputtagInfo6'.", inputtagInfo6);
            inputtagInfo6.FindAdapter<InputTag>().PressKeys(App_ZipCode);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo7' at Center.", inputtagInfo7);
            inputtagInfo7.FindAdapter<InputTag>().Click();
        }
      }
    }
}