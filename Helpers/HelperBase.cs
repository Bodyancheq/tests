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

public class HelperBase
{
    protected IJavaScriptExecutor js;
    protected ApplicationManager manager;
    protected IWebDriver driver;
    
    public HelperBase(ApplicationManager manager)
    {
        this.manager = manager;
        this.driver = manager.Driver;
        this.js = manager.JavaScriptExecutor;
    }

}