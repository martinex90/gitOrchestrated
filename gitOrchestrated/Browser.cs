using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System.IO;

namespace gitOrchestrated
{
    /// <summary>
    /// Handles the browser automation via Selenium.
    /// </summary>
    public class Browser
    {
        public Browser()
        {
            //constructor for checking the user login
            Application.UseWaitCursor = true;
        }

        public Browser(Server srv)
        {
            //constructor for when filling in fields with server information
            Application.UseWaitCursor = true;
            server = srv;
        }

        private string lastUpdate = null;

        private Server server;


        private IWebDriver InitialiseWebDriver()
        {
            FirefoxDriverService fs = FirefoxDriverService.CreateDefaultService();
            fs.HideCommandPromptWindow = true;

            FirefoxOptions FFOpt = new FirefoxOptions();
            FFOpt.AcceptInsecureCertificates = true;
            FFOpt.PageLoadStrategy = PageLoadStrategy.Normal;

            IWebDriver driver = new FirefoxDriver(fs, FFOpt, TimeSpan.FromSeconds(60));
            return driver;
        }

        /// <summary>
        /// Opens a driver as the main Method and navigates the browser while waiting. 
        /// </summary>
        public void AutomateInput(CheckBox test)
        {
            IWebDriver driver = InitialiseWebDriver();

            try
            {
                NavigateAndWaitForElement(driver, "https://itsmweb.tdccloud.dk/Account/Login.aspx", "MainContent_Login_ID_Button1");
                SendKeysAndVerify(driver, "MainContent_Login_ID_UserName", Credential.Username);
                SendKeysAndVerify(driver, "MainContent_Login_ID_Password", Credential.Password);
                NavigateAndWaitForElement(driver, "MainContent_Login_ID_Button1", "loginuser");
                NavigateAndWaitForElement(driver, "https://itsmweb.tdccloud.dk/workflows3/?Type=vCloud", "//span[text()='Add new Windows server with vApp in vCloud with StormUpdate 3.0.1']");
                NavigateAndWaitForElement(driver, "//span[text()='Add new Windows server with vApp in vCloud with StormUpdate 3.0.1']", "MainContent_vdcname");
                SelectDropdown(driver, "MainContent_vdcname", server.VDCName);
                SendKeysAndVerify(driver, "MainContent_VM_vmName", server.VMName);
                SelectDropdown(driver, "MainContent_VM_TemplateCurrentOrOld", server.TemplateVer);
                SelectDropdown(driver, "MainContent_VM_WindowsVersion", server.WinVer);
                SelectDropdown(driver, "MainContent_VM_WindowsEdition", server.WinEdition);
                SelectDropdown(driver, "MainContent_VM_cpuNumber", server.CPUNo);
                SelectDropdown(driver, "MainContent_VM_RAM", server.RAM);
                SelectDropdown(driver, "MainContent_VM_ADJoin", server.ADJoin);
                SelectDropdown(driver, "MainContent_orgnetworkname", server.OrgNetworkName);
                driver.FindElement(By.Id("MainContent_VM_ipAddress")).SendKeys(server.IPAdd);
                driver.FindElement(By.Id("MainContent_VM_IPDNS1")).SendKeys(server.DNS1);
                driver.FindElement(By.Id("MainContent_VM_IPDNS2")).SendKeys(server.DNS2);
                SelectDropdown(driver, "MainContent_VM_valueString_MicrosoftSCEP", server.EndpointProtection);
                NavigateAndWaitForElement(driver, "MainContent_ValidateWorkflow", "MainContent_RunWorkflow");
                if (test.Checked == false)
                {
                    NavigateAndWaitForElement(driver, "MainContent_RunWorkflow", "TopMenuContent_SUB1");
                }

                MessageBox.Show("The following server succeeded:" + server.VMName + ".\r\n This browserwindow will close.", "Succeeded: " + server.VMName);
            }
            catch (NoSuchElementException ex)
            {
                MessageBox.Show("The following server failed:" + server.VMName + ". \r\n The following error was thrown: " + ex.Message + ".\r\n This browserwindow will close.", "Failed: "+server.VMName);
                return;
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Failed to select the drop down value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                driver.Quit();
                Application.UseWaitCursor = false;
            }
        }

        /// <summary>
        /// Check if the login can be used to log on the Orchestrator Portal. 
        /// </summary>
        /// <param name="username">The Username of the user.</param>
        /// <param name="password">The Password of the user.</param>
        /// <returns>Returns a string value indicating the username if successful, or failed if unsuccessful.</returns>
        public string VerifyLogin(string username, string password)
        {
            IWebDriver driver = InitialiseWebDriver();
            
            NavigateAndWaitForElement(driver, "https://itsmweb.tdccloud.dk/Account/Login.aspx", "MainContent_Login_ID_Button1");
            SendKeysAndVerify(driver, "MainContent_Login_ID_UserName", username);
            SendKeysAndVerify(driver, "MainContent_Login_ID_Password", password);
            driver.FindElement(By.Id("MainContent_Login_ID_Button1")).Click();
            try
            {
                driver.FindElement(By.ClassName("validation-summary-errors"));
                driver.Quit();
                Application.UseWaitCursor = false;
                return "Failed";
            }
            catch(Exception)
            {
                driver.FindElement(By.Id("loginuser"));
                driver.Quit();
                Application.UseWaitCursor = false;
                return "Success";
            }
        }

