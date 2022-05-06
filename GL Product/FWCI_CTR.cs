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

namespace Sid_FCGAProject.GL_Product
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FWCI_CTR recording.
    /// </summary>
    [TestModule("377eee93-1358-41de-a8d2-4b96bb876fd4", ModuleType.Recording, 1)]
    public partial class FWCI_CTR : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static FWCI_CTR instance = new FWCI_CTR();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FWCI_CTR()
        {
            FWCI_CTR1 = "1.67";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FWCI_CTR Instance
        {
            get { return instance; }
        }

#region Variables

        string _FWCI_CTR1;

        /// <summary>
        /// Gets or sets the value of variable FWCI_CTR1.
        /// </summary>
        [TestVariable("2d0d5487-48cf-4d3b-b683-a6c7c5dcae8a")]
        public string FWCI_CTR1
        {
            get { return _FWCI_CTR1; }
            set { _FWCI_CTR1 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ConsentToRateCTR' at Center.", repo.ApplicationUnderTest.ConsentToRateCTRInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.ConsentToRateCTR.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$FWCI_CTR1' on item 'ApplicationUnderTest.Txtsearch2'.", repo.ApplicationUnderTest.Txtsearch2Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Txtsearch2.Element.SetAttributeValue("Value", FWCI_CTR1);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Txtsearch2' at Center.", repo.ApplicationUnderTest.Txtsearch2Info, new RecordItemIndex(2));
            //repo.ApplicationUnderTest.Txtsearch2.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FWCI_CTR1' with focus on 'ApplicationUnderTest.Txtsearch2'.", repo.ApplicationUnderTest.Txtsearch2Info, new RecordItemIndex(3));
            //repo.ApplicationUnderTest.Txtsearch2.PressKeys(FWCI_CTR1);
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}