using System;
using System.Text;
using System.Windows;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Randomize
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var configuration = 
                new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .AddJsonFile("appsettings2.json")
                    .Build();


            var serviceProvider =
                new ServiceCollection()
                .AddServices()
                .AddRandomiserOptions(configuration)
                .BuildServiceProvider();
           
            //var value = serviceProvider.GetRequiredService<IOptions<RandomizeOptions>>();
            //var newValue = value.Value;

            var randomzer = serviceProvider.GetRequiredService<IRandomzer>();
        }
        #region Randomizer Method
        public static string GenerateDeviceId()
        {
            var guid = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 16);
            var count = 0;
            var eui64 = new StringBuilder();
            foreach (var character in guid)
            {
                if (count % 2 == 0 && count > 0)
                    eui64.Append($"-{character}");
                else
                    eui64.Append(character);

                count++;
            }

            return eui64.ToString().ToUpper();
        }
        #endregion Randomizer Method
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Txt.Text = " ";
            string DeviceID = GenerateDeviceId();
            Txt.Text += DeviceID;
        }
        private void Clear1(object sender, RoutedEventArgs e)
        {
            Txt.Text = " ";
        }
    }
}
