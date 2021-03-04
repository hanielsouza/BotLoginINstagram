using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InstagramTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abre o navegador e navega para a URL do Instagram
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.instagram.com/");

            
            //Faz o bot aguardar pelo tempo especificado em milisegundos
            Thread.Sleep(2000);

            //Resgata o campo de login
            IWebElement campo_usuario = driver.FindElement(By.Name("username"));


            //Digita o login no campo
            campo_usuario.SendKeys("");

            //Resgata o campo Senha
            IWebElement campo_senha = driver.FindElement(By.Name("password"));
            //Digita a senha no campo
            campo_senha.SendKeys("");

            //Simula o apertar do botão enter no campo de senha
            campo_senha.SendKeys(Keys.Return);

            //print da página
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:/Users/hanie/Desktop/Screenshot.png", ScreenshotImageFormat.Png);

            //if (driver.Url == "")
            //{
            //    Console.WriteLine("Sucesso!!");
            //    driver.Quit();
            //}
            //else
            //{
            //    Console.WriteLine("Falha no teste!!");
            //}


        }
    }
}
