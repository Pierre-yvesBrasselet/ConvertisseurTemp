namespace convertisseur_temp;

class Program
{
    static void Main(string[] args)
    {
        // Créez un programme sur console qui converti une température rentrée par l’utilisateur dans l’unité de son choix.
        // Deux sens de conversion doivent être possibles : soit de degrés Celsius vers Fahrenheit, soit de degrés Fahrenheit vers Celsius.
        int choice;
        do
        {
            Console.WriteLine("=== Convertisseur de température ===\n1. De Celsius à Fahrenheit\n2. De Fahrenheit à Celsius\n> Entrez votre choix ( 1 ou 2 )");
            choice = Convert.ToInt32(Console.ReadLine());
        } while (choice != 1 && choice != 2);
        if (choice == 1)
        {
            Console.WriteLine("\n> Entrez une température en degrés Celsius, sans préciser l'unité (ex : 19,5)");
            float temperature = float.Parse(Console.ReadLine());
            temperature = (float)(temperature * 1.8 + 32);
            Console.WriteLine("\n Votre température vaut " + temperature + "°F");
        }
        if (choice == 2)
        {
            Console.WriteLine("\n> Entrez une température en degrés Fahrenheit, sans préciser l'unité (ex : 19,5)");
            float temperature = float.Parse(Console.ReadLine());
            temperature = (float)((temperature - 32) / 1.8);
            Console.WriteLine("\n Votre température vaut " + temperature + "°C");
        }
        Console.WriteLine("\nMerci d'avoir utilisé notre convertisseur !");

    }
}