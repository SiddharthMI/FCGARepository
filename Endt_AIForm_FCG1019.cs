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
    ///The Endt_AIForm_FCG1019 recording.
    /// </summary>
    [TestModule("390666cb-fe8f-41de-b072-e5cafaa9f196", ModuleType.Recording, 1)]
    public partial class Endt_AIForm_FCG1019 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static Endt_AIForm_FCG1019 instance = new Endt_AIForm_FCG1019();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Endt_AIForm_FCG1019()
        {
            Endt_FCG1019FN = "S";
            Endt_FCG1019LN = "M";
            Endt_FCG1019_Address1 = "Address1";
            Endt_FCG1019_Address2 = "Address2";
            Endt_FCG1019_City = "Tampa";
            Endt_FCG1019_State = "Florida";
            Endt_FCG1019_ZipCode = "33604";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Endt_AIForm_FCG1019 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Endt_FCG1019FN;

        /// <summary>
        /// Gets or sets the value of variable Endt_FCG1019FN.
        /// </summary>
        [TestVariable("3c6b894a-dead-4209-9a55-7cdf1e366958")]
        public string Endt_FCG1019FN
        {
            get { return _Endt_FCG1019FN; }
            set { _Endt_FCG1019FN = value; }
        }

        string _Endt_FCG1019LN;

        /// <summary>
        /// Gets or sets the value of variable Endt_FCG1019LN.
        /// </summary>
        [TestVariable("4109c895-93fe-4bf8-811e-5d0233d43400")]
        public string Endt_FCG1019LN
        {
            get { return _Endt_FCG1019LN; }
            set { _Endt_FCG1019LN = value; }
        }

        string _Endt_FCG1019_Address1;

        /// <summary>
        /// Gets or sets the value of variable Endt_FCG1019_Address1.
        /// </summary>
        [TestVariable("406a5daf-5d56-4bd2-96ac-bb1c1831aa1a")]
        public string Endt_FCG1019_Address1
        {
            get { return _Endt_FCG1019_Address1; }
            set { _Endt_FCG1019_Address1 = value; }
        }

        string _Endt_FCG1019_Address2;

        /// <summary>
        /// Gets or sets the value of variable Endt_FCG1019_Address2.
        /// </summary>
        [TestVariable("b11061df-4318-4968-a315-aef9abd58e2f")]
        public string Endt_FCG1019_Address2
        {
            get { return _Endt_FCG1019_Address2; }
            set { _Endt_FCG1019_Address2 = value; }
        }

        string _Endt_FCG1019_City;

        /// <summary>
        /// Gets or sets the value of variable Endt_FCG1019_City.
        /// </summary>
        [TestVariable("c3f8fe1b-afcf-4517-8323-3df40f32f513")]
        public string Endt_FCG1019_City
        {
            get { return _Endt_FCG1019_City; }
            set { _Endt_FCG1019_City = value; }
        }

        string _Endt_FCG1019_State;

        /// <summary>
        /// Gets or sets the value of variable Endt_FCG1019_State.
        /// </summary>
        [TestVariable("3a3c187d-645f-49e8-bf09-65032249c6ff")]
        public string Endt_FCG1019_State
        {
            get { return _Endt_FCG1019_State; }
            set { _Endt_FCG1019_State = value; }
        }

        string _Endt_FCG1019_ZipCode;

        /// <summary>
        /// Gets or sets the value of variable Endt_FCG1019_ZipCode.
        /// </summary>
        [TestVariable("10ddfb60-e702-49a5-8a04-e83facb938aa")]
        public string Endt_FCG1019_ZipCode
        {
            get { return _Endt_FCG1019_ZipCode; }
            set { _Endt_FCG1019_ZipCode = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi2.IndividualFCG1019AI' at Center.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi2.IndividualFCG1019AIInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi2.IndividualFCG1019AI.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtAIFirstName' at Center.", repo.ApplicationUnderTest.TxtAIFirstNameInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.TxtAIFirstName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Endt_FCG1019FN' with focus on 'ApplicationUnderTest.TxtAIFirstName'.", repo.ApplicationUnderTest.TxtAIFirstNameInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.TxtAIFirstName.PressKeys(Endt_FCG1019FN);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtAILasstName' at Center.", repo.ApplicationUnderTest.TxtAILasstNameInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.TxtAILasstName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Endt_FCG1019LN' with focus on 'ApplicationUnderTest.TxtAILasstName'.", repo.ApplicationUnderTest.TxtAILasstNameInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.TxtAILasstName.PressKeys(Endt_FCG1019LN);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi2.TxtAIAddress1' at 389;26.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi2.TxtAIAddress1Info, new RecordItemIndex(5));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi2.TxtAIAddress1.Click("389;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Endt_FCG1019_Address1' with focus on 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi2.TxtAIAddress1'.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi2.TxtAIAddress1Info, new RecordItemIndex(6));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi2.TxtAIAddress1.PressKeys(Endt_FCG1019_Address1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi2.TxtAIAddress2' at 68;7.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi2.TxtAIAddress2Info, new RecordItemIndex(7));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi2.TxtAIAddress2.Click("68;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Endt_FCG1019_Address2' with focus on 'ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi2.TxtAIAddress2'.", repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi2.TxtAIAddress2Info, new RecordItemIndex(8));
            repo.ApplicationUnderTest.BgGreyBorderBorderBottomBorderWhi2.TxtAIAddress2.PressKeys(Endt_FCG1019_Address2);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtAICity' at Center.", repo.ApplicationUnderTest.TxtAICityInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.TxtAICity.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Endt_FCG1019_City' with focus on 'ApplicationUnderTest.TxtAICity'.", repo.ApplicationUnderTest.TxtAICityInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.TxtAICity.PressKeys(Endt_FCG1019_City);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SpanTagSelect2' at 77;11.", repo.ApplicationUnderTest.SpanTagSelect2Info, new RecordItemIndex(11));
            repo.ApplicationUnderTest.SpanTagSelect2.Click("77;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Search' at 58;23.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.Search.Click("58;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Endt_FCG1019_State' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.Search.PressKeys(Endt_FCG1019_State);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.Search.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.UseAsIs1' at 37;17.", repo.ApplicationUnderTest.UseAsIs1Info, new RecordItemIndex(15));
            repo.ApplicationUnderTest.UseAsIs1.Click("37;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtAIZipCode' at 35;22.", repo.ApplicationUnderTest.TxtAIZipCodeInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.TxtAIZipCode.Click("35;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Endt_FCG1019_ZipCode' with focus on 'ApplicationUnderTest.TxtAIZipCode'.", repo.ApplicationUnderTest.TxtAIZipCodeInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.TxtAIZipCode.PressKeys(Endt_FCG1019_ZipCode);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnAISave' at 31;19.", repo.ApplicationUnderTest.BtnAISaveInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.BtnAISave.Click("31;19");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}