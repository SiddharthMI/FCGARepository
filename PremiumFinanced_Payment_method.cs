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
    ///The PremiumFinanced_Payment_method recording.
    /// </summary>
    [TestModule("9bdfc0c0-407e-47f1-9325-10b0610f45bc", ModuleType.Recording, 1)]
    public partial class PremiumFinanced_Payment_method : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static PremiumFinanced_Payment_method instance = new PremiumFinanced_Payment_method();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PremiumFinanced_Payment_method()
        {
            PaymentMethod = "All Island Credit Corp.";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PremiumFinanced_Payment_method Instance
        {
            get { return instance; }
        }

#region Variables

        string _PaymentMethod;

        /// <summary>
        /// Gets or sets the value of variable PaymentMethod.
        /// </summary>
        [TestVariable("fbff8df5-f354-43e5-9e81-8ea8531bb061")]
        public string PaymentMethod
        {
            get { return _PaymentMethod; }
            set { _PaymentMethod = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SelectDeposit' at Center.", repo.ApplicationUnderTest.SelectDepositInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.SelectDeposit.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Search' at Center.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Search.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PaymentMethod' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Search.PressKeys(PaymentMethod);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Search.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Ranorex.AutomationHelpers.UserCodeCollections.WebLibrary.ReportFullPageScreenshot(repo.ApplicationUnderTest.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PFPolicySubmit' at Center.", repo.ApplicationUnderTest.PFPolicySubmitInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.PFPolicySubmit.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 20s.", new RecordItemIndex(6));
            Delay.Duration(20000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SelectDeposit' at Center.", repo.ApplicationUnderTest.SelectDepositInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.SelectDeposit.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Search' at Center.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.Search.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PaymentMethod' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.Search.PressKeys(PaymentMethod);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.Search.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Ranorex.AutomationHelpers.UserCodeCollections.WebLibrary.ReportFullPageScreenshot(repo.ApplicationUnderTest.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PFPolicySubmit' at Center.", repo.ApplicationUnderTest.PFPolicySubmitInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.PFPolicySubmit.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'ApplicationUnderTest.LblBusinessName'", repo.ApplicationUnderTest.LblBusinessNameInfo, new ActionTimeout(60000), new RecordItemIndex(13));
            repo.ApplicationUnderTest.LblBusinessNameInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 15s.", new RecordItemIndex(14));
            Delay.Duration(15000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
