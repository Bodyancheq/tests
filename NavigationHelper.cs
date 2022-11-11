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


public class NavigationHelper : HelperBase
{
    public void OpenHomePage()
    {
        driver.Navigate().GoToUrl("https://www.last.fm/login");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 824);
    }
    
    public void OpenMyPage()
    {
        driver.Navigate().GoToUrl("https://www.last.fm/user/bodyancheq");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 824);
    }
    
    public NavigationHelper(ApplicationManager manager)
        : base(manager)
    {
    }
}