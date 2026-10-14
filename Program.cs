namespace Boucles;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */
        
        // Etape 1 : faire un compteur qui va de 1 à 10
        /*
        int count1 = 0;
        while (count1 < 10)
        {
            count1++;
            Console.WriteLine(count1);
        }
        */
        /*
        for (int i = 1; i <= 10; i++) // Correction
        {
            Console.WriteLine(i);
        }
        */
        // Etape 2 : faire un décompte qui va de 5 à 1 puis qui dit "Bonne année !"
        /*
        int count2 = 6;
        while (count2 > 1) 
        {
            count2--;
            Console.WriteLine(count2);

        }
        
        Console.WriteLine("Bonne Année !");
        */
        /*
        for (int i = 5; i >= 5; i--) // Correction
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Bonne Année !");
        */
        // Etape 3 : faire un compteur qui va de -4 à 2
        /*
        int count3;
        count3 = -5;
        while (count3 < 2)
        {
            count3++;
            Console.WriteLine(count3);
        }
        */
        /*
        for (int i = -4; i <= 2; i++) //Correction
        {
            Console.WriteLine(i);
        }
        */
        // Etape 4 : faire un compteur qui compte 2 par 2 de 0 à 15
        /*
        int count4 = 0;
        while (count4 < 15)
        {
            if (count4 >= 14)
            {
                count4++;
                Console.WriteLine(count4);
            }
            else
            {
                count4 = count4 + 2;
                Console.WriteLine(count4);
            }
        }
        
        for (int count5 = 0; count5 < 15; count5 = count5+2)
        {
            Console.WriteLine(count5);
            if (count5 >= 14)
            {
                count5++;
                Console.WriteLine(count5);
            }
            else continue;
            
        }
        */
        /*
        for (int i = 0; i <= 15; i += 2)
        {
            Console.WriteLine(i);
        }
        */
        // Etape 5 : faire une boucle qui se répète à chaque fois que l'utilisateur écrit autre chose que "oui"
        
        /*
        string? answer;
        do
        {
            Console.WriteLine(" tu veux sortir ? ");
            answer = Console.ReadLine();
        } while (answer != "oui");
        */
        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}