
List<int> numbers = new List<int>(){
1,2,3,4,
};

System.Console.WriteLine($"\n*****First List*****");
for (int i = 0; i < numbers.Count; i++)
{
    System.Console.WriteLine($"{numbers[i]}");
}
System.Console.WriteLine($"\n*****Add*****");
numbers.Add(5);
numbers.Add(6);

for (int i = 0; i < numbers.Count; i++)
{
    System.Console.WriteLine($"{numbers[i]}");
}

System.Console.WriteLine($"\n*****Delete*****");
numbers.RemoveAt(3);

for (int i = 0; i < numbers.Count; i++)
{
    System.Console.WriteLine($"{numbers[i]}");
}

System.Console.WriteLine($"Count: {numbers.Count}");


List<string> users = new List<string>(){
"Ali",
"Efe",
"Yakup",
"Omer"
};

System.Console.WriteLine($"\n*****First List*****");
users.ForEach((user) =>
{
    System.Console.WriteLine($"{user}");
});

System.Console.WriteLine($"\n*****Add*****");
users.Add("Yavuz");
users.Add("Hamza");

users.ForEach((user) =>
{
    System.Console.WriteLine($"{user}");
});

System.Console.WriteLine($"\n*****Delete*****");
users.RemoveAt(0);

users.ForEach((user) =>
{
    System.Console.WriteLine($"{user}");
});

System.Console.WriteLine($"Count: {users.Count}");

users.Clear();
users.ForEach((user) =>
{
    System.Console.WriteLine($"Clear: {user}");
});

System.Console.WriteLine($"Clear After Count: {users.Count}");