using Mission2_Assignment;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int num = 0;
        

        RollDice rd = new RollDice();

        Console.WriteLine("Enter how many times to roll the dice: ");
        num = int.Parse(Console.ReadLine());

        int[] sums = new int[num];

        for (int i = 0; i < num; i++)
        {
            sums[i] = rd.Roll(num);
                     

        }

        for (int value = 2; value <= 12; value++)
        {

            int count = 0;
            foreach (int roll in sums)
            {
                
                if (roll == value)
                {
                    count++;
                    
                }
            }
            int stars = (count * 100) / num;

            Console.Write($"{value}: ");
            Console.Write(new string('*', stars));
            Console.WriteLine();
        }

        Console.WriteLine("Thank you for using the dice simulator. Goodbye!");

    }
}