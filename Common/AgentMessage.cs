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

namespace Sid_FCGAProject.Common
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AgentMessage recording.
    /// </summary>
    [TestModule("c848bc41-79b0-4fd3-b5f3-ef08d454e9e6", ModuleType.Recording, 1)]
    public partial class AgentMessage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static AgentMessage instance = new AgentMessage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AgentMessage()
        {
            BusinessInsuredName = "Autmfcga-222Sid";
            Agent_Message = "Hello";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AgentMessage Instance
        {
            get { return instance; }
        }

#region Variables

        string _BusinessInsuredName;

        /// <summary>
        /// Gets or sets the value of variable BusinessInsuredName.
        /// </summary>
        [TestVariable("1b2d247c-1f40-41f8-92fa-145ca285cd13")]
        public string BusinessInsuredName
        {
            get { return _BusinessInsuredName; }
            set { _BusinessInsuredName = value; }
        }

        string _Agent_Message;

        /// <summary>
        /// Gets or sets the value of variable Agent_Message.
        /// </summary>
        [TestVariable("eff619d0-9c08-47a5-bc3a-e26a39238166")]
        public string Agent_Message
        {
            get { return _Agent_Message; }
            set { _Agent_Message = value; }
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TxtSearch1' at Center.", repo.ApplicationUnderTest.TxtSearch1Info, new RecordItemIndex(0));
            //repo.ApplicationUnderTest.TxtSearch1.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$BusinessInsuredName' with focus on 'ApplicationUnderTest.TxtSearch1'.", repo.ApplicationUnderTest.TxtSearch1Info, new RecordItemIndex(1));
            //repo.ApplicationUnderTest.TxtSearch1.PressKeys(BusinessInsuredName);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnSearch' at Center.", repo.ApplicationUnderTest.BtnSearchInfo, new RecordItemIndex(2));
            //repo.ApplicationUnderTest.BtnSearch.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(3));
            //Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnAction' at Center.", repo.ApplicationUnderTest.BtnActionInfo, new RecordItemIndex(4));
            //repo.ApplicationUnderTest.BtnAction.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Agent_Record_Screen.AgentRecord_Action_Message' at Center.", repo.ApplicationUnderTest.Agent_Record_Screen.AgentRecord_Action_MessageInfo, new RecordItemIndex(5));
            //repo.ApplicationUnderTest.Agent_Record_Screen.AgentRecord_Action_Message.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Agent_Record_Screen.AgentRecord_Action_Messaging' at Center.", repo.ApplicationUnderTest.Agent_Record_Screen.AgentRecord_Action_MessagingInfo, new RecordItemIndex(6));
            //repo.ApplicationUnderTest.Agent_Record_Screen.AgentRecord_Action_Messaging.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Agent_Message' with focus on 'ApplicationUnderTest.Agent_Record_Screen.AgentRecord_Action_Messaging'.", repo.ApplicationUnderTest.Agent_Record_Screen.AgentRecord_Action_MessagingInfo, new RecordItemIndex(7));
            //repo.ApplicationUnderTest.Agent_Record_Screen.AgentRecord_Action_Messaging.PressKeys(Agent_Message);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(8));
            //Delay.Duration(2000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AgentRecord_ActionSend' at Center.", repo.ApplicationUnderTest.AgentRecord_ActionSendInfo, new RecordItemIndex(9));
            //repo.ApplicationUnderTest.AgentRecord_ActionSend.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(10));
            //Delay.Duration(2000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AgentMessageCloseLink' at Center.", repo.AgentMessageCloseLinkInfo, new RecordItemIndex(11));
            //repo.AgentMessageCloseLink.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(12));
            //Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}