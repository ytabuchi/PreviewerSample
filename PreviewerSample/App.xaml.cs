﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PreviewerSample
{
    public static class ViewModelLocator
    {
        static ViewModels.PersonsViewModel personsVM;
        public static ViewModels.PersonsViewModel PersonsViewModel
        => personsVM ?? (personsVM = new ViewModels.PersonsViewModel());
    }

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var nav = new NavigationPage(new Views.PreviewPage());
            nav.BarBackgroundColor = Color.FromHex("#75C465");
            nav.BarTextColor = Color.White;
            MainPage = nav;
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

