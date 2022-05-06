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

namespace Sid_FCGAProject.WC_Product
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AgentInsuredSubcontractor recording.
    /// </summary>
    [TestModule("c3b7b078-39ad-4e1f-9296-aed57fa3a636", ModuleType.Recording, 1)]
    public partial class AgentInsuredSubcontractor : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static AgentInsuredSubcontractor instance = new AgentInsuredSubcontractor();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AgentInsuredSubcontractor()
        {
            InsSubcontractorAmt = "4567";
            SubcontractTypeWork = "YES";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AgentInsuredSubcontractor Instance
        {
            get { return instance; }
        }

#region Variables

        string _InsSubcontractorAmt;

        /// <summary>
        /// Gets or sets the value of variable InsSubcontractorAmt.
        /// </summary>
        [TestVariable("6fb73de6-8274-4b58-bd5e-17406ed01213")]
        public string InsSubcontractorAmt
        {
            get { return _InsSubcontractorAmt; }
            set { _InsSubcontractorAmt = value; }
        }

        string _SubcontractTypeWork;

        /// <summary>
        /// Gets or sets the value of variable SubcontractTypeWork.
        /// </summary>
        [TestVariable("4f20ed40-5018-4908-b24e-9c49261e8c43")]
        public string SubcontractTypeWork
        {
            get { return _SubcontractTypeWork; }
            set { _SubcontractTypeWork = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtInsuredSubcontract' at Center.", repo.ApplicationUnderTest.TxtInsuredSubcontractInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.TxtInsuredSubcontract.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$InsSubcontractorAmt' with focus on 'ApplicationUnderTest.TxtInsuredSubcontract'.", repo.ApplicationUnderTest.TxtInsuredSubcontractInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.TxtInsuredSubcontract.PressKeys(InsSubcontractorAmt);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtUnInsuredSubcontract' at Center.", repo.ApplicationUnderTest.TxtUnInsuredSubcontractInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.TxtUnInsuredSubcontract.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(3));
            //Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtInsuredSubcontract' at Center.", repo.ApplicationUnderTest.TxtInsuredSubcontractInfo, new RecordItemIndex(4));
            //repo.ApplicationUnderTest.TxtInsuredSubcontract.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$InsSubcontractorAmt' on item 'ApplicationUnderTest.TxtInsuredSubcontract'.", repo.ApplicationUnderTest.TxtInsuredSubcontractInfo, new RecordItemIndex(5));
            //repo.ApplicationUnderTest.TxtInsuredSubcontract.Element.SetAttributeValue("Value", InsSubcontractorAmt);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxttypeofworkSubcontract' at Center.", repo.ApplicationUnderTest.TxttypeofworkSubcontractInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.TxttypeofworkSubcontract.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SubcontractTypeWork' with focus on 'ApplicationUnderTest.TxttypeofworkSubcontract'.", repo.ApplicationUnderTest.TxttypeofworkSubcontractInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.TxttypeofworkSubcontract.PressKeys(SubcontractTypeWork);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.LabelTagYes2' at Center.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.LabelTagYes2Info, new RecordItemIndex(8));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.LabelTagYes2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.LabelTagYes' at Center.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.LabelTagYesInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.LabelTagYes.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}