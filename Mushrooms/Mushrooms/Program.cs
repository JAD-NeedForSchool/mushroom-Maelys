using Mushrooms.Champignons;
using Mushrooms.Decorators;
using Mushrooms;
class Program
{
    static void Main()
    {
        Console.WriteLine("Choisissez un champignon de base :");
        Console.WriteLine("1. Bolet");
        Console.WriteLine("2. Amanites");
        Console.WriteLine("3. Coprins");

        int choixChampignon = int.Parse(Console.ReadLine());
        IChampignon champignon = CreerChampignon(choixChampignon);

        Console.WriteLine("Choisissez les mutations (séparées par des virgules) :");
        Console.WriteLine("1. Radioactif");
        Console.WriteLine("2. Volant");
        Console.WriteLine("3. Rampant");
        Console.WriteLine("4. Cannibale");
        Console.WriteLine("5. Parlant");

        string[] mutations = Console.ReadLine().Split(',');

        List<Type> decoratorsAppliques = new List<Type>();

        for (int i = mutations.Length - 1; i >= 0; i--)
        {
            Type decoratorType = ObtenirTypeDecorateur(mutations[i]);
            
            if (!decoratorsAppliques.Contains(decoratorType))
            {
                champignon = AjouterMutation(champignon, decoratorType);
                decoratorsAppliques.Add(decoratorType);
            }
        }

        string resultatChampignon = $"{champignon.Spore()}";

        Console.WriteLine($"Résultat : {resultatChampignon}");



    }

    static IChampignon CreerChampignon(int choix)
    {
        switch (choix)
        {
            case 1:
                return new bolet();
            case 2:
                return new amanites();
            case 3:
                return new coprins();
            default:
                throw new ArgumentException("Choix de champignon invalide");
        }
    }

    static IChampignon AjouterMutation(IChampignon champignon, Type decoratorType)
    {
        switch (decoratorType.Name)
        {
            case "RadioactifDecorator":
                return new RadioactifDecorator(champignon);
            case "VolantDecorator":
                return new VolantDecorator(champignon);
            case "RampantDecorator":
                return new RampantDecorator(champignon);
            case "CannibaleDecorator":
                return new CannibaleDecorator(champignon);
            case "ParlantDecorator":
                return new ParlantDecorator(champignon);
            default:
                throw new ArgumentException("Choix de mutation invalide");
        }
    }

    static Type ObtenirTypeDecorateur(string choixMutation)
    {
        switch (choixMutation)
        {
            case "1":
                return typeof(RadioactifDecorator);
            case "2":
                return typeof(VolantDecorator);
            case "3":
                return typeof(RampantDecorator);
            case "4":
                return typeof(CannibaleDecorator);
            case "5":
                return typeof(ParlantDecorator);
            default:
                throw new ArgumentException("Choix de mutation invalide");
        }
    }
}
