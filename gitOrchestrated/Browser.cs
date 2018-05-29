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
            
        }

        public string VDCName { get; set; }
        public string VMName { get; set; }
        public string TemplateVer { get; set; }
        public string WinVer { get; set; }
        public string WinEdition { get; set; }
        public string CPUNo { get; set; }
        public string RAM { get; set; }
        public string ADJoin { get; set; }
        public string OrgNetworkName { get; set; }
        public string IPAdd { get; set; }
        public string DNS1 { get; set; }
        public string DNS2 { get; set; }
        public string EndpointProtection { get; set; }

        public void AutomateInput()
        {

            FirefoxOptions FFOpt = new FirefoxOptions();
            FFOpt.AcceptInsecureCertificates = true;
            IWebDriver driver = new FirefoxDriver(FFOpt);

            try
            {
                driver.Url = "https://itsmweb.tdccloud.dk/Account/Login.aspx";
                driver.FindElement(By.Id("MainContent_Login_ID_UserName")).SendKeys("mape");
                driver.FindElement(By.Id("MainContent_Login_ID_Password")).SendKeys(File.ReadAllText(@"C:\Users\mape\Desktop\txt\pw.txt"));
                driver.FindElement(By.Id("MainContent_Login_ID_Button1")).Submit();
                driver.Url = "https://itsmweb.tdccloud.dk/workflows3/?Type=Tests";
                IWebElement navigation = driver.FindElement(By.XPath("//span[text()='Add new Windows server with vApp in vCloud with StormUpdate 3.0.1']"));
                NavigateAndWaitForElement(driver, navigation, "MainContent_vdcname");
                SelectDropdown(driver, "MainContent_vdcname", VDCName);
                driver.FindElement(By.Id("MainContent_VM_vmName")).SendKeys(VMName);
                SelectDropdown(driver, "MainContent_VM_TemplateCurrentOrOld", "Test");
                SelectDropdown(driver, "MainContent_VM_WindowsVersion", WinVer);
                SelectDropdown(driver, "MainContent_VM_WindowsEdition", WinEdition);
                SelectDropdown(driver, "MainContent_VM_cpuNumber", CPUNo);
                SelectDropdown(driver, "MainContent_VM_RAM", RAM);
                SelectDropdown(driver, "MainContent_VM_ADJoin", ADJoin);
                SelectDropdown(driver, "MainContent_orgnetworkname", OrgNetworkName);
                driver.FindElement(By.Id("MainContent_VM_ipAddress")).SendKeys(IPAdd);
                driver.FindElement(By.Id("MainContent_VM_IPDNS1")).SendKeys(DNS1);
                driver.FindElement(By.Id("MainContent_VM_IPDNS2")).SendKeys(DNS2);
                SelectDropdown(driver, "MainContent_VM_valueString_MicrosoftSCEP", EndpointProtection);
            }
            catch (NoSuchElementException ex)
            {

                driver.Quit();
                throw ex;
            }
            finally
            {
                MessageBox.Show("done");
                if (driver != null)
                    driver.Quit();
            }
        }

        private void NavigateAndWaitForElement(IWebDriver driver, string url, string elementName)
        {
            driver.Url = url;

            for (int i = 0; i < 90; i++)
            {
                try
                {
                    driver.FindElement(By.Id(elementName));

                }
                catch (Exception)
                {
                    Thread.Sleep(1500);
                    //workaround to avoid contextswitchdeadlock exception by pumping calls, since this is  a GUI thread.
                    Thread.CurrentThread.Join(10);
                    if (i == 89)
                        MessageBox.Show("failed to locate element within 90 seconds");
                }
            }
        }

        private void NavigateAndWaitForElement(IWebDriver driver, IWebElement webel, string elementName)
        {
            webel.Click();

            for (int i = 0; i < 90; i++)
            {
                try
                {
                    driver.FindElement(By.Id(elementName));
                }
                catch (Exception)
                {
                    Thread.Sleep(1500);
                    //workaround to avoid contextswitchdeadlock exception by pumping calls, since this is  a GUI thread.
                    //could be fixed with a background thread of sorts, maybe. 
                    Thread.CurrentThread.Join(10);
                    if (i == 89)
                        MessageBox.Show("failed to locate element within 90 seconds");
                }
            }
        }

        private void SelectDropdown(IWebDriver driver, string elementName, string dropdownValue)
        {
            

            if (dropdownValue == null)
                return;

            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id(elementName)));
            string SelectedOption = dropdown.SelectedOption.Text;
            dropdown.SelectByText(dropdownValue);

            switch (elementName)
            {
                case "MainContent_VM_TemplateCurrentOrOld":
                    return;
                case "MainContent_VM_cpuNumber":
                    return;
                case "MainContent_VM_RAM":
                    return;
                case "MainContent_VM_valueString_MicrosoftSCEP":
                    return;
            }

            if (SelectedOption != dropdownValue)
            {
                WaitForPageRefresh(driver);
            }
        }

        private void WaitForPageRefresh(IWebDriver driver)
        {
            IWebElement oldel = driver.FindElement(By.Id("div1"));
            string newUpdate;
            string lastUpdate = oldel.Text.Substring(oldel.Text.IndexOf("Last update:"));

            for (int i = 0; i < 90; i++)
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
                    //workaround to avoid contextswitchdeadlock exception by pumping calls, since this is  a GUI thread.
                    Thread.CurrentThread.Join(10);
                }
                else
                    break;
            }//for
        }//WaitForPageRefresh
    }//Browser
}//gitOrchestrated