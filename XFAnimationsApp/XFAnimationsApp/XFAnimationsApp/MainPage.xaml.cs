using System;
using Xamarin.Forms;

namespace XFAnimationsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void TranslateButtonOnClicked(object sender, EventArgs e)
        {
            await SampleImage.TranslateTo(100, 0, 1000, Easing.CubicInOut);
            await SampleImage.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            await SampleImage.TranslateTo(-100, 0, 1000, Easing.CubicInOut);
            await SampleImage.TranslateTo(0, 0, 1000, Easing.CubicInOut);
        }

        private async void ScaleButtonOnClicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.UWP)
            {
                await DisplayAlert("Error", "Currently this function isn't supported on UWP.", "Ok");
                return;
            }

            await SampleImage.ScaleTo(2, 1000, Easing.BounceOut);
            await SampleImage.ScaleTo(1, 1000, Easing.BounceOut);
        }

        private async void RotateButtonOnClicked(object sender, EventArgs e)
        {
            await SampleImage.RotateTo(180, 1000, Easing.SpringOut);
            await SampleImage.RotateTo(0, 1000, Easing.SpringOut);
        }

        private async void FadeButtonOnClicked(object sender, EventArgs e)
        {
            await SampleImage.FadeTo(0, 1000, Easing.Linear);
            await SampleImage.FadeTo(1, 1000, Easing.Linear);
        }
    }
}
