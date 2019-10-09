using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PTE_1._0.Suporte;
using System.IO;

namespace PTE_1._0.Suporte
{
    public class Evidencias
    {
        private IWebDriver driver;
        private string screenshotPasta;

        public Evidencias(IWebDriver browser)
        {
            this.driver = browser;
        }

        public void capturaImagem()
        {
            String dataAtual = DateTime.Now.ToString("dd/MM/yyyy");
            String horaAtual = DateTime.Now.ToString("HH:mm:ss");
            String pasta = @"C:\Evidencias\PTE\" + dataAtual.Replace("/", "") + @"\";
            try
            {
                if (Directory.Exists(pasta))
                {
                    String arquivo = pasta + "Evidencia_" + dataAtual.Replace("/", "") + "_" + horaAtual.Replace(":", "") + @".png";
                    Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
                    image.SaveAsFile(arquivo, ScreenshotImageFormat.Png);
                }
                else
                {
                    Directory.CreateDirectory(pasta);
                    String arquivo = pasta + "Evidencia_" + dataAtual.Replace("/", "") + "_" + horaAtual.Replace(":", "") + @".png";
                    Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
                    image.SaveAsFile(arquivo, ScreenshotImageFormat.Png);
                }
            }
            catch
            {
                Console.WriteLine("Algo aconteceu e não criou a evidência");
            }
        }
    }
}
