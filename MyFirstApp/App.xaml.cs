﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyFirstApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MyFirstAppPage();
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
