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

public class PlayListHelper : HelperBase
{
    public void ChangeName(PlayListData data)
    {
        driver.FindElement(By.CssSelector(".inplace-field--facade-title")).Click();
        {
            var element = driver.FindElement(By.CssSelector(".inplace-field--facade-title"));
            js.ExecuteScript($"if(arguments[0].contentEditable === 'true') {{arguments[0].innerText = '{data.PlayListName}'}}", element);
        }
        driver.FindElement(By.CssSelector(".playlisting-playlist-header-image")).Click();
    }

    
    public PlayListHelper(ApplicationManager manager)
        : base(manager)
    {
    }

    public PlayListData SelectPlayListData()
    {
        string albumName = driver.FindElement(By.CssSelector(".inplace-field--facade-title")).Text;
        return new PlayListData(albumName) {PlayListName = albumName};
    }
}