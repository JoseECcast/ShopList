using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Gui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopList.Gui.ViewModels
{
    internal partial class ItemDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _nombre = string.Empty;

        [ObservableProperty]
        private int _cantidad = 1;

        [RelayCommand]
        public void Guardad()
        {
            var item = new ShopListItem()
            {
                Nombre = this.Nombre,
                Cantidad = this.Cantidad,
                Comprado = false,
            };

            Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        public async Task Cancelar()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
