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
    public partial class Agent_Business_Summary
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void MergedUserCodeMethod(RepoItemInfo spantagInfo, RepoItemInfo inputtagInfo, RepoItemInfo inputtagInfo1, RepoItemInfo divtagInfo, RepoItemInfo inputtagInfo2, RepoItemInfo spantagInfo1, RepoItemInfo inputtagInfo3, RepoItemInfo divtagInfo1)
        {
        	string[] StateNameList = StateName.Split(',');
        	int StateCount = StateNameList.Length;
        	
        	string[] ClassCodeList = ClassDesc.Split(',');
        	int ClassCodeCount = ClassCodeList.Length;
        
        	int i=1;
        	string WCStateName = StateNameList[0];
            string WCClassCode = ClassCodeList[0];
        	
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'spantagInfo' at Center.", spantagInfo);
            spantagInfo.FindAdapter<SpanTag>().Click();
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo' at Center.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$StateName' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys(WCStateName);
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys("{Return}");
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo1' at Center.", inputtagInfo1);
            inputtagInfo1.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ClassCode' with focus on 'inputtagInfo1'.", inputtagInfo1);
            inputtagInfo1.FindAdapter<InputTag>().PressKeys(WCClassCode);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'divtagInfo' at Center.", divtagInfo);
            divtagInfo.FindAdapter<DivTag>().Click();
            
            if(StateCount>1 || ClassCodeCount>1){
 
            	if(StateCount>1){
            		WCStateName = StateNameList[i];
            	}
            	
            	if(ClassCodeCount>1){
            		WCClassCode = ClassCodeList[i];
            	}
            	
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo2' at Center.", inputtagInfo2);
            inputtagInfo2.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'spantagInfo1' at Center.", spantagInfo1);
            spantagInfo1.FindAdapter<SpanTag>().Click();
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo' at Center.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$StateName' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys(WCStateName);
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys("{Return}");
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo3' at Center.", inputtagInfo3);
            inputtagInfo3.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ClassCode' with focus on 'inputtagInfo3'.", inputtagInfo3);
            inputtagInfo3.FindAdapter<InputTag>().PressKeys(WCClassCode);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'divtagInfo1' at Center.", divtagInfo1);
            divtagInfo1.FindAdapter<DivTag>().Click();
            i++;
          }
        }

        public void MergedUserCodeMethod1(RepoItemInfo inputtagInfo, RepoItemInfo inputtagInfo1, RepoItemInfo inputtagInfo2, RepoItemInfo tabletagInfo, RepoItemInfo inputtagInfo3, RepoItemInfo inputtagInfo4, RepoItemInfo inputtagInfo5)
        {
        	
        	string[] TxtFTEmpList = TxtFTEmp.Split(',');
        	int TxtFTEmpCount = TxtFTEmpList.Length;
        	
        	string[] TxtPTEmpList = TxtPTEmp.Split(',');
        	int TxtPTEmpCount = TxtPTEmpList.Length;
        	
        	string[] TxtGrossPayrollList = TxtGrossPayroll.Split(',');
        	int TxtGrossPayrollCount = TxtGrossPayrollList.Length;

        		
            int i = 1 ;
        	string WCFTEmpNo = TxtFTEmpList[0];
            string WCPTEmpNo = TxtPTEmpList[0];
            string WCGrossPayrolAmt = TxtGrossPayrollList[0];
        	
        	
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'inputtagInfo' at Center.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().DoubleClick();
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$TxtFTEmp' on item 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().Element.SetAttributeValue("Value", WCFTEmpNo);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'inputtagInfo1' at Center.", inputtagInfo1);
            inputtagInfo1.FindAdapter<InputTag>().DoubleClick();
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$TxtPTEmp' on item 'inputtagInfo1'.", inputtagInfo1);
            inputtagInfo1.FindAdapter<InputTag>().Element.SetAttributeValue("Value", WCPTEmpNo);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo2' at Center.", inputtagInfo2);
            inputtagInfo2.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.");
            Delay.Duration(5000, false);
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$TxtGrossPayroll' on item 'inputtagInfo2'.", inputtagInfo2);
            inputtagInfo2.FindAdapter<InputTag>().Element.SetAttributeValue("Value", WCGrossPayrolAmt);
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.");
            Delay.Duration(5000, false);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'tabletagInfo' at Center.", tabletagInfo);
            tabletagInfo.FindAdapter<TableTag>().Click();
            
            if(TxtFTEmpCount>1 && TxtPTEmpCount>1 && TxtGrossPayrollCount>1){
            
            	WCFTEmpNo = TxtFTEmpList[i];
                WCPTEmpNo = TxtPTEmpList[i];
                WCGrossPayrolAmt = TxtGrossPayrollList[i];
            	
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'inputtagInfo3' at 48;17.", inputtagInfo3);
            inputtagInfo3.FindAdapter<InputTag>().DoubleClick("48;17");
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$TxtFTEmp' on item 'inputtagInfo3'.", inputtagInfo3);
            inputtagInfo3.FindAdapter<InputTag>().Element.SetAttributeValue("Value", WCFTEmpNo);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'inputtagInfo4' at 25;19.", inputtagInfo4);
            inputtagInfo4.FindAdapter<InputTag>().DoubleClick("25;19");
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$TxtPTEmp' on item 'inputtagInfo4'.", inputtagInfo4);
            inputtagInfo4.FindAdapter<InputTag>().Element.SetAttributeValue("Value", WCPTEmpNo);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo5' at Center.", inputtagInfo5);
            inputtagInfo5.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.");
            Delay.Duration(5000, false);
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$TxtGrossPayroll' on item 'inputtagInfo5'.", inputtagInfo5);
            inputtagInfo5.FindAdapter<InputTag>().Element.SetAttributeValue("Value", WCGrossPayrolAmt);
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.");
            Delay.Duration(5000, false);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'tabletagInfo' at Center.", tabletagInfo);
            tabletagInfo.FindAdapter<TableTag>().Click();
            i++;
            }
        }

        public void Key_sequence_TxtBussInsuredName(RepoItemInfo inputtagInfo)
        {
        	//Random rnd = new Random();
            //int Rand  = rnd.Next(1000, 9999);
            //BusinessName = BusinessName+Rand.ToString();

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$BusinessName' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().EnsureVisible();
            Keyboard.Press(BusinessName);
        }
    }
  }