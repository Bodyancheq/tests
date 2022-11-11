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
        js.ExecuteScript("window.scrollTo(0,2322)");
        Thread.Sleep(3000);
        driver.FindElement(By.CssSelector("#\\31 029861194\\3Ashoutbox\\3A f2cbf189-8540-4be2-871c-02d6f7eee375 .shout-more-actions")).Click();
        driver.FindElement(By.CssSelector("#shout-more-actions-75ca8a79-50ee-4693-a2ba-b16a53721986 .js-delete-shout > .dropdown-menu-clickable-item")).Click();
        {
            var element = driver.FindElement(By.CssSelector("#\\31 029861194\\3Ashoutbox\\3A 253e705b-93c5-4065-a464-26b04f3563ae time"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        {
            var element = driver.FindElement(By.TagName("body"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element, 0, 0).Perform();
        }
        driver.FindElement(By.CssSelector(".modal-button > .btn-primary")).Click();
    }
    
    public ShoutHelper(ApplicationManager manager)
        : base(manager)
    {
    }

    public ShoutData SelectLastShoutData()
    {
        string shoutText = driver.FindElement(By.ClassName("shout-body")).FindElement(By.TagName("p")).Text;
        return new ShoutData(shoutText) {ShoutText = shoutText};
    }
}