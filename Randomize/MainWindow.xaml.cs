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
using System.IO;
using System.Text.RegularExpressions;

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
