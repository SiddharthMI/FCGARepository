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
    public partial class ReferralTrigger
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void MergedUserCodeMethod(RepoItemInfo spantagInfo, RepoItemInfo labeltagInfo)
        {
        	/*if(Env=="https://winston.fwcins.com/FWCPortal/User/Login/Login.html")
        	{
        		Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'labeltagInfo' at Center.", labeltagInfo);
                labeltagInfo.FindAdapter<LabelTag>().Click();
                
                Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Quote has been Referred.') on item 'labeltagInfo'.", labeltagInfo);
                Validate.AttributeEqual(labeltagInfo, "InnerText", "Quote has been Referred.");
                
        	}
        	else
        	{*/
                Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'spantagInfo' at Center.", spantagInfo);
                spantagInfo.FindAdapter<SpanTag>().Click();
            
                Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Quote Has Been Referred') on item 'spantagInfo'.", spantagInfo);
                Validate.AttributeEqual(spantagInfo, "InnerText", "Quote Has Been Referred");
        	//}
        }

    }
}