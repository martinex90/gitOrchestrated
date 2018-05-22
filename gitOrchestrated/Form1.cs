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
        public string vmName = "mape2008x32EP";
        public string winVer = "Windows2008Enterprise";


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
                driver.FindElement(By.Id("MainContent_Login_ID_Password")).SendKeys("***");
                driver.FindElement(By.Id("MainContent_Login_ID_Button1")).Submit();
                driver.Url = "https://itsmweb.tdccloud.dk/workflows3/?Type=Tests";
                driver.FindElement(By.XPath("//span[text()='Add new Windows server with vApp in vCloud with StormUpdate 3.0.1']")).Click();
                selectdropdown(driver, "element",)
                SelectElement dropdown = WaitForElement(driver, "MainContent_vdcname");
                //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                dropdown.SelectByText(vdcName);
                WaitForPageRefresh(driver);
                driver.FindElement(By.Id("MainContent_VM_vmName")).SendKeys(vmName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                driver.Quit();
            }


        }//Btn_Submit_Click

        private SelectElement WaitForElement(IWebDriver driver, string elementName)
        {
            SelectElement dropdown = null;

            for (int i = 0; i < 90; i++)
            {
                try
                {
                    dropdown = new SelectElement(driver.FindElement(By.Id("MainContent_vdcname")));
                    
                }
                catch(Exception)
                {
                    Thread.Sleep(1000);
                    if (i == 89)
                        MessageBox.Show("failed to locate element within 90 seconds");
                }
            }

            return dropdown;
            
        }

        private void WaitForPageRefresh(IWebDriver driver)
        {
            IWebElement oldel = driver.FindElement(By.Id("div1"));
            string lastUpdate = oldel.Text.Substring(oldel.Text.IndexOf("Last update:"));

            for (int i = 0; i < 90; i++)
            {
                IWebElement newel = driver.FindElement(By.Id("div1"));
                string newUpdate = newel.Text.Substring(newel.Text.IndexOf("Last update:"));

                if (lastUpdate == newUpdate)
                    Thread.Sleep(1000);
                else
                    break;
            }
        }

    }//Form1
}//gitOchestrated
