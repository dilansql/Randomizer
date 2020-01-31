using System.Windows;
using Dilan.Randomizers;
using Randomize.Randomize;

namespace Randomize
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IRandomizer _deviceIdRandomizer = new DeviceIDRandomizer();
        private IRandomizer _diceRandomiser = new DiceRandomizer();
        private IRandomizer _emailRandomizer = new EmailRandomizer();
        private IRandomizer _integerRandomizer = new IntegerRandomizer();
        private IRandomizer _stringRandomizer = new StringRandomizer();

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Randomizer Method
        
        #endregion Randomizer Method
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Txt.Text = " ";
            string DeviceID = _deviceIdRandomizer.GetRandomEntity();
            Txt.Text += DeviceID;
        }
        private void Clear1(object sender, RoutedEventArgs e)
        {
            Txt.Text = " ";
        }
    }
}
