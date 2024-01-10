using Microsoft.Toolkit.Mvvm.Input;
using ProyectoFinalProto.Models;

namespace ProyectoFinalProto.ViewModels
{
    public partial class AddProductPageViewModel : BaseProductViewModel
    {
        public AddProductPageViewModel()
        {
            ProductInfo = new ProductInfo();
        }

        [ICommand]
        public async void SaveProduct()
        {
            var product = ProductInfo;
            await App.ProductService.AddUpdateProductAsync(product);

            await Shell.Current.GoToAsync("..");
        }
    }
}
