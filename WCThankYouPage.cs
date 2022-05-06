﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Sid_FCGAProject
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The WCThankYouPage recording.
    /// </summary>
    [TestModule("d544e935-e067-49fd-846f-84bc39e6122b", ModuleType.Recording, 1)]
    public partial class WCThankYouPage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static WCThankYouPage instance = new WCThankYouPage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WCThankYouPage()
        {
            WCInsuredName = "0";
            WCPolicyNumber = "0";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static WCThankYouPage Instance
        {
            get { return instance; }
        }

#region Variables

        string _WCInsuredName;

        /// <summary>
        /// Gets or sets the value of variable WCInsuredName.
        /// </summary>
        [TestVariable("d0ed1715-940a-4964-b8a5-2acf46525c72")]
        public string WCInsuredName
        {
            get { return _WCInsuredName; }
            set { _WCInsuredName = value; }
        }

        string _WCPolicyNumber;

        /// <summary>
        /// Gets or sets the value of variable WCPolicyNumber.
        /// </summary>
        [TestVariable("eee63a25-c400-47a6-b1d0-04d61260f35f")]
        public string WCPolicyNumber
        {
            get { return _WCPolicyNumber; }
            set { _WCPolicyNumber = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(0));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LblBusinessName' at Center.", repo.ApplicationUnderTest.LblBusinessNameInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.LblBusinessName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.LblBusinessName' and assigning its value to variable 'WCInsuredName'.", repo.ApplicationUnderTest.LblBusinessNameInfo, new RecordItemIndex(2));
            WCInsuredName = repo.ApplicationUnderTest.LblBusinessName.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", WCInsuredName, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LblPolicyNumber' at 122;7.", repo.ApplicationUnderTest.LblPolicyNumberInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.LblPolicyNumber.Click("122;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.LblPolicyNumber' and assigning its value to variable 'WCPolicyNumber'.", repo.ApplicationUnderTest.LblPolicyNumberInfo, new RecordItemIndex(5));
            WCPolicyNumber = repo.ApplicationUnderTest.LblPolicyNumber.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", WCPolicyNumber, new RecordItemIndex(6));
            
            Ranorex.AutomationHelpers.UserCodeCollections.WebLibrary.ReportFullPageScreenshot(null);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LnkDownloadBinder' at 52;20.", repo.ApplicationUnderTest.LnkDownloadBinderInfo, new RecordItemIndex(8));
            //repo.ApplicationUnderTest.LnkDownloadBinder.Click("52;20");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 8s.", new RecordItemIndex(9));
            //Delay.Duration(8000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Quote.Close' at Center.", repo.Quote.CloseInfo, new RecordItemIndex(10));
            //repo.Quote.Close.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(11));
            //Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BacktoMainScreen' at Center.", repo.BacktoMainScreenInfo, new RecordItemIndex(12));
            repo.BacktoMainScreen.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 15s.", new RecordItemIndex(13));
            Delay.Duration(15000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
