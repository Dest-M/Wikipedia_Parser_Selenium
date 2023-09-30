using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OpenQA.Selenium;
using WikiSearch.Logic;
using OpenQA.Selenium.Edge;

namespace Wikipedia_Parser_Selenium
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            RunSearch _run = new RunSearch();
            if (SearchBox.Text == "")
            {
                MessageBox.Show("Search box is empty.\n Please enter what you want to search for.");
                return;
            }
            string searchVal = SearchBox.Text;
            EdgeOptions edgeOptions = new EdgeOptions();

            edgeOptions.AddArgument("--headless");
            edgeOptions.AddArgument("disable-gpu");
            IWebDriver driver = new OpenQA.Selenium.Edge.EdgeDriver();

            driver.Url = @"https://en.wikipedia.org/";

            ResuleBox.Text = _run._run(driver, searchVal);
            driver.Close();




        }
    }
}