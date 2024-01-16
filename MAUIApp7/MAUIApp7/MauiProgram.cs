using Microsoft.Extensions.Logging;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using MAUIApp7.Models;
using System.IO;
using System.ComponentModel.Design;

namespace MAUIApp7
{
    public class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            string dbPath = FileAccessHelper.GetLocalFilePath("class.db3");
            builder.Services.AddSingleton<StudentRepository>(s =>
            ActivatorUtilities.CreateInstance<StudentRepository>(s, dbPath));

            return builder.Build();
        }
    }
}
