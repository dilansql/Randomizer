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
        private IRandomizer _diceRandomizer = new DiceRandomizer();
        private IRandomizer _emailRandomizer = new EmailRandomizer();
        private IRandomizer _integerRandomizer = new IntegerRandomizer();
        private IRandomizer _stringRandomizer = new StringRandomizer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RandomizeGeneral(IRandomizer randomizer, TextBox textBox)
        {
            textBox.Text = string.Empty;
            textBox.Text += randomizer.GetRandomEntity();
        }

        private void ClearGeneral(TextBox textBox)
            => textBox.Text = string.Empty;

        #region Randomization Methods

        private void Button_Click(object sender, RoutedEventArgs e)
            => RandomizeGeneral(_deviceIdRandomizer, DeviceIDTxt);

        private void RandomizeNumber(object sender, RoutedEventArgs e)
            => RandomizeGeneral(_integerRandomizer, NumberTxt);

        private void RandomizeDice(object sender, RoutedEventArgs e)
            => RandomizeGeneral(_diceRandomizer, DiceTxt);

        private void RandomizeEmail(object sender, RoutedEventArgs e)
        {
            EmailTxt.Text = string.Empty;
            EmailTxt.Text += _emailRandomizer.GetRandomEntity();
        }

        private void RandomizeTel(object sender, RoutedEventArgs e)
            => RandomizeGeneral(_integerRandomizer, Teltxt);

        private void RandomizeString(object sender, RoutedEventArgs e)
            => RandomizeGeneral(_stringRandomizer, StringTxt);

        #endregion Randomization Methods

        private void Clear1(object sender, RoutedEventArgs e)
            => ClearGeneral(DeviceIDTxt);

        private void StringClear(object sender, RoutedEventArgs e)
            => ClearGeneral(StringTxt);
    }
}
