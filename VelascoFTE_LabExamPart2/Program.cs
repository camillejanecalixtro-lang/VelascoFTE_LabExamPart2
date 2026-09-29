using System;

class Program
{
    static void Main()
    {
        string[] participant = new string[3];
        int[,] scores = new int[3, 3];
        int[] totals = new int[3];

        int choice;

        do
        {
            Console.WriteLine("\nCOMMUNITY FUN RUN SYSTEM");
            Console.WriteLine("[1] RECORD SCORES");
            Console.WriteLine("[2] SHOW PARTICIPANT SCORES");
            Console.WriteLine("[3] SHOW RANKING");
            Console.WriteLine("[4] EXIT");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("\nEnter Participant Name: ");
                        participant[i] = Console.ReadLine();

                        totals[i] = 0;

                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write($"Round {j + 1} Score: ");
                            scores[i, j] = Convert.ToInt32(Console.ReadLine());

                            totals[i] += scores[i, j];
                        }
                    }
                    break;

                case 2:
                   
                    Console.WriteLine("\nParticipant\tR1\tR2\tR3\tTOTAL");

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine(
                            $"{participant[i]}\t\t{scores[i, 0]}\t{scores[i, 1]}\t{scores[i, 2]}\t{totals[i]}"
                        );
                    }
                    break;

                case 3:
                   
                    string[] rankParticipant = new string[3];
                    int[] rankTotals = new int[3];

                    for (int i = 0; i < rankTotals.Length - 1; i++)
                    {
                        int maxIndex = i;

                        for (int j = i + 1; j < rankTotals.Length; j++)
                        {
                            if (rankTotals[j] > rankTotals[maxIndex])
                            {
                                maxIndex = j;
                            }
                        }

                        int tempTotal = rankTotals[i];
                        rankTotals[i] = rankTotals[maxIndex];
                        rankTotals[maxIndex] = tempTotal;

                        string tempPlayer = rankParticipant[i];
                        rankParticipant[i] = rankParticipant[maxIndex];
                        rankParticipant[maxIndex] = tempPlayer;

                        Console.WriteLine($"\nPass {i + 1}");
                        for (int k = 0; i < 3; i++)
                        {
                            Console.WriteLine($"{i + 1}. {rankParticipant[i]} - {rankTotals[i]}");
                        }

                    }
        
                        break;

                case 4:
                    Console.WriteLine("Program Ended.");
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

        } while (choice != 4);
    }
}
