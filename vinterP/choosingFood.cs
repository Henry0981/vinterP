namespace choosefood
{
    public class ChoosingFood
    {

        List<string> ingredienser = new();


        public void Choose()
        {
            ingredienser.Add("tomat");
            ingredienser.Add("potatis");
            ingredienser.Add("anchovies");

            // Loop som skriver ut vilka som finns
            // Readline som låder användaren välja en av dem
            // Lägg till den man valde till spelarens lista
            // Gör det igen
            // (Lista med maträtter)
            // Gå igenom listan med maträtter
            //   För varje maträtt, kolla om de ingredienser som behövs är i spelarens lista
            //   Om de är det, lägg till i spelarens lista med maträtter
            // Skriv ut listan med maträtter
            // Låt spelaren välja en
        }

    }
}


//Skapa en lista för ingredienserna spelaren har 
//Kolla vilka ingredienser dem har i listan
//Skapa en ny instans av den mat som matchar