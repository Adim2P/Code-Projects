namespace MAUIApp4
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        // Vertical Button Handlers
        private void OnVerticalStart(object sender, EventArgs e)
        {
            target.VerticalOptions = LayoutOptions.Start;
        }

        private void OnVerticalCenter(object sender, EventArgs e)
        {
            target.VerticalOptions = LayoutOptions.Center;
        }

        private void OnVerticalEnd(object sender, EventArgs e)
        {
            target.VerticalOptions = LayoutOptions.End;
        }

        // Horizontal Button Handlers
        private void OnHorizontalStart(object sender, EventArgs e)
        {
            target.HorizontalOptions = LayoutOptions.Start;
        }

        private void OnHorizontalCenter(object sender, EventArgs e)
        {
            target.HorizontalOptions = LayoutOptions.Center;
        }

        private void OnHorizontalEnd(object sender, EventArgs e)
        {
            target.HorizontalOptions = LayoutOptions.End;
        }
    }
} 