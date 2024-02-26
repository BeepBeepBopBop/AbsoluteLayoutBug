using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Layouts;
using System.Diagnostics;

namespace DemoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            SetLayoutBounds(0.2f, 0.8f);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            SetLayoutBounds(0.5f, 0.5f);
        }

        private void SetLayoutBounds(float greenBoxRatio, float blueBoxRatio)
        {
            double availableHeight = Height - topGrid.Height;
            Rect greenRect = new Rect(0, 0, Width, availableHeight * greenBoxRatio);
            Rect blueRect = new Rect(0, greenRect.Height, Width, availableHeight * blueBoxRatio);

            absoluteLayout.SetLayoutBounds(greenBox, greenRect);
            absoluteLayout.SetLayoutBounds(blueBox, blueRect);
        }
    }
}
