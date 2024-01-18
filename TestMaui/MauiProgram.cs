using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace TestMaui
{
    public static class MauiProgram
    {
        //ServiceProvider sp;
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


            return builder.Build();
        }
        /*
        private static void AddView<TView, TViewModel>(this IServiceCollection services) 
            where TView : ContentPage, new()
        {
            services.AddSingleton<TView>(serviceProvider => new TView()
            {
                BindingContext = serviceProvider.GetRequiredService<TViewModel>()
            }
            );
        }
        */
    }


}