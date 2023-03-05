using Microsoft.Playwright;

// using NUnit.Framework;

namespace SpecFlowProject_Playwright_Ash.Pages;

public class LoginPage {
    private IPage _page;
    public LoginPage(IPage page) => _page = page;

    // Page Locators
    private ILocator _lnklogin => _page.Locator(selector:"text=Login");
    private  ILocator _txtUserName => _page.Locator(selector: "#UserName");
    private ILocator _txtPassword => _page.Locator(selector: "#Password");
    private ILocator _btnLogin => _page.Locator(selector:"text=Log in");
    private ILocator _lnkEmployeeDetails=> _page.Locator(selector:"text=Employee Details");

    public async Task ClickLogin(){
        await _lnklogin.ClickAsync();
    }

    public async Task Login(string userName, String password)
    {
        await _txtUserName.FillAsync(userName);
        await _txtPassword.FillAsync(password);
        await _btnLogin.ClickAsync();
    }

    public async Task<bool> IsEmployeeDetails() => await _lnkEmployeeDetails.IsVisibleAsync();

}