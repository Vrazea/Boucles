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
        int count = 0;
        while (count < 10)
        {
            count++;
            Console.WriteLine(count);
        }
        */
        // Etape 2 : faire un décompte qui va de 5 à 1 puis qui dit "Bonne année !"
        /*
        int count = 6;
        while (count > 1) 
        {
            count--;
            Console.WriteLine(count);

        }

        Console.WriteLine("Bonne Année !");
        */
        // Etape 3 : faire un compteur qui va de -4 à 2
        /*
        int count;
        count = -5;
        while (count < 2)
        {
            count++;
            Console.WriteLine(count);
        }
        */
        // Etape 4 : faire un compteur qui compte 2 par 2 de 0 à 15
        /*
        int count = 0;
        while (count < 15)
        {
            if (count >= 14)
            {
                count++;
                Console.WriteLine(count);
            }
            else
            {
                count = count + 2;
                Console.WriteLine(count);
            }
        }
        */
        /*
        for (int count = 0; count < 15; count = count+2)
        {
            Console.WriteLine(count);
            if (count >= 14)
            {
                count++;
                Console.WriteLine(count);
            }
            else continue;
            
        }
        */
        // Etape 5 : faire une boucle qui se répète à chaque fois que l'utilisateur écrit autre chose que "oui"
        
        
        string? answer = Console.ReadLine();
        string? saysYes = "oui";
        while (saysYes != answer)
        {
            Console.ReadLine();
        }
        
        
        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}