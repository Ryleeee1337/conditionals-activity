Console.Write("Enter score: ");
int score = Convert.ToInt32(Console.ReadLine());
string result = (score >= 50) ? "Passed" : "Failed";
Console.WriteLine(result);
