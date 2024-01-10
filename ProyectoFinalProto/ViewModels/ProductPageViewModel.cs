using Microsoft.Toolkit.Mvvm.Input;
using ProyectoFinalProto.Models;
using ProyectoFinalProto.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProto.ViewModels
{
    public partial class ProductPageViewModel : BaseProductViewModel
    {
        public ObservableCollection<ProductInfo> productList { get; }

        public ProductPageViewModel(INavigation navegation)
        {
            productList = new ObservableCollection<ProductInfo>();
            Navegation = navegation;
        }

       
        [ICommand]
        private async void OnAddProduct()
        {
            await Shell.Current.GoToAsync(nameof(AddProductPage));
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        [ICommand]
        private async Task LoadProduct()
        {
            IsBusy = true;

            try
            {
                productList.Clear();
                var prodList = await App.ProductService.GetProductAsync();
                foreach (var item in prodList) 
                {
                    productList.Add(item);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally 
            { 
                IsBusy = false; 
            }

        }

        private async void ProductTappedDelete(ProductInfo prodInfo)
        {
            if (prodInfo == null)
                return;
            await App.ProductService.DeleteProductAsync(prodInfo.ProductId);
            await LoadProduct();
            OnAppearing();
        }
        [ICommand]

        private async void ProductTappedEdit(ProductInfo prodInfo)
        {
             if (prodInfo == null)
                 return;
             await Navegation.PushAsync(new AddProductPage(prodInfo));

        }
        
    }
}
