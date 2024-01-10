using ProyectoFinalProto.Models;
using ProyectoFinalProto.ViewModels;

namespace ProyectoFinalProto.Views;

public partial class AddProductPage : ContentPage
{
    public ProductInfo ProductInfo { get; set; }
    public AddProductPage()
    {
        InitializeComponent();
        this.BindingContext = new AddProductPageViewModel();
    }
    public AddProductPage(ProductInfo productInfo)
    {
        InitializeComponent();
        this.BindingContext = new AddProductPageViewModel();

        if(productInfo != null )
        {
            ((AddProductPageViewModel)BindingContext).ProductInfo = productInfo;
        }

    }
}