using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using YouTubeDemo.Views;

namespace Views.YouTubeDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new YouTubeViewPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
