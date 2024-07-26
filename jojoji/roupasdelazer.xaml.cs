using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Jojoji
{
    public partial class RoupasDeLazer : ContentPage
    {
        public RoupasDeLazer()
        {
            InitializeComponent();

            // Exemplo de evento para o botão "Selecionar"
            SelecionarButton.Clicked += OnSelecionarButtonClicked;
        }

        private void OnSelecionarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para lidar com a seleção
            // Por exemplo, exibir uma mensagem ou navegar para outra página
            DisplayAlert("Item Selecionado", "Você selecionou um item!", "OK");
        }
    }
}
