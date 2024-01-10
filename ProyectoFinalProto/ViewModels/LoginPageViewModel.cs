using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Newtonsoft.Json;
using ProyectoFinalProto.Models;
using ProyectoFinalProto.Services;
using ProyectoFinalProto.UserControl;
using ProyectoFinalProto.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProto.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _userName;

        [ObservableProperty]
        private string _password;

        readonly ILoginRepository loginRepository = new LoginService();

        [ICommand]

        public async void Login()
        {
            if(!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password))
            {
                UserInfo userInfo = await loginRepository.Login(UserName, Password);

                if (Preferences.ContainsKey(nameof(App.UserAppTheme)))
                {
                    Preferences.Remove(nameof(App.UserInfo));
                }

                string userDetails=JsonConvert.SerializeObject(userInfo);
                Preferences.Set(nameof(App.UserInfo),userDetails);
                App.UserInfo = userInfo;

                AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();

                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
        }
    }
}
