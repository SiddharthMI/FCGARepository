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
    ///The GL_UW_Claims recording.
    /// </summary>
    [TestModule("d8c4a633-96c7-491c-a59a-e59b53c0b72d", ModuleType.Recording, 1)]
    public partial class GL_UW_Claims : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static GL_UW_Claims instance = new GL_UW_Claims();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GL_UW_Claims()
        {
            GLUWClaimNo = "0";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GL_UW_Claims Instance
        {
            get { return instance; }
        }

#region Variables

        string _GLUWClaimNo;

        /// <summary>
        /// Gets or sets the value of variable GLUWClaimNo.
        /// </summary>
        [TestVariable("52f13c4a-dcfc-4e9a-877e-6142e2162e98")]
        public string GLUWClaimNo
        {
            get { return _GLUWClaimNo; }
            set { _GLUWClaimNo = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtClaims' at Center.", repo.ApplicationUnderTest.TxtClaimsInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.TxtClaims.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtClaims'.", repo.ApplicationUnderTest.TxtClaimsInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.TxtClaims.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLUWClaimNo' with focus on 'ApplicationUnderTest.TxtClaims'.", repo.ApplicationUnderTest.TxtClaimsInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.TxtClaims.PressKeys(GLUWClaimNo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}