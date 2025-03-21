namespace MauiApp_Estudo
{
    public partial class MainPage : TabbedPage
    {
        string nameUser;

        public MainPage()
        {
            InitializeComponent();

            string endereco = @"<iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/x9jmkLaIiiE?si=rsdE3CZKvUsXjFOL"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"" referrerpolicy=""strict-origin-when-cross-origin"" allowfullscreen></iframe>";
            WVVideo.Source = new HtmlWebViewSource
            {
                Html = endereco
            };
        }

        

        private async void Btnclick_Clicked(object sender, EventArgs e)
        {
            nameUser = await DisplayPromptAsync("Nome", "Digite o nome");
            await DisplayAlert("Clicado", nameUser, "X");
        }
    }

}
