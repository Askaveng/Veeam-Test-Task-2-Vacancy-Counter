using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://careers.veeam.ru/vacancies");
            driver.Manage().Window.Maximize();
            void Clicker(string s) => driver.FindElementByXPath(s).Click();
            Clicker("//button[contains(text(), 'Все отделы')]");
            Clicker("//a[contains(text(), 'Разработка продуктов')]");
            Clicker("//button[contains(text(), 'Все языки')]");
            Clicker("//label[contains(text(), 'Английский')]");
            Console.WriteLine(driver.FindElements(By.CssSelector(".card.card-no-hover.card-sm")).Count);
        }
    }
}
