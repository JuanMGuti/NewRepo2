using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using ProyectoFinalProto.Models;
using ProyectoFinalProto.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProto.ViewModels
{
    public partial class BaseProductViewModel :BaseViewModel
    {
        [ObservableProperty]
        private ProductInfo _productInfo;

         public INavigation Navegation { get; set; }

        [ICommand]
        public async void OnCancelProduct()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
