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

namespace Sid_FCGAProject
{
    public partial class Losses_Screen_Yes
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void MergedUserCodeMethod(RepoItemInfo spantagInfo, RepoItemInfo litagInfo, RepoItemInfo inputtagInfo, RepoItemInfo labeltagInfo, RepoItemInfo inputtagInfo1, RepoItemInfo inputtagInfo2, string LossYrNo)
        {
        	
        	int YrNo = Convert.ToInt32(LossYrNo);
        	for (int i=1;i<= YrNo;i++)
        	{
        		WebElement webElementItem = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']//tbody[#'dynamicBody']/tr["+i+"]/td[2]//span");
        		webElementItem.Click();
        	    WebElement webElementItem1 = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']/body/span//ul/li[@innertext='Yes']");
        		webElementItem1.Click();
        		WebElement webElementItem2 = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']//tbody[#'dynamicBody']/tr["+i+"]/td[3]/?/?/input[@name>'carrier']");
        		webElementItem2.Click();
        		webElementItem2.PressKeys(LCarrierName);
        		WebElement webElementItem3 = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']//tbody[#'dynamicBody']/tr["+i+"]/td[4]/?/?/label[@innertext='Yes']");
        		webElementItem3.Click();
        		WebElement webElementItem4 = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']//tbody[#'dynamicBody']/tr["+i+"]/td[6]/?/?/input[@name>'claims']");
        		webElementItem4.Click();
        		webElementItem4.PressKeys(LClaimCount);
        		WebElement webElementItem5 = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']//tbody[#'dynamicBody']/tr["+i+"]/td[7]/?/?/input[@name>'incurred']");
        		webElementItem5.Click();
        		webElementItem5.PressKeys(IncurredAmount);
        	}
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'spantagInfo' at Center.", spantagInfo);
            //spantagInfo.FindAdapter<SpanTag>().Click();
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'litagInfo' at Center.", litagInfo);
            //litagInfo.FindAdapter<LiTag>().Click();
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo' at Center.", inputtagInfo);
            //inputtagInfo.FindAdapter<InputTag>().Click();
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LCarrierName' with focus on 'inputtagInfo'.", inputtagInfo);
            //inputtagInfo.FindAdapter<InputTag>().PressKeys(LCarrierName);
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'labeltagInfo' at Center.", labeltagInfo);
            //labeltagInfo.FindAdapter<LabelTag>().Click();
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo1' at Center.", inputtagInfo1);
            //inputtagInfo1.FindAdapter<InputTag>().Click();
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LClaimCount' with focus on 'inputtagInfo1'.", inputtagInfo1);
            //inputtagInfo1.FindAdapter<InputTag>().PressKeys(LClaimCount);
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo2' at Center.", inputtagInfo2);
            //inputtagInfo2.FindAdapter<InputTag>().Click();
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$IncurredAmount' with focus on 'inputtagInfo2'.", inputtagInfo2);
            //inputtagInfo2.FindAdapter<InputTag>().PressKeys(IncurredAmount);
        }

    }

}