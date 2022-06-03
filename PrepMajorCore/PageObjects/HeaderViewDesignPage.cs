using NUnit.Framework;
using OpenQA.Selenium;
using PrepMajorCore.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrepMajorCore.PageObjects
{
    class HeaderViewDesignPage
    {
        IWebDriver driver;

        IWebElement searchCourses => driver.FindElement(By.XPath("//div[@class='center-unit']//input[@id='search-courses-input']"));

        IWebElement blog => driver.FindElement(By.CssSelector("ul:nth-child(1) > li:nth-child(2) a:nth-child(1)"));


        public HeaderViewDesignPage()
        {
            driver = BaseTest.driver;
        }


        public void SearchCoursesIsDisplayed()
        {
            Assert.IsTrue(searchCourses.Displayed);
        }

        public void BlogIsDisplayed()
        {
            Assert.IsTrue(blog.Displayed);

        }

    }
}