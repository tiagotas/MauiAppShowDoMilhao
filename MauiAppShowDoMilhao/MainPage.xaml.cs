using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class MainPage : ContentPage
    {
        bool resposta_correta = false;

        public MainPage()
        {
            InitializeComponent();
        }

        

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = App.getRandomPerguntaFacil();
        }

        private void Button_Clicked_Proxima(object sender, EventArgs e)
        {
            
            // https://stackoverflow.com/questions/74127902/2-radio-button-group-do-not-work-in-maui-using-community-toolkit-mvvm

            /*if (resposta_correta)
            {
                this.BindingContext = App.getRandomPerguntaFacil();
                DisplayAlert("Acertou!", "Certa Resposta!", "Próxima");
            } else
            {
                DisplayAlert("Errou!", "Certa Errada!", "Tentar Novamente");
            } */          
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton selecionado = (RadioButton)sender;
            Alternativa resposta = selecionado.BindingContext as Alternativa;

            //resposta_correta = e.Value;

            DisplayAlert("Respondeu:", resposta?.Correta.ToString(), "OK");
        }
        
    }
}
