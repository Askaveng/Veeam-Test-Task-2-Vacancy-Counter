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
            driver.FindElement(By.XPath("//button[contains(text(), 'Все отделы')]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(), 'Разработка продуктов')]")).Click();
            driver.FindElement(By.XPath("//button[contains(text(), 'Все языки')]")).Click();
            driver.FindElement(By.XPath("//label[contains(text(), 'Английский')]")).Click();
            var vacancies = driver.FindElements(By.CssSelector(".card.card-no-hover.card-sm"));
            Console.WriteLine(vacancies.Count);
        }
    }
}
