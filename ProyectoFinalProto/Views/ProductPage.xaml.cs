using Microsoft.Toolkit.Mvvm.Input;
using ProyectoFinalProto.ViewModels;

namespace ProyectoFinalProto.Views;

public partial class ProductPage : ContentPage
{
	ProductPageViewModel productPageViewModel;
	public ProductPage()
	{
        InitializeComponent();
        this.BindingContext = productPageViewModel = new ProductPageViewModel(Navigation);
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        productPageViewModel.OnAppearing();
    }
}