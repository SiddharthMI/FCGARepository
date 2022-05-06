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

namespace Sid_FCGAProject.Common
{
    public partial class BacktoAgentRecordScreen
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void MergedUserCodeMethod(RepoItemInfo inputtagInfo, RepoItemInfo inputtagInfo1,string lob)
        {
        	if(lob.Equals("GeneralLiability"))
        	{
            Report.Log(ReportLevel.Info, "Wait", "Waiting 25s to exist. Associated repository item: 'inputtagInfo'", inputtagInfo, new ActionTimeout(25000));
            inputtagInfo.WaitForExists(80000);
        	}else{
            Report.Log(ReportLevel.Info, "Wait", "Waiting 25s to exist. Associated repository item: 'inputtagInfo1'", inputtagInfo1, new ActionTimeout(25000));
            inputtagInfo1.WaitForExists(80000);
        	}
        }

    }
}