namespace Insistency;

public partial class Failure : ContentPage
{
    public Failure()
    {
        InitializeComponent();
    }

    private async void BotaoSemMotivacao(object sender, EventArgs e)
    {
        var result = await Launcher.TryOpenAsync(uri: "https://youtu.be/Pvg6TUK5u_w?si=z9-pAucrw_iB-Uv2");

    }


    private async void BotaoSemVontade(object sender, EventArgs e)
    {
        var result = await Launcher.TryOpenAsync(uri: "https://youtu.be/EpbVKotl0iw?si=KojUQV08ixbZp-Ss");
    }


    private async void BotaoUltimaChance(object sender, EventArgs e)
    {
        var result = await Launcher.TryOpenAsync(uri: "https://youtu.be/TZm2fpECa8g?si=MkJU4INbOTYt5ukA");
    }



}