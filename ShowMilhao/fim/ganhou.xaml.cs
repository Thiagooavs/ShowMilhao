namespace ShowMilhao.fim;

public partial class Ganhou : ContentPage
{
	public Ganhou()
	{
		InitializeComponent();
	}

    private void comeco_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

  
}