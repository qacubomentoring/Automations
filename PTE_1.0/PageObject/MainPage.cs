using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PTE_1._0.PageObject
{
    class MainPage
    {
        private IWebDriver driver;
        public MainPage(IWebDriver browser)
        {
            this.driver = browser;

        }
        private WebDriverWait wait => new WebDriverWait(driver, new TimeSpan(0, 0, 30));

        private IWebElement btn_NovaProposta => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/as-main-app/div/as-home/section/nav/div[2]/a")));

        private IWebElement btn_NovaCotacao => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//as-main-app//as-home/section/nav/div[1]/a[@role='button']")));

        private IWebElement btn_CotacoesSalvas => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//as-main-app//as-home/section/nav/div[1]/ul//button[@value='COTACOES']")));

        private IWebElement btn_PropostasAnalise => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//li[@id='EM_ANALISE']/button[@value='EM_ANALISE']")));

        private IWebElement btn_PropostasAnalisadas => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//li[@id='APROVADA']/button[@value='APROVADA']")));

        private IWebElement btn_PropostasImplantadas => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//li[@id='IMPLANTADA']/button[@value='IMPLANTADA']")));

        public void clickNovaProposta()
        {            
            btn_NovaProposta.Click();
        }

        public void clickNovaCotacao()
        {            
            btn_NovaCotacao.Click();
        }

        public void clickBoardCotacaoSalvas()
        {            
            btn_CotacoesSalvas.Click();
        }

        public void clickPropostasAnalise()
        {            
            btn_PropostasAnalise.Click();
        }

        public void clickPropostasAnalisadas()
        {            
            btn_PropostasAnalisadas.Click();
        }

        public void clickPropostasImplantadas()
        {            
            btn_PropostasImplantadas.Click();
        }
    }
}
