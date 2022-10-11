// numret från labben: 29535123p48723487597645723645

Console.Write("Enter a number: ");
string input = Console.ReadLine();

long totalSum = 0;



for (int i = 0; i < input.Length - 1; i++)
{
    for (int j = i + 1; j < input.Length; j++)
    {


        if (char.IsDigit(input[j]))
        {
            if (input[i] == input[j])
            {
                int indexOfDigit = j + 1 - i;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(input.Substring(0, i));
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(input.Substring(i, indexOfDigit));
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(input.Substring(j + 1, input.Length - indexOfDigit - i));

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                totalSum += long.Parse(input.Substring(i, indexOfDigit));
                break;

            }

        }
        else
        {
            break;
        }
    }


}

Console.WriteLine("total sum of numbers: " + totalSum);