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
    ///The EnterRisklevel recording.
    /// </summary>
    [TestModule("516c400c-df46-4cc9-881c-e08fa9060812", ModuleType.Recording, 1)]
    public partial class EnterRisklevel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static EnterRisklevel instance = new EnterRisklevel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterRisklevel()
        {
            GLAgState = "FLorida";
            GLAgCounty = "Bradford";
            GLAgBusinessName = "AUTM FCGA-3645653";
            GLAgDescription = "OK";
            GLAgBusinessYear = "2";
            GLAgLoc_Address1 = "FLorida";
            GLAgCity = "Moody";
            GLAgZipCode = "35004";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterRisklevel Instance
        {
            get { return instance; }
        }

#region Variables

        string _GLAgState;

        /// <summary>
        /// Gets or sets the value of variable GLAgState.
        /// </summary>
        [TestVariable("8d02b630-bcda-4f0f-b55f-d591fc8b4a2d")]
        public string GLAgState
        {
            get { return _GLAgState; }
            set { _GLAgState = value; }
        }

        string _GLAgCounty;

        /// <summary>
        /// Gets or sets the value of variable GLAgCounty.
        /// </summary>
        [TestVariable("8c155573-0aa8-4eb3-85f4-2dab05cf22ba")]
        public string GLAgCounty
        {
            get { return _GLAgCounty; }
            set { _GLAgCounty = value; }
        }

        string _GLAgBusinessName;

        /// <summary>
        /// Gets or sets the value of variable GLAgBusinessName.
        /// </summary>
        [TestVariable("90fda39b-bab5-4180-9846-49a1440b33e3")]
        public string GLAgBusinessName
        {
            get { return _GLAgBusinessName; }
            set { _GLAgBusinessName = value; }
        }

        string _GLAgDescription;

        /// <summary>
        /// Gets or sets the value of variable GLAgDescription.
        /// </summary>
        [TestVariable("5c3ef7f7-804f-4051-a30b-00ec591e84cd")]
        public string GLAgDescription
        {
            get { return _GLAgDescription; }
            set { _GLAgDescription = value; }
        }

        string _GLAgBusinessYear;

        /// <summary>
        /// Gets or sets the value of variable GLAgBusinessYear.
        /// </summary>
        [TestVariable("f3cca388-fcd3-444a-9174-16a9b0631c00")]
        public string GLAgBusinessYear
        {
            get { return _GLAgBusinessYear; }
            set { _GLAgBusinessYear = value; }
        }

        string _GLAgLoc_Address1;

        /// <summary>
        /// Gets or sets the value of variable GLAgLoc_Address1.
        /// </summary>
        [TestVariable("a257caef-8c4d-4a43-a2d2-79cd5bf14793")]
        public string GLAgLoc_Address1
        {
            get { return _GLAgLoc_Address1; }
            set { _GLAgLoc_Address1 = value; }
        }

        string _GLAgCity;

        /// <summary>
        /// Gets or sets the value of variable GLAgCity.
        /// </summary>
        [TestVariable("eb07a7e5-ed0b-4888-9d23-722005b3f606")]
        public string GLAgCity
        {
            get { return _GLAgCity; }
            set { _GLAgCity = value; }
        }

        string _GLAgZipCode;

        /// <summary>
        /// Gets or sets the value of variable GLAgZipCode.
        /// </summary>
        [TestVariable("c946bd2b-e62d-4ae0-aea3-a17bd4202729")]
        public string GLAgZipCode
        {
            get { return _GLAgZipCode; }
            set { _GLAgZipCode = value; }
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.TxtNameOfInsured'.", repo.ApplicationUnderTest.TxtNameOfInsuredInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.TxtNameOfInsured.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgBusinessName' with focus on 'ApplicationUnderTest.TxtNameOfInsured'.", repo.ApplicationUnderTest.TxtNameOfInsuredInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.TxtNameOfInsured.PressKeys(GLAgBusinessName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi1.TxtLocationAddress1'.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi1.TxtLocationAddress1Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi1.TxtLocationAddress1.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgLoc_Address1' with focus on 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi1.TxtLocationAddress1'.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi1.TxtLocationAddress1Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi1.TxtLocationAddress1.PressKeys(GLAgLoc_Address1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.TxtLocationCity'.", repo.ApplicationUnderTest.TxtLocationCityInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.TxtLocationCity.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtLocationCity'.", repo.ApplicationUnderTest.TxtLocationCityInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.TxtLocationCity.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgCity' with focus on 'ApplicationUnderTest.TxtLocationCity'.", repo.ApplicationUnderTest.TxtLocationCityInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.TxtLocationCity.PressKeys(GLAgCity);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(7));
            //Delay.Duration(3000, false);
            
            try {
                Mouse_Click_UseAsIs2(repo.ApplicationUnderTest.UseAsIs2Info);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SelectGLState' at Center.", repo.ApplicationUnderTest.SelectGLStateInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.SelectGLState.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Search' at Center.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.Search.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgState' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.Search.PressKeys(GLAgState);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.Search.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtLocationZipCode' at Center.", repo.ApplicationUnderTest.TxtLocationZipCodeInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.TxtLocationZipCode.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item 'ApplicationUnderTest.TxtLocationZipCode'.", repo.ApplicationUnderTest.TxtLocationZipCodeInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.TxtLocationZipCode.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgZipCode' with focus on 'ApplicationUnderTest.TxtLocationZipCode'.", repo.ApplicationUnderTest.TxtLocationZipCodeInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.TxtLocationZipCode.PressKeys(GLAgZipCode);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SelectGLCounty' at Center.", repo.ApplicationUnderTest.SelectGLCountyInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.SelectGLCounty.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgCounty' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.Search.EnsureVisible();
            Keyboard.Press(GLAgCounty);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.Search.EnsureVisible();
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtDescriptionOfBusiness' at Center.", repo.ApplicationUnderTest.TxtDescriptionOfBusinessInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.TxtDescriptionOfBusiness.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgDescription' with focus on 'ApplicationUnderTest.TxtDescriptionOfBusiness'.", repo.ApplicationUnderTest.TxtDescriptionOfBusinessInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.TxtDescriptionOfBusiness.PressKeys(GLAgDescription);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtYearsInBusiness' at Center.", repo.ApplicationUnderTest.TxtYearsInBusinessInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.TxtYearsInBusiness.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GLAgBusinessYear' with focus on 'ApplicationUnderTest.TxtYearsInBusiness'.", repo.ApplicationUnderTest.TxtYearsInBusinessInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.TxtYearsInBusiness.PressKeys(GLAgBusinessYear);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(23));
            Delay.Duration(1000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}