using System.Data.SqlTypes;

namespace choosefood
{
    public class ChoosingFood
    {

        List<string> ingredienser = new();

        public List<string> maträtt = new();

        bool GordonMad = true;



        public void Choose()
        {
            ingredienser.Add("potatis");
            ingredienser.Add("anchovies");
            ingredienser.Add("tomat");

            while (GordonMad == true && maträtt.Count <= 1)
            {


                Console.WriteLine(" välj en av tre ingredienser för att göra en maträttför gordon ramsey");
                Console.WriteLine("dina val är potatis, tomat och anchovies");
                string svar = Console.ReadLine().ToLower();

                foreach (var val in ingredienser)
                {
                    if (svar == val)
                    {
                        maträtt.Add(svar);

                    }
                }

            }

        }








    }

    // gör en lista med alla svar
    // gör foreach loop som kollar i fall svaret är någon av svaren i listan.

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

    



//Skapa en lista för ingredienserna spelaren har 
//Kolla vilka ingredienser dem har i listan
//Skapa en ny instans av den mat som matchar