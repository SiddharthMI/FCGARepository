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
    public partial class CG2012FormDetails
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void CG2012FormDetailsUserCodeMethod(RepoItemInfo inputtagInfo, RepoItemInfo inputtagInfo1, RepoItemInfo inputtagInfo2, RepoItemInfo inputtagInfo3, RepoItemInfo inputtagInfo4, RepoItemInfo inputtagInfo5, RepoItemInfo inputtagInfo6, RepoItemInfo inputtagInfo7, RepoItemInfo inputtagInfo8, RepoItemInfo inputtagInfo9, string CG2012No, RepoItemInfo inputtagInfo10, RepoItemInfo inputtagInfo11, RepoItemInfo inputtagInfo12, RepoItemInfo inputtagInfo13, RepoItemInfo inputtagInfo14)
        {
        	
        	int CG2012N = Convert.ToInt32(CG2012No);
        	string[] CG2012_CompanyNameList = CG2012_CompanyName.Split(',');
        	string[] CG2012_Address1List = CG2012_Address1.Split(',');
        	string[] CG2012_Address2List = CG2012_Address2.Split(',');
        	string[] CG2012_CityList = CG2012_City.Split(',');
        	string[] CG2012_ZipCodeList = CG2012_ZipCode.Split(',');
        	
        	
        	for (int i=1;i<= CG2012N;i++)
        	{
        		
        	WebElement webElementItem = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']//div[#'divAdditionaldynamic']//input[@name='txtCompanyNameCG2012_"+i+"']");
        	webElementItem.Click();
        	webElementItem.PressKeys(CG2012_CompanyNameList[0]);
        	
        	WebElement webElementItem1 = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']//div[#'divAdditionaldynamic']//input[@name='txtAddress1CG2012_"+i+"']");
        	webElementItem1.Click();
        	webElementItem1.PressKeys(CG2012_Address1List[0]);	
        	
         	WebElement webElementItem2 = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']//div[#'divAdditionaldynamic']//input[@name='txtAddress2CG2012_"+i+"']");
        	webElementItem2.Click();
        	webElementItem2.PressKeys(CG2012_Address2List[0]);
        	
        	WebElement webElementItem3 = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']//div[#'divAdditionaldynamic']//input[@name='txtCityCG2012_"+i+"']");
        	webElementItem3.Click();
        	webElementItem3.PressKeys(CG2012_CityList[0]);	 

            WebElement webElementItem4 = Host.Local.FindSingle<WebElement>("/dom[@domain<'fwcins.com']//div[#'divAdditionaldynamic']//input[@name='txtZipCodeCG2012_"+i+"']");
        	webElementItem4.Click();
        	webElementItem4.PressKeys(CG2012_ZipCodeList[0]);        	
        	
        	/*if(CG2012N == 1)
        	{
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo' at Center.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2012_CompanyName' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys(CG2012_CompanyName);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo1' at Center.", inputtagInfo1);
            inputtagInfo1.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2012_Address1' with focus on 'inputtagInfo1'.", inputtagInfo1);
            inputtagInfo1.FindAdapter<InputTag>().PressKeys(CG2012_Address1);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo2' at Center.", inputtagInfo2);
            inputtagInfo2.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2012_Address2' with focus on 'inputtagInfo2'.", inputtagInfo2);
            inputtagInfo2.FindAdapter<InputTag>().PressKeys(CG2012_Address2);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo3' at Center.", inputtagInfo3);
            inputtagInfo3.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2012_City' with focus on 'inputtagInfo3'.", inputtagInfo3);
            inputtagInfo3.FindAdapter<InputTag>().PressKeys(CG2012_City);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo4' at Center.", inputtagInfo4);
            inputtagInfo4.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2012_ZipCode' with focus on 'inputtagInfo4'.", inputtagInfo4);
            inputtagInfo4.FindAdapter<InputTag>().PressKeys(CG2012_ZipCode);
            Report.Log(ReportLevel.Info, "Section", "Header text");
            
             }
        	
        	if(CG2012N > 1 && CG2012N < 3)
            {
            	
            	String[] CG2012_CN = CG2012_CompanyName.Split(',');
            	String[] CG2012_Add1 = CG2012_Address1.Split(',');
            	String[] CG2012_Add2 = CG2012_Address2.Split(',');
            	String[] CG2012_CI = CG2012_City.Split(',');
            	String[] CG2012_Zip = CG2012_ZipCode.Split(',');
        		
            for (int i=0;i<CG2012N;i++)
            {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo5' at Center.", inputtagInfo5);
            inputtagInfo5.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2012_CompanyName' with focus on 'inputtagInfo5'.", inputtagInfo5);
            inputtagInfo5.FindAdapter<InputTag>().PressKeys(CG2012_CN[0]);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo6' at Center.", inputtagInfo6);
            inputtagInfo6.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2012_Address1' with focus on 'inputtagInfo6'.", inputtagInfo6);
            inputtagInfo6.FindAdapter<InputTag>().PressKeys(CG2012_Add1[0]);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo7' at Center.", inputtagInfo7);
            inputtagInfo7.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2012_Address2' with focus on 'inputtagInfo7'.", inputtagInfo7);
            inputtagInfo7.FindAdapter<InputTag>().PressKeys(CG2012_Add2[0]);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo8' at Center.", inputtagInfo8);
            inputtagInfo8.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2012_City' with focus on 'inputtagInfo8'.", inputtagInfo8);
            inputtagInfo8.FindAdapter<InputTag>().PressKeys(CG2012_CI[0]);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo9' at Center.", inputtagInfo9);
            inputtagInfo9.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2012_ZipCode' with focus on 'inputtagInfo9'.", inputtagInfo9);
            inputtagInfo9.FindAdapter<InputTag>().PressKeys(CG2012_Zip[0]);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo10' at Center.", inputtagInfo10);
            inputtagInfo10.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2012_CompanyName' with focus on 'inputtagInfo10'.", inputtagInfo10);
            inputtagInfo10.FindAdapter<InputTag>().PressKeys(CG2012_CN[1]);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo11' at Center.", inputtagInfo11);
            inputtagInfo11.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2012_Address1' with focus on 'inputtagInfo11'.", inputtagInfo11);
            inputtagInfo11.FindAdapter<InputTag>().PressKeys(CG2012_Add1[1]);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo12' at Center.", inputtagInfo12);
            inputtagInfo12.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2012_Address2' with focus on 'inputtagInfo12'.", inputtagInfo12);
            inputtagInfo12.FindAdapter<InputTag>().PressKeys(CG2012_Add2[1]);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo13' at Center.", inputtagInfo13);
            inputtagInfo13.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2012_City' with focus on 'inputtagInfo13.", inputtagInfo13);
            inputtagInfo13.FindAdapter<InputTag>().PressKeys(CG2012_CI[1]);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo14' at Center.", inputtagInfo14);
            inputtagInfo14.FindAdapter<InputTag>().Click();
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CG2012_ZipCode' with focus on 'inputtagInfo14'.", inputtagInfo14);
            inputtagInfo14.FindAdapter<InputTag>().PressKeys(CG2012_Zip[1]);
            }*/
          }
        }
    }
}
