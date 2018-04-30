using System;

namespace Ryggsäcken1
{
    class Program
    {
        static void Main(string[] args)
        {
            //While loop
            bool isRunning = true;
            // Deklarera värde för inmatad textsträng
            string chosenObject = String.Empty;
            while (isRunning)
            {
                
                // Välkommen till ryggsäcken!
                Console.WriteLine("\n\tVälkommen till ryggsäcken!");
                /* [1] Lägg till ett föremål. Spara ett föremål i ryggsäcken, 
               användaren ska kunna mata in en sträng under menyval 1, 
               detta ska sparas. Prova gärna att använda += operatorn för din sträng.*/
                Console.WriteLine("\t[1]Lägg till ett föremål");
                // [2] Skriv ut innehållet. Den inmatade strängen ska kunnas skrivas ut i menyval 2
                Console.WriteLine("\t[2]Skriv ut innehållet");
                // [3] Rensa innehållet. När användaren väljer menyval 3 ska strängens värde rensas eller nollställas
                Console.WriteLine("\t[3]Rensa innehållet");
                // [4] Avsluta. Menyval 4 ska avsluta menyloopen.
                Console.WriteLine("\t[4]Avsluta");
                // Välj:
                Console.Write("\tVälj: ");

                int menueSelection = Convert.ToInt32(Console.ReadLine());
                // Lägg in en variabel i lämplig datatyp för menyval
                // Använda menyvalen med if eller switch
                switch (menueSelection)
                {
                    default:
                        break;
                    case 1:
                        Console.WriteLine("Lägg till ett föremål: ");
                        chosenObject += "" + Console.ReadLine();
                        // Läs in sträng från användaren som sedan sparas. += operatorn
                        break;
                    case 2:
                        Console.WriteLine("Följande föremål är tillagt: ");
                        Console.Write(chosenObject + "");
                        // Skriv ut inmatade strängen från val 1 här
                        break;
                    case 3:
                        // Rensa /nollställ innehåll
                        chosenObject = String.Empty;
                        Console.WriteLine("Innehållet är nu tömt");
                        break;
                    case 4:
                        // end loop
                        isRunning = false;
                        break;
                  }

                /*
                if (menyVal == 1)
                {
                    // Läs in sträng från användaren som sedan sparas. += operatorn
                }

                else if (menyVal == 2)
                {
                    // Skriv ut inmatade strängen från val 1 här
                }

                else if (menyVal == 3)
                {
                    // Rensa /nollställ innehåll
                }

                else (menyVal == 4)
                {
                    // end loop
                } */
                /* Använd dig av följande från kapitel 7:
                 - Utskrift till konsolen
                 - Inmatning av data, spara i variabler med korrekt datatyp
                 - Selektion, IF eller SWITCH för menyn
                 - Loop som accepterar menyval tills användaren väljer att avsluta programmet, se exempel 7.39
                 - Kodblock, repetera avsnittet 7.6 och fundera på hur det påverkar ditt program */
            }
        }
    }
}
