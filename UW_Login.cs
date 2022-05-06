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
    ///The UW_Login recording.
    /// </summary>
    [TestModule("e0f1e3cc-d4eb-4786-b6d3-e35e856420ee", ModuleType.Recording, 1)]
    public partial class UW_Login : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static UW_Login instance = new UW_Login();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UW_Login()
        {
            UW_ID = "PMAMSeptUser";
            UW_Pwd = "Pm#Vtsp";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UW_Login Instance
        {
            get { return instance; }
        }

#region Variables

        string _UW_ID;

        /// <summary>
        /// Gets or sets the value of variable UW_ID.
        /// </summary>
        [TestVariable("0b1cbc3a-4854-41e1-b5b4-b7662b92e807")]
        public string UW_ID
        {
            get { return _UW_ID; }
            set { _UW_ID = value; }
        }

        string _UW_Pwd;

        /// <summary>
        /// Gets or sets the value of variable UW_Pwd.
        /// </summary>
        [TestVariable("cdd64027-46bb-4856-af6b-3ba06aaa2e84")]
        public string UW_Pwd
        {
            get { return _UW_Pwd; }
            set { _UW_Pwd = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ApplicationUnderTest.TxtBranchId' at Center.", repo.ApplicationUnderTest.TxtBranchIdInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.TxtBranchId.DoubleClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtBranchId'.", repo.ApplicationUnderTest.TxtBranchIdInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.TxtBranchId.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$UW_ID' on item 'ApplicationUnderTest.TxtBranchId'.", repo.ApplicationUnderTest.TxtBranchIdInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.TxtBranchId.Element.SetAttributeValue("Value", UW_ID);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LogoPad20TextCenter' at Center.", repo.ApplicationUnderTest.LogoPad20TextCenterInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.LogoPad20TextCenter.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ApplicationUnderTest.TxtPassword' at Center.", repo.ApplicationUnderTest.TxtPasswordInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.TxtPassword.DoubleClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtPassword'.", repo.ApplicationUnderTest.TxtPasswordInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.TxtPassword.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$UW_Pwd' on item 'ApplicationUnderTest.TxtPassword'.", repo.ApplicationUnderTest.TxtPasswordInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.TxtPassword.Element.SetAttributeValue("Value", UW_Pwd);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LogoPad20TextCenter' at Center.", repo.ApplicationUnderTest.LogoPad20TextCenterInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.LogoPad20TextCenter.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.UWSign'.", repo.ApplicationUnderTest.UWSignInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.UWSign.PerformClick();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.UWSign' at Center.", repo.ApplicationUnderTest.UWSignInfo, new RecordItemIndex(9));
            //repo.ApplicationUnderTest.UWSign.Click();
            //Delay.Milliseconds(0);
            
            //Mouse_Click_Close(repo.UpdatePassword.CloseInfo);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to exist. Associated repository item: 'ApplicationUnderTest.Txtsearch'", repo.ApplicationUnderTest.TxtsearchInfo, new ActionTimeout(45000), new RecordItemIndex(11));
            repo.ApplicationUnderTest.TxtsearchInfo.WaitForExists(45000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(12));
            Delay.Duration(300, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
