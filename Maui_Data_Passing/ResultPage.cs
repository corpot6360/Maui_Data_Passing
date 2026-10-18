using System;
using Microsoft.Maui.Controls;

namespace Maui_Data_Passing
{
    public class ResultPage : ContentPage
    {
        public ResultPage(double first, double second, bool isAddition)
        {
            Title = "Result";

            var header = new Label { Text = "Corey Potts", FontSize = 24, HorizontalOptions = LayoutOptions.Center };
            var entered = new Label { Text = $"The numbers entered are {first} and {second}." };
            var result = new Label();

            if (isAddition)
                result.Text = $"The sum of the numbers is {first + second}";
            else
                result.Text = $"The difference of the numbers is {first - second}";

            var back = new Button { Text = "Go Back", HorizontalOptions = LayoutOptions.Center };
            back.Clicked += async (s, e) => await Navigation.PopAsync();

            Content = new ScrollView
            {
                Content = new VerticalStackLayout
                {
                    Padding = 20,
                    Spacing = 12,
                    Children = { header, entered, result, back }
                }
            };
        }
    }
}
