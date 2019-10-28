// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AcceptanceTests.Tests.Features.ServiceWebsite
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Service Website Sign In")]
    public partial class ServiceWebsiteSignInFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SignIn.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Service Website Sign In", "    As an Invidual or Representative\n    I would like to sign in to VH-Service We" +
                    "b\n    So that I can complete suitability Questionnaire", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Users with no pending questionnaires to complete when signing in to the Service W" +
            "ebsite is redirected to Video Website")]
        [NUnit.Framework.CategoryAttribute("smoketest")]
        [NUnit.Framework.TestCaseAttribute("Individual", null)]
        [NUnit.Framework.TestCaseAttribute("Representative", null)]
        public virtual void UsersWithNoPendingQuestionnairesToCompleteWhenSigningInToTheServiceWebsiteIsRedirectedToVideoWebsite(string role, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "smoketest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Users with no pending questionnaires to complete when signing in to the Service W" +
                    "ebsite is redirected to Video Website", null, @__tags);
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
    testRunner.Given(string.Format("I am registered as \'{0}\' in the Video Hearings Azure AD", role), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
    testRunner.And("I don\'t have any pending questionnaires to complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
    testRunner.When("I sign in to the \'Service Website\' using my account details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
    testRunner.Then("I am redirected to the \'Video Website\' automatically", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User with no pending questionnaires to complete but dropped out when signing in t" +
            "o the Service Website is redirected to Video Website")]
        [NUnit.Framework.TestCaseAttribute("Do you have a computer?", null)]
        [NUnit.Framework.TestCaseAttribute("Does your computer have a camera and microphone?", null)]
        [NUnit.Framework.TestCaseAttribute("Will you have access to the Internet?", null)]
        public virtual void UserWithNoPendingQuestionnairesToCompleteButDroppedOutWhenSigningInToTheServiceWebsiteIsRedirectedToVideoWebsite(string question_Title, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User with no pending questionnaires to complete but dropped out when signing in t" +
                    "o the Service Website is redirected to Video Website", null, exampleTags);
#line 17
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 18
    testRunner.Given("I am registered as \'Individual\' in the Video Hearings Azure AD", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
    testRunner.And("I don\'t have any pending questionnaires to complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
    testRunner.But(string.Format("I answered \'No\' to \'{0}\' question", question_Title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line 21
    testRunner.When("I sign in to the \'Service Website\' using my account details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
    testRunner.Then("I am redirected to \'Video Website\' automatically", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