        /// <summary>
        /// Sends the selected keys to a selected element via the webdriver. 
        /// </summary>
        /// <param name="driver">The webdriver to send keys to an element on a web page.</param>
        /// <param name="elementName">The element to receive the keys sent.</param>
        /// <param name="fieldValue">The keys to be sent to the element.</param>
        private void SendKeysAndVerify(IWebDriver driver, string elementName, string fieldValue)
        {
            IWebElement webel = null;
            while (webel?.GetAttribute("value") != fieldValue)
                {
                    try
                    {
                        webel = driver.FindElement(By.Id(elementName));
                        webel.SendKeys(fieldValue);
                    }
                    catch (Exception) { Thread.Sleep(1500); }
                }
            
        }

        /// <summary>
        /// Tries to click a navigation option, and then waits for the page refresh by searching for an element. 
        /// When element is found, it returns.
        /// It gives up after 90 seconds and just returns. 
        /// </summary>
        /// <param name="driver">The webdriver to navigate somewhere.</param>
        /// <param name="navigation">The URL to follow || the element to click depending on xpath or id.</param>
        /// <param name="elementToWaitFor">The element to search for, after the navigation has been triggered.</param>
        private void NavigateAndWaitForElement(IWebDriver driver, string navigation, string elementToWaitFor)
        {
            if (navigation.Contains("http"))
                driver.Url = navigation;
            else
            {
                if (navigation.Contains("//span"))
                {
                    driver.FindElement(By.XPath(navigation)).Click();
                }
                else
                {
                    driver.FindElement(By.Id(navigation)).Click();
                }
            }

            for (int i = 0; i < 60; i++)
            {
                try
                {
                    if (elementToWaitFor.Contains("//span"))
                    {
                        driver.FindElement(By.XPath(elementToWaitFor));
                        return;
                    }
                    else
                    {
                        driver.FindElement(By.Id(elementToWaitFor));
                        return;
                    }
                }
                catch (Exception)
                {
                    Thread.Sleep(1500);
                }
            }
        }

        /// <summary>
        /// Selects a dropdown and waits for a page refresh.
        /// </summary>
        /// <param name="driver">The the webdriver to select a value in a dropdown.</param>
        /// <param name="elementName">The dropdownbox element  found through id.</param>
        /// <param name="dropdownValue">The value to be inserted into the dropdownbox.</param>
        private void SelectDropdown(IWebDriver driver, string elementName, string dropdownValue)
        {
            

            if (dropdownValue == null || dropdownValue == "")
                return;


            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id(elementName)));
            string SelectedOption = dropdown.SelectedOption.Text;

            switch (elementName)
            {
                case "MainContent_VM_TemplateCurrentOrOld":
                    dropdown.SelectByText(dropdownValue);
                    return;
                case "MainContent_VM_cpuNumber":
                    dropdown.SelectByText(dropdownValue);
                    return;
                case "MainContent_VM_RAM":
                    dropdown.SelectByText(dropdownValue);
                    return;
                case "MainContent_VM_valueString_MicrosoftSCEP":
                    dropdown.SelectByText(dropdownValue);
                    return;
            }
            


            if (SelectedOption != dropdownValue)
            {
                IWebElement oldel = driver.FindElement(By.Id("div1"));
                lastUpdate = oldel.Text.Substring(oldel.Text.IndexOf("Last update:"));
                try{dropdown.SelectByText(dropdownValue);}
                catch{ throw new ArgumentOutOfRangeException("The selected dropdown value: " + dropdownValue + " was not found in the following dropdown element: " + elementName + ".\r\nThis window will close."); }
                WaitForPageRefresh(driver);
            }
        }

        /// <summary>
        /// Waits for a page refresh by evaluating if the timestamp at the bottom of the page has changed.
        /// This happens for 90 seconds before it gives up.
        /// </summary>
        /// <param name="driver">The webdriver to wait for a refresh.</param>
        private void WaitForPageRefresh(IWebDriver driver)
        {
            string newUpdate;

            for (int i = 0; i < 60; i++)
            {
                try
                {
                    IWebElement newel = driver.FindElement(By.Id("div1"));
                    newUpdate = newel.Text.Substring(newel.Text.IndexOf("Last update:"));
                }
                catch (Exception)
                {
                    Thread.Sleep(1500);
                    break;
                }

                if (lastUpdate == newUpdate)
                {
                    Thread.Sleep(1500);
                }
                else
                    break;
            }//for
        }//WaitForPageRefresh
    }//Browser
}//gitOrchestrated