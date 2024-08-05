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
            this.BindingContext = App.getRando;
        }

        private void Button_Clicked_Proximo(object sender, EventArgs e)
        {

        }

       
    }

}
