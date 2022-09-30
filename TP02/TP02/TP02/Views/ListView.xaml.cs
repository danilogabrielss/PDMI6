using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView : ContentPage
    {
        public ListView()
        {
            InitializeComponent();
        }

        private async void VerProduto(object sender, EventArgs e)
        {
            await DisplayAlert("Produto Inserido!", "Produto \nID: " + ID.Text +
                "\nDescricao: " + Descricao.Text +
                "\nCategoria: " + Categoria.Text +
                "\nQuantidade: "+ Quantidade.Text+
                "\nPreco: " + Preco.Text, "OK");
        }
    }
}