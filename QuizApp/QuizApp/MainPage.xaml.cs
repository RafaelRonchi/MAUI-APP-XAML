using QuizApp.Pages;

namespace QuizApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async void BtnIniciar_Clicked(object sender, EventArgs e)
        {
            string pergunta = await DisplayPromptAsync(
                "Pergunta",
                "Qual o seu nome?", 
                "Ok", 
                "Cancelar");

            await SecureStorage.Default.SetAsync("nome", pergunta);

            await Navigation.PushAsync(new Questao1());
        }
    }

}
