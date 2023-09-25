using Microsoft.Maui.Controls;

namespace MAUIApp2
{
    public partial class MainPage : ContentPage
    {

        private bool isExpectation1 = true;
        private bool isExpectation2 = true;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnImageClicked(object sender, EventArgs e)
        {
            ImageButton imgButton = (ImageButton)sender;

            if (imgButton == imgButton1)
            {
                isExpectation1 = !isExpectation1;

                if (isExpectation1)
                {
                    imgButton.Source = "expectation1.png";
                    label1.Text = "Expectation";
                }
                else
                {
                    imgButton.Source = "reality1.png";
                    label1.Text = "Reality";
                }
            }
            else if (imgButton == imgButton2)
            {
                isExpectation2 = !isExpectation2;

                if (isExpectation2)
                {
                    imgButton.Source = "expectation2.png";
                    label2.Text = "Expectation";
                }
                else
                {
                    imgButton.Source = "reality2.png";
                    label2.Text = "Reality";
                }
            }
        }
        
    }
}