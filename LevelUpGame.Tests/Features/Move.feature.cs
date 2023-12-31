﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace LevelUpGame.Test.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Move")]
    public partial class MoveFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Move.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Move", "    I want to move my character. If they attempt to move past a boundary, the mov" +
                    "e results in no change in position but does increment move count.", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Move in a direction")]
        [NUnit.Framework.CategoryAttribute("acceptance")]
        [NUnit.Framework.TestCaseAttribute("0", "0", "NORTH", "103", "0", "1", "11", null)]
        [NUnit.Framework.TestCaseAttribute("0", "0", "SOUTH", "32", "0", "0", "33", null)]
        [NUnit.Framework.TestCaseAttribute("0", "0", "NORTH", "103", "0", "1", "104", null)]
        [NUnit.Framework.TestCaseAttribute("0", "0", "EAST", "1", "1", "0", "2", null)]
        [NUnit.Framework.TestCaseAttribute("0", "0", "WEST", "67", "0", "0", "68", null)]
        [NUnit.Framework.TestCaseAttribute("0", "9", "NORTH", "57", "0", "9", "58", null)]
        [NUnit.Framework.TestCaseAttribute("0", "9", "SOUTH", "38", "0", "8", "39", null)]
        [NUnit.Framework.TestCaseAttribute("0", "9", "EAST", "45", "1", "9", "46", null)]
        [NUnit.Framework.TestCaseAttribute("0", "9", "WEST", "25", "0", "9", "26", null)]
        [NUnit.Framework.TestCaseAttribute("9", "9", "NORTH", "58", "9", "9", "59", null)]
        [NUnit.Framework.TestCaseAttribute("9", "9", "SOUTH", "83", "9", "8", "84", null)]
        [NUnit.Framework.TestCaseAttribute("9", "9", "EAST", "9", "9", "9", "10", null)]
        [NUnit.Framework.TestCaseAttribute("9", "9", "WEST", "4", "8", "9", "5", null)]
        [NUnit.Framework.TestCaseAttribute("9", "0", "NORTH", "768", "9", "1", "769", null)]
        [NUnit.Framework.TestCaseAttribute("9", "0", "SOUTH", "35", "9", "0", "36", null)]
        [NUnit.Framework.TestCaseAttribute("9", "0", "EAST", "83", "9", "0", "84", null)]
        [NUnit.Framework.TestCaseAttribute("9", "0", "WEST", "36", "8", "0", "37", null)]
        [NUnit.Framework.TestCaseAttribute("5", "5", "NORTH", "57", "5", "6", "58", null)]
        [NUnit.Framework.TestCaseAttribute("5", "5", "SOUTH", "75", "5", "4", "76", null)]
        [NUnit.Framework.TestCaseAttribute("5", "5", "EAST", "45", "6", "5", "46", null)]
        [NUnit.Framework.TestCaseAttribute("5", "5", "WEST", "53", "4", "5", "54", null)]
        public void MoveInADirection(string startingPositionX, string startingPositionY, string direction, string startingMoveCount, string endingPositionX, string endingPositionY, string endingMoveCount, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "acceptance"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("startingPositionX", startingPositionX);
            argumentsOfScenario.Add("startingPositionY", startingPositionY);
            argumentsOfScenario.Add("direction", direction);
            argumentsOfScenario.Add("startingMoveCount", startingMoveCount);
            argumentsOfScenario.Add("endingPositionX", endingPositionX);
            argumentsOfScenario.Add("endingPositionY", endingPositionY);
            argumentsOfScenario.Add("endingMoveCount", endingMoveCount);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Move in a direction", "    Simple example of how to test move", tagsOfScenario, argumentsOfScenario, featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
    testRunner.Given(string.Format("the character starts at position with XCoordinates {0}", startingPositionX), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
    testRunner.And(string.Format("starts at YCoordinates {0}", startingPositionY), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
    testRunner.And(string.Format("the player chooses to move in {0}", direction), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
    testRunner.And(string.Format("the current move count is {0}", startingMoveCount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
    testRunner.When("the character moves", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
    testRunner.Then(string.Format("the character is now at position with XCoordinates {0}", endingPositionX), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 14
    testRunner.And(string.Format("YCoordinates  {0}", endingPositionY), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
    testRunner.And(string.Format("the new move count is {0}", endingMoveCount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
