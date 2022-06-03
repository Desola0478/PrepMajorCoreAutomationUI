using NUnit.Framework;
using OpenQA.Selenium;
using PrepMajorCore.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrepMajorCore.PageObjects
{
    class InstructorPanelViewPage
    {
        IWebDriver driver;

        IWebElement instructorpicture => driver.FindElement(By.CssSelector("div.stm_lms_user_float_menu__user_avatar > img"));


        public InstructorPanelViewPage()
        {
            driver = BaseTest.driver;
        }

        public void InstructorPictureIsDisplayed()
        {
            Assert.IsTrue(instructorpicture.Displayed);
        }
        
    }
}
