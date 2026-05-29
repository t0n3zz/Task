using System;
using System.Windows;
using System.Windows.Controls;

namespace Task
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int tipsPercent = 0;

            if (TipsFivePercentss.IsChecked == true)
            {
                tipsPercent = 5;
            }
            if (TipsTenPercents.IsChecked == true)
            {
                tipsPercent = 10;
            }
            if (TipsFifteenPercents.IsChecked == true) {
                tipsPercent = 15;
            }

            bool inputGuestsSuccess = int.TryParse(InputGuests.Text, out var guestsParsed);
            if (!inputGuestsSuccess || guestsParsed == 0)
            {
                MessageBox.Show("Количество гостей должно быть больше одного!");
                return;
            }

            bool sumParsedSuceess = double.TryParse(InputSum.Text, out var sumParsed);
            if (!sumParsedSuceess || sumParsed == 0)
            {
                MessageBox.Show("Сумма не должна быть меньше или равна нулю!");
                return;
            }

            double totalSum = Service.Calculator.CalculateTotalWithTips(sumParsed, tipsPercent);
            double tips = totalSum - sumParsed;
            Result.Text = Convert.ToString(totalSum);
            Result3.Text = Convert.ToString(tips);
            Result2.Text = Convert.ToString(guestsParsed);
        }

        private void InputSum_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void InputGuests_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TipsWithout_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TipsFivePercentss_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TipsTenPercents_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TipsFifteenPercents_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Result_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
