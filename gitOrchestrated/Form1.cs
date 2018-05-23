using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;

namespace gitOrchestrated
{
    public partial class Form1 : Form
    {
        public string vdcName = "TDCHCXT-VDC02";
        public string vmName = "mape2008x32DC";
        public string templateVer = "Test";
        public string winVer = "Windows2008Datacenter";
        public string winEdition = "Datacenter";
        public string CPUno = "2.0";
        public string RAMno = "4.0";
        public string ADjoin = "no";
        public string orgNetworkName = "TDCHCXT_PZ_IND2";
        public string IPadd = "10.0.1.51";
        public string DNS1 = "10.0.1.10";
        public string DNS2 = "10.0.1.11";
        public string endpointProtection = "yes";



        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_submit_Click(object sender, EventArgs e)
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
                SelectDropdown(driver, "MainContent_vdcname", vdcName);
                WaitForPageRefresh(driver);
                driver.FindElement(By.Id("MainContent_VM_vmName")).SendKeys(vmName);
                SelectDropdown(driver, "MainContent_VM_TemplateCurrentOrOld", "Test");
                SelectDropdown(driver, "MainContent_VM_WindowsVersion", winVer);
                WaitForPageRefresh(driver);
                SelectDropdown(driver, "MainContent_VM_WindowsEdition", winEdition);
                WaitForPageRefresh(driver);
                SelectDropdown(driver, "MainContent_VM_cpuNumber", CPUno);
                SelectDropdown(driver, "MainContent_VM_RAM", RAMno);
                SelectDropdown(driver, "MainContent_VM_ADJoin", ADjoin);
                WaitForPageRefresh(driver);
                SelectDropdown(driver, "MainContent_orgnetworkname", orgNetworkName);
                WaitForPageRefresh(driver);
                driver.FindElement(By.Id("MainContent_VM_ipAddress")).SendKeys(IPadd);
                driver.FindElement(By.Id("MainContent_VM_IPDNS1")).SendKeys(DNS1);
                driver.FindElement(By.Id("MainContent_VM_IPDNS2")).SendKeys(DNS2);
                SelectDropdown(driver, "MainContent_VM_valueString_MicrosoftSCEP", endpointProtection);
            }
            catch (NoSuchElementException ex)
            {
                MessageBox.Show(ex.Message);
                driver.Quit();
            }
            finally
            {
                MessageBox.Show("done");
                if (driver != null)
                    driver.Quit();
            }


        }//Btn_Submit_Click

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
                    Thread.Sleep(1000);
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
                    Thread.Sleep(1000);
                    //workaround to avoid contextswitchdeadlock exception by pumping calls, since this is  a GUI thread.
                    Thread.CurrentThread.Join(10);
                    if (i == 89)
                        MessageBox.Show("failed to locate element within 90 seconds");
                }
            }
        }

        private void SelectDropdown(IWebDriver driver, string elementName, string dropdownValue)
        {
            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id(elementName)));
            dropdown.SelectByText(dropdownValue);
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
                catch (StaleElementReferenceException)
                {
                    Thread.Sleep(1000);
                    break;
                }

                if (lastUpdate == newUpdate)
                {
                    Thread.Sleep(1000);
                    //workaround to avoid contextswitchdeadlock exception by pumping calls, since this is  a GUI thread.
                    Thread.CurrentThread.Join(10);
                }
                else
                    break;
            }
        }
    }//Form1
}//gitOchestrated
