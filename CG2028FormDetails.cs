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
    ///The CG2028FormDetails recording.
    /// </summary>
    [TestModule("17e840b5-50b0-4a9f-a542-1a2567dab8f5", ModuleType.Recording, 1)]
    public partial class CG2028FormDetails : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static CG2028FormDetails instance = new CG2028FormDetails();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CG2028FormDetails()
        {
            CG2028_CompanyName = "XYZ";
            CG2028_Address1 = "Address1";
            CG2028_Address2 = "Address2";
            CG2028_City = "Tampa";
            CG2028_ZipCode = "33604";
            CG2028No = "1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CG2028FormDetails Instance
        {
            get { return instance; }
        }

#region Variables

        string _CG2028_CompanyName;

        /// <summary>
        /// Gets or sets the value of variable CG2028_CompanyName.
        /// </summary>
        [TestVariable("c1ba9575-d66a-45e9-93eb-6be3f70cab6a")]
        public string CG2028_CompanyName
        {
            get { return _CG2028_CompanyName; }
            set { _CG2028_CompanyName = value; }
        }

        string _CG2028_Address1;

        /// <summary>
        /// Gets or sets the value of variable CG2028_Address1.
        /// </summary>
        [TestVariable("8c161f67-102e-4ef3-8c48-63872c69fcdf")]
        public string CG2028_Address1
        {
            get { return _CG2028_Address1; }
            set { _CG2028_Address1 = value; }
        }

        string _CG2028_Address2;

        /// <summary>
        /// Gets or sets the value of variable CG2028_Address2.
        /// </summary>
        [TestVariable("f5e59bc2-2b6e-46e4-a7c9-647c57ec1639")]
        public string CG2028_Address2
        {
            get { return _CG2028_Address2; }
            set { _CG2028_Address2 = value; }
        }

        string _CG2028_City;

        /// <summary>
        /// Gets or sets the value of variable CG2028_City.
        /// </summary>
        [TestVariable("7c02087e-778f-4b82-b94e-77ca42c004bd")]
        public string CG2028_City
        {
            get { return _CG2028_City; }
            set { _CG2028_City = value; }
        }

        string _CG2028_ZipCode;

        /// <summary>
        /// Gets or sets the value of variable CG2028_ZipCode.
        /// </summary>
        [TestVariable("16129673-502b-4dfd-b7c5-2d6a1523eecb")]
        public string CG2028_ZipCode
        {
            get { return _CG2028_ZipCode; }
            set { _CG2028_ZipCode = value; }
        }

        string _CG2028No;

        /// <summary>
        /// Gets or sets the value of variable CG2028No.
        /// </summary>
        [TestVariable("eb98c798-0acd-4954-b99a-f2cf0fcdf166")]
        public string CG2028No
        {
            get { return _CG2028No; }
            set { _CG2028No = value; }
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

            CG2028FormsDetailsUserCodeMethod(null, null, null, null, null, null, null, null, null, null, CG2028No, null, null, null, null, null);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}