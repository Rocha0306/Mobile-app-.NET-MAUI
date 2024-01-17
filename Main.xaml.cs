namespace Insistency
{
    public partial class MainPage : ContentPage
    {

        public async void Eventos()
        {

            int CaixaW = Convert.ToInt32(CaixaWin.Text);
            int CaixaF = Convert.ToInt32(CaixaFailure.Text);
            if (CaixaW < CaixaF)
            {
                await Navigation.PushAsync(new Failure());
            }

            else
            {
                await Navigation.PushAsync(new Win());
            }



        }
        public void Mensagem() // Mensagem ao usuario caso ele não corresponda as condiçoes 
        {
            Interactions inter = new Interactions();
            string Caixa = CaixaWin.Text;
            inter.Verify(Caixa);
            if (inter.boolCaixaWin == true)
            {
                DisplayAlert("Alerta", "Letras não são permitidas nesse campo", "Ok");
            }



        }

        public void Mensagem(string Caixa)
        {
            Interactions inter = new Interactions();
            Caixa = CaixaFailure.Text;
            inter.Verify2(Caixa);
            if (inter.boolCaixaFailure == true)
            {
                DisplayAlert("Alerta", "Letras não são permitidas nesse campo", "Ok");
            }




        }





        public MainPage()  //Construtor 
        {
            InitializeComponent();


            /* Alteração não mesclada do projeto 'Insistency (net7.0-ios)'
            Antes:
                    }




                    private void ValidarCaixaW(object sender, EventArgs e) { // Metodo para verificar se o usuario atendeu as condiçoes 
            Após:
                    }




                    private void ValidarCaixaW(object sender, EventArgs e) { // Metodo para verificar se o usuario atendeu as condiçoes 
            */

            /* Alteração não mesclada do projeto 'Insistency (net7.0-windows10.0.19041.0)'
            Antes:
                    }




                    private void ValidarCaixaW(object sender, EventArgs e) { // Metodo para verificar se o usuario atendeu as condiçoes 
            Após:
                    }




                    private void ValidarCaixaW(object sender, EventArgs e) { // Metodo para verificar se o usuario atendeu as condiçoes 
            */

            /* Alteração não mesclada do projeto 'Insistency (net7.0-maccatalyst)'
            Antes:
                    }




                    private void ValidarCaixaW(object sender, EventArgs e) { // Metodo para verificar se o usuario atendeu as condiçoes 
            Após:
                    }




                    private void ValidarCaixaW(object sender, EventArgs e) { // Metodo para verificar se o usuario atendeu as condiçoes 
            */
        }




        private void ValidarCaixaW(object sender, EventArgs e)
        { // Metodo para verificar se o usuario atendeu as condiçoes 
            Interactions inter = new Interactions();
            string Caixa = CaixaWin.Text;
            inter.Verify(Caixa);
            Mensagem();















        }



        private void ValidarCaixaFailure(object sender, EventArgs e)
        {
            Interactions inter = new Interactions();
            string Caixa = CaixaFailure.Text;
            inter.Verify2(Caixa);
            Mensagem(Caixa);


        }



        private void ClickBotao(object sender, EventArgs e)
        {
            Interactions inter = new Interactions();
            string Caixa1 = CaixaWin.Text;
            inter.Verify(Caixa1);
            string Caixa = CaixaFailure.Text;
            inter.Verify2(Caixa);
            if (inter.boolCaixaFailure == true || inter.boolCaixaWin == true)
            {
                DisplayAlert("ATENÇÃO", "Existe Letras e Campos vazios, por favor mude isso", "Ok");
            }




            else
            {
                Eventos();

            }












        }

    }
}