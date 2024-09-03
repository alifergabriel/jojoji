using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace jojoji
{
    public partial class RoupasSuperiores2 : ContentPage
    {
        public RoupasSuperiores2()
        {
            InitializeComponent();

        }

        private void OnSelecionarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para lidar com a seleção
            // Por exemplo, exibir uma mensagem ou navegar para outra página
            DisplayAlert("Item Selecionado", "Você selecionou um item!", "OK");
        }
    }
}
