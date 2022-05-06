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
    ///The UW_QuoteRecordScreen recording.
    /// </summary>
    [TestModule("46e5ab40-9316-458d-86d2-e599327509ae", ModuleType.Recording, 1)]
    public partial class UW_QuoteRecordScreen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static UW_QuoteRecordScreen instance = new UW_QuoteRecordScreen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UW_QuoteRecordScreen()
        {
            UW_InsuredName = "AUTM FCGA - 857590516";
            ProductLob = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UW_QuoteRecordScreen Instance
        {
            get { return instance; }
        }

#region Variables

        string _UW_InsuredName;

        /// <summary>
        /// Gets or sets the value of variable UW_InsuredName.
        /// </summary>
        [TestVariable("dfb35b8d-8fb8-40ad-8821-67555a2a5bed")]
        public string UW_InsuredName
        {
            get { return _UW_InsuredName; }
            set { _UW_InsuredName = value; }
        }

        string _ProductLob;

        /// <summary>
        /// Gets or sets the value of variable ProductLob.
        /// </summary>
        [TestVariable("627d4f41-f82c-461f-88e6-86596407a240")]
        public string ProductLob
        {
            get { return _ProductLob; }
            set { _ProductLob = value; }
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.UW_Record_Screen.UWStatus_Accepted' at Center.", repo.ApplicationUnderTest.UW_Record_Screen.UWStatus_AcceptedInfo, new RecordItemIndex(0));
            //repo.ApplicationUnderTest.UW_Record_Screen.UWStatus_Accepted.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.UW_Record_Screen.UWStatus_Submitted' at Center.", repo.ApplicationUnderTest.UW_Record_Screen.UWStatus_SubmittedInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.UW_Record_Screen.UWStatus_Submitted.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Txtsearch' at Center.", repo.ApplicationUnderTest.TxtsearchInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Txtsearch.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$UW_InsuredName' with focus on 'ApplicationUnderTest.Txtsearch'.", repo.ApplicationUnderTest.TxtsearchInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Txtsearch.PressKeys(UW_InsuredName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.Txtsearch'.", repo.ApplicationUnderTest.TxtsearchInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Txtsearch.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(5));
            Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AutmSelect' at CenterLeft.", repo.ApplicationUnderTest.AutmSelectInfo, new RecordItemIndex(6));
            //repo.ApplicationUnderTest.AutmSelect.Click(Location.CenterLeft);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.AutmSelect'.", repo.ApplicationUnderTest.AutmSelectInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.AutmSelect.PerformClick();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 15s.", new RecordItemIndex(8));
            //Delay.Duration(15000, false);
            
            MergedUserCodeMethod(repo.ApplicationUnderTest.GLEditQuoteInfo, repo.ApplicationUnderTest.WCEditQuoteInfo, ProductLob);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(10));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}