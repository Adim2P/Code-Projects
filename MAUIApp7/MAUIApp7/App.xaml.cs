using MAUIApp7.Models;
using Microsoft.Maui.Controls;
using System.IO;

namespace MAUIApp7
{
    public partial class App : Application
    {
        public static StudentRepository StudentRepo {  get; set; }
        
        public App(StudentRepository repo)
        {
            InitializeComponent();

            StudentRepo = repo;

            MainPage = new MainPage();
        }     
    }
}
