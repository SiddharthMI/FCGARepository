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
    public partial class UW_Loss_App_Screen
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Mouse_Click_UWPolicy_Exit(RepoItemInfo inputtagInfo)
        {
        	if(inputtagInfo.Exists()){
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo' at 42;14.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().Click("42;14");
        	}
        }

        public void MergedUserCodeMethod(RepoItemInfo buttontagInfo, RepoItemInfo buttontagInfo1, string lob)
        {
        	if(lob.Equals("GeneralLiability"))
        	{
              Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to exist. Associated repository item: 'buttontagInfo'", buttontagInfo, new ActionTimeout(15000));
              buttontagInfo.WaitForExists(15000);
        	}else{
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to exist. Associated repository item: 'buttontagInfo1'", buttontagInfo1, new ActionTimeout(15000));
            buttontagInfo1.WaitForExists(15000);
        	}
        }

    }
}