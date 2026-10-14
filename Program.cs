namespace Boucles;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */
        
        // Etape 1 : faire un compteur qui va de 1 à 10

        for (int compteur = 1; compteur <= 10; compteur++)
        {
            Console.WriteLine(compteur);
        }
        // Etape 2 : faire un décompte qui va de 5 à 1 puis qui dit "Bonne année !"
        
        for (int compteur2 = 5; compteur2 >= 1; compteur2--)
        {
            Console.WriteLine(compteur2);
        }
        Console.WriteLine("Bonne année");

        // Etape 3 : faire un compteur qui va de -4 à 2.

        for (int compteur3 = -4; compteur3 <= 2; compteur3++)
        {
            Console.WriteLine(compteur3);
        }
        
        // Etape 4 : faire un compteur qui compte 2 par 2 de 0 à 15
       
        /* for (int compteur4 = 0; compteur4 <= 15; compteur4++)
        {
            if (compteur4 % 2 == 0){
                Console.WriteLine(compteur4);
            }
        }*/

        for (int compteur4 = 0; compteur4 <= 15; compteur4 += 2)
        {
            Console.WriteLine(compteur4);
        }
        
        // Etape 5 : faire une boucle qui se répète à chaque fois que l'utilisateur écrit autre chose que "oui"

        /*string reponse5 = Console.ReadLine();

        while (reponse5 != "oui")
        {
            reponse5 = Console.ReadLine();
        }*/

        string answer = "";
        do
        {
            Console.WriteLine("voulez vous sortir du programme ?");
            answer = Console.ReadLine();
        }
        while (answer != "oui") ;
        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}