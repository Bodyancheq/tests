namespace TestProject1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

public class ApplicationManager
{   
    private IWebDriver driver;
    private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();
    private IJavaScriptExecutor js;
    public IDictionary<string, object> vars {get; private set;}
    private NavigationHelper navigation;
    private LoginHelper auth;
    private ShoutHelper shout;

    public ApplicationManager()
    {
        driver = new ChromeDriver(@"C:\University\Testi\autotests1\TestProject1\TestProject1\");
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
        shout = new ShoutHelper(this);
        auth = new LoginHelper(this);
        navigation = new NavigationHelper(this);
    }
    
    ~ApplicationManager()
    {
        try
        {
            driver.Quit();
        }
        catch (Exception)
        { 
            //ignore
        }
    }
    
    public static ApplicationManager GetInstance()
    {
        if (!app.IsValueCreated)
        {
            ApplicationManager newInstance = new ApplicationManager();
            newInstance.navigation.OpenHomePage();
            app.Value = newInstance;
        }
        return app.Value;
    }

    public void Stop()
    {
        driver.Quit();
    }

    
    public IWebDriver Driver
    {
        get
        {
            return driver;
        }
    }

    public IJavaScriptExecutor JavaScriptExecutor
    {
        get
        {
            return js;
        }
    }
    
    public NavigationHelper Navigation
    {
        get
        {
            return navigation;
        }
    }
    
    public LoginHelper Auth
    {
        get
        {
            return auth;
        }
    }
    public ShoutHelper Shout
    {
        get
        {
            return shout;
        }
    }


}