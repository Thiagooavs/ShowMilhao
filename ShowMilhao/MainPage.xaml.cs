namespace ShowMilhao
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }
        

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.BindingContext =  App.getRendomPerguntaFacil();
        }

        private async void Button_Clicked_Proximo(object sender, EventArgs e)
        {
            bool acertou = false;
            string resp = "";
            bool valor;

            if (alt0.IsChecked)
            {
                if((bool) alt0.Value)
                {
                    acertou = true;
                    resp = alt0.Content.ToString();
                    
                }
            }

            if (alt1.IsChecked)
            {
                if ((bool)alt1.Value)
                {
                    acertou = true;
                    resp = alt1.Content.ToString();

                }
            }

            if (alt2.IsChecked)
            {
                if ((bool)alt2.Value)
                {
                    acertou = true;
                    resp = alt2.Content.ToString();

                }
            }

            if (alt3.IsChecked)
            {
                if ((bool)alt3.Value)
                {
                    acertou = true;
                    resp = alt3.Content.ToString();

                }
            }

            if (acertou)
            {
                await DisplayAlert("ACERTOU !!", resp, "ok");
                this.BindingContext = App.getRendomPerguntaFacil;
            }
            else
            {
                DisplayAlert("Você errou", "Você perdeu", "ok");
                
            }
        }

       
    }

}
