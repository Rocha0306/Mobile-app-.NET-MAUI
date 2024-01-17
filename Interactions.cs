namespace Insistency
{

    public class Interactions : MainPage
    {

        public bool boolCaixaWin;
        public bool boolCaixaFailure;





        public void Verify(string CaixaTextBox = "")
        {
            if (CaixaTextBox.Any(char.IsLetter) || String.IsNullOrEmpty(CaixaTextBox))
            {

                boolCaixaWin = true;



            }

            else
            {
                boolCaixaWin = false;
            }











        }


        public void Verify2(string CaixaFailure = "")
        {
            if (CaixaFailure.Any(char.IsLetter) || String.IsNullOrEmpty(CaixaFailure))
            {

                boolCaixaFailure = true;



            }

            else
            {
                boolCaixaFailure = false;
            }


        }












    }
}

