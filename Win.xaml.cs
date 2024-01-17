namespace Insistency;

public partial class Win : ContentPage
{
    public Win()
    {
        InitializeComponent();
    }

    private async void BotaoMaisMotivacao(object sender, EventArgs e)
    {
        var result = await Launcher.TryOpenAsync(uri: "https://drive.google.com/drive/folders/1inDggGg3qdJRyic-zYRcsVkwY9R9fajJ?usp=sharing");
    }
}