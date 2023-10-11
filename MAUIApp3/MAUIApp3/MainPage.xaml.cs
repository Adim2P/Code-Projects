namespace MAUIApp3
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private bool IsPhoneNumberValid(string input)
        {
            string validChars = "0123456789+";

            return input.All(c => validChars.Contains(c));
        }

        private void OnDial(object sender, EventArgs e)
        {
            try
            {
                string phoneNumber = PhoneNum.Text;

                if (IsPhoneNumberValid(phoneNumber))
                {
                    PhoneDialer.Open(phoneNumber);
                }
                else
                {
                    DisplayAlert("Invalid Input", "Please enter a valid phone number", "OK");
                }
            }
            catch (Exception error)
            {
                DisplayAlert("Error", error.Message, "OK");
            }
        }
    }
}