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

namespace Sid_FCGAProject.GL_Product
{
    public partial class CG2005FormDetails
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void MergedUserCodeMethod(RepoItemInfo inputtagInfo, RepoItemInfo inputtagInfo1, RepoItemInfo inputtagInfo2, RepoItemInfo inputtagInfo3, RepoItemInfo inputtagInfo4, string CG2005No)
        {
           
        	int CG2005N = Convert.ToInt32(CG2005No);
            string[] CG2005_CompanyNameList = CG2005_CompanyName.Split(',');
        	string[] CG2005_Address1List = CG2005_Address1.Split(',');
        	string[] CG2005_Address2List = CG2005_Address2.Split(',');
        	string[] CG2005_CityList = CG2005_City.Split(',');
        	string[] CG2005_ZipCodeList = CG2005_ZipCode.Split(',');
        	
        	
        	for (int i=1;i<= CG2005N;i++)
        	{
        		
        	WebElement webElementItem = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']//div[#'divAdditionaldynamic']//input[@name='txtCompanyNameCG2005_"+i+"']");
        	webElementItem.Click();
        	webElementItem.PressKeys(CG2005_CompanyNameList[0]);
        	
        	WebElement webElementItem1 = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']//div[#'divAdditionaldynamic']//input[@name='txtAddress1CG2005_"+i+"']");
        	webElementItem1.Click();
        	webElementItem1.PressKeys(CG2005_Address1List[0]);	
        	
         	WebElement webElementItem2 = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']//div[#'divAdditionaldynamic']//input[@name='txtAddress2CG2005_"+i+"']");
        	webElementItem2.Click();
        	webElementItem2.PressKeys(CG2005_Address2List[0]);
        	
        	WebElement webElementItem3 = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']//div[#'divAdditionaldynamic']//input[@name='txtCityCG2005_"+i+"']");
        	webElementItem3.Click();
        	webElementItem3.PressKeys(CG2005_CityList[0]);	 

            WebElement webElementItem4 = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']//div[#'divAdditionaldynamic']//input[@name='txtZipCodeCG2005_"+i+"']");
        	webElementItem4.Click();
        	webElementItem4.PressKeys(CG2005_ZipCodeList[0]);        	
        	




        	/*Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo' at Center.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2005_CompanyName' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys(CG2005_CompanyName);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo1' at Center.", inputtagInfo1);
            inputtagInfo1.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2005_Address1' with focus on 'inputtagInfo1'.", inputtagInfo1);
            inputtagInfo1.FindAdapter<InputTag>().PressKeys(CG2005_Address1);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo2' at Center.", inputtagInfo2);
            inputtagInfo2.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2005_Address2' with focus on 'inputtagInfo2'.", inputtagInfo2);
            inputtagInfo2.FindAdapter<InputTag>().PressKeys(CG2005_Address2);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo3' at Center.", inputtagInfo3);
            inputtagInfo3.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2005_City' with focus on 'inputtagInfo3'.", inputtagInfo3);
            inputtagInfo3.FindAdapter<InputTag>().EnsureVisible();
            Keyboard.Press(CG2005_City);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo4' at Center.", inputtagInfo4);
            inputtagInfo4.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2005_ZipCode' with focus on 'inputtagInfo4'.", inputtagInfo4);
            inputtagInfo4.FindAdapter<InputTag>().PressKeys(CG2005_ZipCode);*/
        }
      }
    }
}