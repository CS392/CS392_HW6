// See https://aka.ms/new-console-template for more information

// Replace with your own file path
string fileContent = File.ReadAllText(@"C:\Users\houch\Downloads\random.txt");

List<int> res = new List<int>();
foreach (string line in fileContent.Split("\n"))
{
    res.Add(int.Parse(line));
}

// Remove all Negative number
res.RemoveAll(x => x < 0);
res = res.FindAll(x => x >= 1 && x <= 10);    

for (int i = 0; i < res.Count; i++)
{
    Console.WriteLine(res[i]);
}

