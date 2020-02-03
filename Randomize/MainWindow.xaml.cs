using System.Windows;
using System.Windows.Controls;
using Randomizers;


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
            DeviceIDTxt.Text = string.Empty;
            string DeviceID = _deviceIdRandomizer.GetRandomEntity();
            DeviceIDTxt.Text += DeviceID;
        }
        private void Clear1(object sender, RoutedEventArgs e)
        {
            DeviceIDTxt.Text = DeviceIDTxt.Text = string.Empty; ;
        }

        private void RandomizeString(object sender, RoutedEventArgs e)
        {
            StringTxt.Text = string.Empty;
            StringTxt.Text += _stringRandomizer.GetRandomEntity(); 
        }

        private void StringClear(object sender, RoutedEventArgs e)
        {
            StringTxt.Text = string.Empty;
        }

        private void RandomizeNumber(object sender, RoutedEventArgs e)
        {
            NumberTxt.Text = string.Empty;
            NumberTxt.Text += _integerRandomizer.GetRandomEntity();
        }

        private void RandomizeDice(object sender, RoutedEventArgs e)
        {
            DiceTxt.Text = string.Empty;
            DiceTxt.Text += _diceRandomiser.GetRandomEntity();
        }

        private void RandomizeEmail(object sender, RoutedEventArgs e)
        {
            EmailTxt.Text = string.Empty;
            EmailTxt.Text += _emailRandomizer.GetRandomEntity();
        }

        private void RandomizeTel(object sender, RoutedEventArgs e)
            => RandomizeGeneral(_integerRandomizer, Teltxt);

        private void RandomizeGeneral(IRandomizer randomizer, TextBox textBox)
        {
            textBox.Text = string.Empty;
            textBox.Text += randomizer.GetRandomEntity();
        }
    }
}
