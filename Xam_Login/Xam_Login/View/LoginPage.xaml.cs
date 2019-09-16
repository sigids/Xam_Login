using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xam_Login.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xam_Login.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        LoginViewModel loginViewModel;
        public LoginPage()
        {
            loginViewModel = new LoginViewModel();
            InitializeComponent();
            BindingContext = loginViewModel;
        }

        //public LoginPage()
        //{
        //    InitializeComponent();
        //}

        //private void Loginbtn_Clicked(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(Password.Text) )
        //        DisplayAlert("Empty Values", "Please enter email & password", "OK");
        //    else
        //    {
        //        if (Email.Text == "sigids@gmx.com" && Password.Text == "123456")
        //        {
        //            DisplayAlert("Login Success", "", "OK");
        //        }
        //        else
        //            DisplayAlert("Login Fail", "Wrong user name or password", "OK");
        //    }
        //}
        


    }
}