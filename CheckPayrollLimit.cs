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
    ///The CheckPayrollLimit recording.
    /// </summary>
    [TestModule("3b4cefcd-17aa-4a4f-b4d8-eeff94d172b7", ModuleType.Recording, 1)]
    public partial class CheckPayrollLimit : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static CheckPayrollLimit instance = new CheckPayrollLimit();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckPayrollLimit()
        {
            Modified_AOGrossAmt = "1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CheckPayrollLimit Instance
        {
            get { return instance; }
        }

#region Variables

        string _Modified_AOGrossAmt;

        /// <summary>
        /// Gets or sets the value of variable Modified_AOGrossAmt.
        /// </summary>
        [TestVariable("f63b5ec7-c14f-4725-973c-57aa0a0b27bc")]
        public string Modified_AOGrossAmt
        {
            get { return _Modified_AOGrossAmt; }
            set { _Modified_AOGrossAmt = value; }
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.BtnNext'.", repo.ApplicationUnderTest.BtnNextInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.BtnNext.PerformClick();
            Delay.Milliseconds(0);
            
            Mouse_Click_CLOSE2(repo.ApplicationUnderTest.CLOSE2Info, repo.ApplicationUnderTest.TxtAOGross1Info);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}