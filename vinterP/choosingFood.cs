using System.Data.SqlTypes;

namespace choosefood
{
    public class ChoosingFood
    {

        List<string> ingredienser = new();

        public List<string> maträtt = new();
        List<Food> allamaträtter = new()
        {
            new anchoviesTomat(),
            new PotatisAnchovies(),
            new potatisTomat()
        };

        Food gjordMaträtt;

        bool GordonMad = true;

        public void gåIgenomMat()
        {
            for (int i = 0; i < allamaträtter.Count; i++)
            {
                string ingrediens1 = "";
                string ingrediens2 = "";

                ingrediens1 = allamaträtter[i].neededIngridiences[0];
                ingrediens2 = allamaträtter[i].neededIngridiences[1];


                if (ingrediens1 == maträtt[0] && ingrediens2 == maträtt[1])
                {
                    gjordMaträtt = allamaträtter[i];
                    Console.WriteLine(gjordMaträtt.name);
                    Console.ReadLine();
                }
                else if (ingrediens1 == maträtt[1] && ingrediens2 == maträtt[0])
                {
                    gjordMaträtt = allamaträtter[i];
                    Console.WriteLine(gjordMaträtt.name);
                    Console.ReadLine();
                }

            }
            //Kolla om första ingrediensen matchar med båda - kolla om andra ingrediensen matchar med den som den första inte matcha med
            //Första rätt - kolla om andra rätt - skapa den maträtt som vi är på
        }


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