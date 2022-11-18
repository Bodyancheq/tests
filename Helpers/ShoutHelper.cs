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

public class ShoutHelper : HelperBase
{
    public void AddShout(ShoutData shout)
    {
        js.ExecuteScript("window.scrollTo(0,82.4000015258789)");
        js.ExecuteScript("window.scrollTo(0,2220.800048828125)");
        Thread.Sleep(3000);
        driver.FindElement(By.Id("id_body")).Click();
        driver.FindElement(By.Id("id_body")).SendKeys(shout.ShoutText);
        driver.FindElement(By.CssSelector(".btn-inner")).Click();
    }

    public void DeleteShout()
    {
        driver.FindElement(By.ClassName("chartlist-more-button")).Click();
        driver.FindElement(By.ClassName("more-item--delete")).Click();
    }
    
    public ShoutHelper(ApplicationManager manager)
        : base(manager)
    {
    }

    public ShoutData SelectLastShoutData()
    {
        string shoutText = driver.FindElement(By.ClassName("shout-body")).FindElement(By.TagName("p")).Text;
        return new ShoutData() {ShoutText = shoutText};
    }
}