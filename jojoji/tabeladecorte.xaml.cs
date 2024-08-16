
using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace jojoji.tabeladecortes.Views
{
    public partial class TabelaDeCortesPage : ContentPage
    {
        public TabelaDeCortesPage()
        {
            InitializeComponent();

            // Lista de tipos de corte
            TiposDeCorte = new List<string>
            {
                "Corte em Viés",
                "Corte a Fio",
                "Tesoura de Pinking",
                "Corte com Overlock",
                "Corte com Interlock",
                "Corte com Friso",
                "Corte com Pesponto",
                "Corte com Bainha Invisível"
            };
        }

        public List<string> TiposDeCorte { get; set; }
    }
}
