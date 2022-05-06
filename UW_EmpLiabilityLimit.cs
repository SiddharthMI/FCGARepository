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
    ///The UW_EmpLiabilityLimit recording.
    /// </summary>
    [TestModule("e7e9acc8-4b89-403b-b8ce-697874803c06", ModuleType.Recording, 1)]
    public partial class UW_EmpLiabilityLimit : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static UW_EmpLiabilityLimit instance = new UW_EmpLiabilityLimit();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UW_EmpLiabilityLimit()
        {
            EmpliabilityValue = "$100,000/$500,000/$100,000";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UW_EmpLiabilityLimit Instance
        {
            get { return instance; }
        }

#region Variables

        string _EmpliabilityValue;

        /// <summary>
        /// Gets or sets the value of variable EmpliabilityValue.
        /// </summary>
        [TestVariable("7a2e6f5c-fa11-4b5f-b443-8c54e630f2a6")]
        public string EmpliabilityValue
        {
            get { return _EmpliabilityValue; }
            set { _EmpliabilityValue = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.Empliabilitylimit' at Center.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.EmpliabilitylimitInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi.Empliabilitylimit.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Search' at Center.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Search.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EmpliabilityValue' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Search.PressKeys(EmpliabilityValue);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Search.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}