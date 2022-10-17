namespace FunktionerFacit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uppgift 1 --------------------

            //Deklarerar vairabler
            string name = "Marcus";
            int antal = 5;
            
            //Be användaren mata in värden
            name = UserInput("Mata in ditt namn");
            antal = Convert.ToInt32(UserInput("Mata in antal"));
            
            //Initera en For-loop
            for (int i = 0; i < antal; i++)
            {
                //Anropa Greetings metoden
                Greetings(name);
            }

            // Uppgift 2 ------------------------

            //Anropa GenerateMessage funktionen
            GenerateMessage();
        }

        //Uppgift 1 funktioner ----------------
        private static void Greetings(string name)
        {
            //Skriva ut meddelande till Konsolen
            //som inkluderar name-parameter
            Console.WriteLine("Hejsan {0}" , name);
        }

        private static string UserInput(string message)
        {
            //Ställa fråga till användaren
            Console.Write("{0}: ", message);
            
            //Användaren skriver in svaret
            string input = Console.ReadLine();

            //Returnera svar
            return input;
        }

        //Uppgift 2 funktioner ---------------------
        private static decimal Medelvärde(decimal tal1, decimal tal2)
        {
            // Räkna ut summan av tal1 + tal2
            decimal summa = tal1 + tal2;

            //Returnera medelvärdet
            return summa / 2;
        }

        private static string FullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        private static void GenerateMessage()
        {
            //Deklarera variabler
            string fName1 = "Marcus", lName1 = "Henriksson", fName2 = "Niklas", lName2 = "Cullberg";
            decimal age1 = 34, age2 = 31;

            //Skapa 2st FullName av 2 personer
            string fullName1 = FullName(fName1, lName1),
                   fullName2 = FullName(fName2, lName2);

            //Räkan ut medelvärdet av personernas åldrar
            decimal medel = Medelvärde(age1 , age2);

            //Skriv ut meddelande till konsolen
            Console.WriteLine("Medelåldern mellan {0} och {1} är {2}",
                                fullName1, fullName2, medel);
        }
    }
}