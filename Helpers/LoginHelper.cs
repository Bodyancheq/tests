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

public class LoginHelper : HelperBase
{
    public void Login(AccountData user)
    {
        driver.FindElement(By.Id("id_username_or_email")).SendKeys(user.Username);
        driver.FindElement(By.Id("id_password")).SendKeys(user.Password);
        driver.FindElement(By.Name("submit")).Click();
    }
    
    public LoginHelper(ApplicationManager manager)
        : base(manager)
    {
    }

}