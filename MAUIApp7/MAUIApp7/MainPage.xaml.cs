using Microsoft.Maui.Controls;
using MAUIApp7.Models;
using System.IO;

//Co Author - Janrey Buitre

namespace MAUIApp7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnNewButtonClicked(object sender, EventArgs e)
        {
            statusMessage.Text = "";
            App.StudentRepo.AddNewStudent(newStudent.Text);
            statusMessage.Text = App.StudentRepo.StatusMessage;
        }

        void OnGetButtonClicked(object sender, EventArgs e) 
        {
            statusMessage.Text = "";
            List<Student> section = App.StudentRepo.GetSection();
            sectionList.ItemsSource = section;
        }

        // alisin mo lahat yan -Buitre
        // Di sinabi yan sa ano? Di tinanggal ka agad - Buitre
        // Mag salita ka na pre - Buitre

    }
}
