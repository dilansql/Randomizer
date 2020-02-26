using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Text.RegularExpressions;
using Randomizers;
using System.Windows.Input;

namespace Randomize
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Interface Initializations
        private IRandomizer _deviceIdRandomizer = new DeviceIDRandomizer();
        private IRandomizer _diceRandomizer = new DiceRandomizer();
        private IRandomizer _emailRandomizer = new EmailRandomizer();
        private IRandomizer _integerRandomizer = new IntegerRandomizer();
        private IGeneralRandomizer _numberRandomizer = new IntegerRandomizer();
        private IGeneralRandomizer _stringRandomizer = new StringRandomizer();
        #endregion Interface Initializations

        Regex Regex { get; set; } = new Regex("[^0-9]+");

        public MainWindow()
        {
            SplashScreen splash = new SplashScreen("flower_small.ico");
            splash.Show(true);
            Thread.Sleep(1500);
            InitializeComponent();
        }

        private void NumberValidationTextBoz(object sender, TextCompositionEventArgs e)
        {
            e.Handled = Regex.IsMatch(e.Text);
        }

        private void RandomizeGeneral(IRandomizer randomizer, TextBox textBox)
        {
            textBox.Text = string.Empty;
            textBox.Text += randomizer.GetRandomEntity();
        }

        private void RandomizeGeneral(string text, TextBox textBox)
        {
            textBox.Text = string.Empty;
            textBox.Text += text;
        }

        private void RandomizeGeneral(IGeneralRandomizer randomizer, TextBox textBox, string value)
        {
            textBox.Text = string.Empty;
            textBox.Text += randomizer.GetRandomEntity(int.Parse(value));
        }

        private void ClearGeneral(TextBox textBox)
            => textBox.Text = string.Empty;

        #region Randomization Methods

        private void Button_Click(object sender, RoutedEventArgs e)
            => RandomizeGeneral(_deviceIdRandomizer, DeviceIDTxt);

        private void RandomizeNumber(object sender, RoutedEventArgs e)
            => RandomizeGeneral(_numberRandomizer, NumberTxt, NumberValue.Text);

        private void RandomizeDice(object sender, RoutedEventArgs e)
            => RandomizeGeneral(_diceRandomizer, DiceTxt);

        private void RandomizeEmail(object sender, RoutedEventArgs e)
            => RandomizeGeneral(_emailRandomizer, EmailTxt);

        private void RandomizeTel(object sender, RoutedEventArgs e)
            => RandomizeGeneral(_integerRandomizer, Teltxt);

        private void RandomizeString(object sender, RoutedEventArgs e)
            => RandomizeGeneral(_stringRandomizer, StringTxt, StringValue.Text);

        private void PortButton_Click(object sender, RoutedEventArgs e)
            =>  RandomizeGeneral(PortNumber.FreeTcpPort(), Porttxt);

        #endregion Randomization Methods


        #region Clear Methods

        private void Clear1(object sender, RoutedEventArgs e)
            => ClearGeneral(DeviceIDTxt);

        private void StringClear(object sender, RoutedEventArgs e)
            => ClearGeneral(StringTxt);

        private void NumberClear(object sender, RoutedEventArgs e)
            => ClearGeneral(NumberTxt);

        private void DiceClear(object sender, RoutedEventArgs e)
            => ClearGeneral(DiceTxt);

        private void EmailClear(object sender, RoutedEventArgs e)
            => ClearGeneral(EmailTxt);

        private void TelClear(object sender, RoutedEventArgs e)
            => ClearGeneral(Teltxt);

        private void ClearPort_Click(object sender, RoutedEventArgs e)
            => ClearGeneral(Porttxt);

        #endregion Clear Methods
        /*
        private void TextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            e.Handled = Regex.IsMatch(e.Text);
        }*/
    }
}
