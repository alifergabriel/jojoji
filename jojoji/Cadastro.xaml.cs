namespace jojoji
{
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Entrar"
            // Exemplo: Coletar os dados dos campos e enviar para um servidor
            string nome = entryNome.Text;
            string sobrenome = entrySobrenome.Text;
            string email = entryEmail.Text;
            string endereco = entryEndereco.Text;

            // ... sua lógica aqui
        }
    }
}