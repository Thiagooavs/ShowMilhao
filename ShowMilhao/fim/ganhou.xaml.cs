using Plugin.Maui.Audio;

namespace ShowMilhao.fim;

public partial class Ganhou : ContentPage
{
	public Ganhou()
	{
		InitializeComponent();

        AudioManager.Current.CreatePlayer(FileSystem.OpenAppPackageFileAsync("terminou.wav").Result).Play();
    }

    private void comeco_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

  
}