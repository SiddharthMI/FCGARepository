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
    ///The AgentClassDescandState recording.
    /// </summary>
    [TestModule("49033911-4dbd-41da-adf7-bdac7d137951", ModuleType.Recording, 1)]
    public partial class AgentClassDescandState : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static AgentClassDescandState instance = new AgentClassDescandState();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AgentClassDescandState()
        {
            StateName = "Florida";
            ClassDesc = "0005";
            ClassCode = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AgentClassDescandState Instance
        {
            get { return instance; }
        }

#region Variables

        string _StateName;

        /// <summary>
        /// Gets or sets the value of variable StateName.
        /// </summary>
        [TestVariable("3ecadbee-1c61-4f89-9179-5f12f5131939")]
        public string StateName
        {
            get { return _StateName; }
            set { _StateName = value; }
        }

        string _ClassDesc;

        /// <summary>
        /// Gets or sets the value of variable ClassDesc.
        /// </summary>
        [TestVariable("73e2c470-9f0e-4347-8bc3-a2bbbcf6e897")]
        public string ClassDesc
        {
            get { return _ClassDesc; }
            set { _ClassDesc = value; }
        }

        string _ClassCode;

        /// <summary>
        /// Gets or sets the value of variable ClassCode.
        /// </summary>
        [TestVariable("6bb49d2a-7bc3-4531-bd93-e9695f40da0e")]
        public string ClassCode
        {
            get { return _ClassCode; }
            set { _ClassCode = value; }
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

            MergedUserCodeMethod(repo.ApplicationUnderTest.SpanTagSelectInfo, repo.ApplicationUnderTest.SearchInfo, repo.ApplicationUnderTest.TxtClassCodes1Info, repo.ApplicationUnderTest.Txt_Select_Class_codeInfo, repo.ApplicationUnderTest.BtnAddEligibilityInfo, repo.ApplicationUnderTest.SpanTagSelect1Info, repo.ApplicationUnderTest.TxtClassCodesInfo, repo.ApplicationUnderTest.Txt_Select_Class_code1Info);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.BtnContinue1'.", repo.ApplicationUnderTest.BtnContinue1Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.BtnContinue1.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}