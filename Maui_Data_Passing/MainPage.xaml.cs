using System;
using Microsoft.Maui.Controls;

namespace Maui_Data_Passing
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAdditionClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstEntry.Text) || string.IsNullOrWhiteSpace(SecondEntry.Text))
            {
                MessageLabel.Text = "Please enter values for both fields to get the sum";
                return;
            }

            if (!double.TryParse(FirstEntry.Text, out var a) || !double.TryParse(SecondEntry.Text, out var b))
            {
                MessageLabel.Text = "Please enter valid numbers";
                return;
            }

            var page = new ResultPage(a, b, true);
            await Navigation.PushAsync(page);
        }

        private async void OnSubtractionClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstEntry.Text) || string.IsNullOrWhiteSpace(SecondEntry.Text))
            {
                MessageLabel.Text = "Please enter values for both fields to get the difference";
                return;
            }

            if (!double.TryParse(FirstEntry.Text, out var a) || !double.TryParse(SecondEntry.Text, out var b))
            {
                MessageLabel.Text = "Please enter valid numbers";
                return;
            }

            var page = new ResultPage(a, b, false);
            await Navigation.PushAsync(page);
        }
    }
}

