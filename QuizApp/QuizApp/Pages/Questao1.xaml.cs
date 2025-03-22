namespace QuizApp.Pages;

public partial class Questao1 : ContentPage
{
	string nome;
	bool marcou = false;
	bool acerto = false;
    public Questao1()
	{
		InitializeComponent();
		
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();

		nome = await SecureStorage.Default.GetAsync("nome");
	}

	private void verificar(object sender, EventArgs e)
	{
		if (marcou)
		{
			marcou = false;
		}
		else
		{
            RadioButton opcao = sender as RadioButton;
			string valorOpcao = opcao.Value.ToString();

			if (valorOpcao.Contains("certo"))
			{
				acerto = true;
			}
			else
			{
				acerto = false;
			}

			marcou = true;
		}
	}

    private void BTNVerifica_Clicked(object sender, EventArgs e)
    {
		if (acerto)
		{
			DisplayAlert("Resultado", "Voce acertou!", "Ok");
		}
		else
		{
			DisplayAlert("Resutado", "Voce errou!", "Ok");
		}
    }
}