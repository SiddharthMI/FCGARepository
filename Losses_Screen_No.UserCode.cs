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
    public partial class Losses_Screen_No
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void MergedUserCodeMethod1(RepoItemInfo spantagInfo, RepoItemInfo litagInfo, RepoItemInfo labeltagInfo, string LossYrNo)
        {
        	
        	int YrNo = Convert.ToInt32(LossYrNo);
        	for (int i=1;i<= YrNo;i++)
        	{
        		WebElement webElementItem = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']//tbody[#'dynamicBody']/tr["+i+"]/td[2]//span");
        		webElementItem.Click();
        	    WebElement webElementItem1 = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']/body/span//ul/li[@innertext='No']");
        		webElementItem1.Click();
        		WebElement webElementItem2 = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']//tbody[#'dynamicBody']/tr["+i+"]/td[5]/?/?/label[@innertext='No']");
        		webElementItem2.Click();
        	}
        	
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'spantagInfo' at Center.", spantagInfo);
            //spantagInfo.FindAdapter<SpanTag>().Click();
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'litagInfo' at Center.", litagInfo);
            //litagInfo.FindAdapter<LiTag>().Click();
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'labeltagInfo' at Center.", labeltagInfo);
            //labeltagInfo.FindAdapter<LabelTag>().Click();
        }

    }
}