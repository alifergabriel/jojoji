using System;
using Microsoft.Maui.Controls;

namespace jojoji.Views
{
    public partial class  metedoentrega: ContentPage
    {
        public metedoentrega()
        {
            InitializeComponent();
        }

        private void EntregaPadrao_Clicked(object sender, EventArgs e)
        {
            // Lógica para processar a escolha da entrega padrão
            DisplayAlert("Selecionado", "Você escolheu a entrega padrão.", "OK");
        }

        // ... outros métodos para as outras opções de entrega
    }
}
