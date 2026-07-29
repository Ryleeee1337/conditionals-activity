Console.Write("Choice [A/P/X]: ");
char choice = char.ToUpper(Console.ReadKey().KeyChar);
Console.WriteLine();
Console.Write("Enter radius: ");
double r = Convert.ToDouble(Console.ReadLine());
switch (choice)
{
    case 'A':
        Console.WriteLine($"Area = {Math.PI * r * r}");
        break;
    case 'P':
        Console.WriteLine($"Perimeter = {2 * Math.PI * r}");
        break;
    case 'X':
        Console.WriteLine("Exiting...");
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}
