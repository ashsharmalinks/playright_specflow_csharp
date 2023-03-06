using FluentAssertions;
using SpecFlowProject_Playwright_Ash.Drivers;
using SpecFlowProject_Playwright_Ash.Pages;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject_Playwright_Ash.Steps;

[Binding]
public sealed class EapplginSteps
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly Driver _driver;
    private readonly LoginPage _loginPage;
    public EapplginSteps(Driver driver)
    {
        _driver = driver;
        _loginPage = new LoginPage(_driver.Page);
    }

    [Given(@"I have navigated to EEApp website")]
    public void GivenIHaveNavigatedToEeAppWebsite()
    {
        _driver.Page.GotoAsync("http://eaapp.somee.com/");
    }
    
    [Then(@"I see the employee details")]
    public async Task ThenISeeTheEmployeeDetails()
    {
      var isExist =  await  _loginPage.IsEmployeeDetails();
      isExist.Should().Be(true);
    }

    [When(@"I enter the username and password")]
    public void WhenIEnterTheUsernameAndPassword()
    {
    }

    [Given(@"I click on the login link")]
    public async Task GivenClickButton()
    {
        await _loginPage.ClickLogin();
    }

    [When(@"I enter the ""(.*)"" and ""(.*)""")]
    public async  Task WhenIEnterTheAnd(string admin, string password)
    {
        await _loginPage.Login(admin, password);
    }

    [When(@"I enter following login details")]
    public async Task WhenIEnterFollowingLoginDetails(Table table)
    {
        dynamic data = table.CreateDynamicInstance();
        await _loginPage.Login((string)data.UserName, (string)data.Password);
    }
}