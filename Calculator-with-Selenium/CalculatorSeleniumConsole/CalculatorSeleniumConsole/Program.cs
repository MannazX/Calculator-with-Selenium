// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

Console.WriteLine("Hello, Calculator!");

IWebDriver driver = new ChromeDriver();

driver.Navigate().GoToUrl(@"http://127.0.0.1:5500/index.html");

Console.WriteLine("Driver Url: " + driver.Url);

IWebElement number1 = driver.FindElement(By.Id("number1"));
IWebElement number2 = driver.FindElement(By.Id("number2"));

Console.WriteLine("Type in the first number:");
string input1 = Console.ReadLine();
Console.WriteLine("Type in the second number:");
string input2 = Console.ReadLine();

number1.SendKeys(input1);
number2.SendKeys(input2);

IWebElement resButtion = driver.FindElement(By.Id("equals"));
Console.WriteLine("Compute the sum of the input numbers");
Console.ReadKey();

int result = Convert.ToInt32(input1) + Convert.ToInt32(input2);
resButtion.Click();
Console.WriteLine("Result is: " + result);

Console.WriteLine("Terminate Calculator Web-Page");
Console.ReadKey();
driver.Quit();

