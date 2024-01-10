
using ProyectoFinalProto.Models;
using ProyectoFinalProto.ViewModels;

namespace ProyectoFinalProto;


public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel loginPageViewModel)
	{
		InitializeComponent();
		this.BindingContext = loginPageViewModel;
	}

  }
