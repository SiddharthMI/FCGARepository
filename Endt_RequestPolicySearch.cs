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
    ///The Endt_RequestPolicySearch recording.
    /// </summary>
    [TestModule("c97fd1a3-22f9-4c59-8ea2-2da9e0ab8274", ModuleType.Recording, 1)]
    public partial class Endt_RequestPolicySearch : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static Endt_RequestPolicySearch instance = new Endt_RequestPolicySearch();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Endt_RequestPolicySearch()
        {
            UWEndtPolicyNo = "23456789";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Endt_RequestPolicySearch Instance
        {
            get { return instance; }
        }

#region Variables

        string _UWEndtPolicyNo;

        /// <summary>
        /// Gets or sets the value of variable UWEndtPolicyNo.
        /// </summary>
        [TestVariable("f985d06b-7e55-476b-ab60-a18ddbb808f1")]
        public string UWEndtPolicyNo
        {
            get { return _UWEndtPolicyNo; }
            set { _UWEndtPolicyNo = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtEndtPolicyNo' at Center.", repo.ApplicationUnderTest.TxtEndtPolicyNoInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.TxtEndtPolicyNo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$UWEndtPolicyNo' with focus on 'ApplicationUnderTest.TxtEndtPolicyNo'.", repo.ApplicationUnderTest.TxtEndtPolicyNoInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.TxtEndtPolicyNo.PressKeys(UWEndtPolicyNo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '0' on item 'ApplicationUnderTest.DdlStatus'.", repo.ApplicationUnderTest.DdlStatusInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.DdlStatus.Element.SetAttributeValue("TagValue", "0");
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnReqSearch' at Center.", repo.ApplicationUnderTest.BtnReqSearchInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.BtnReqSearch.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(4));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SelectEndtRecord' at Center.", repo.ApplicationUnderTest.SelectEndtRecordInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.SelectEndtRecord.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to exist. Associated repository item: 'ApplicationUnderTest.BtnCancel'", repo.ApplicationUnderTest.BtnCancelInfo, new ActionTimeout(45000), new RecordItemIndex(6));
            repo.ApplicationUnderTest.BtnCancelInfo.WaitForExists(45000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(7));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}