using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xam_Login.View;
using Xamarin.Forms;

namespace Xam_Login.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public LoginViewModel()
        {

        }
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public Command LoginCommand
        {
            get
            {
                return new Command(Login);
            }
        }

        private void Login()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
                App.Current.MainPage.DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
            else
            {
                if (Email == "sigids@gmx.com" && Password == "123456")
                {
                    App.Current.MainPage.DisplayAlert("Login Success", "", "Ok");
                    App.Current.MainPage.Navigation.PushAsync(new WelcomePage());
                }
                else
                    App.Current.MainPage.DisplayAlert("Login Fail", "Please enter correct Email and Password", "OK");
            }
        }

    }
}
