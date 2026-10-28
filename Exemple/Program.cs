using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1 ICollection   2 IList   3 ISet   4 IDictionary   5 Queue si Stack   0 iesire");
            string alegere = Console.ReadLine();
            if (alegere == null || alegere == "0")
            {
                return;
            }
            Console.WriteLine();
            switch (alegere)
            {
                case "1":
                    ExempluICollection.Ruleaza();
                    break;
                case "2":
                    ExempluIList.Ruleaza();
                    break;
                case "3":
                    ExempluISet.Ruleaza();
                    break;
                case "4":
                    ExempluIDictionary.Ruleaza();
                    break;
                case "5":
                    ExempluQueueStack.Ruleaza();
                    break;
            }
        }
    }
}
