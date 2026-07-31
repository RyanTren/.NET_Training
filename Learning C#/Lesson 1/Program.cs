Console.WriteLine("Hello, World!");

string firstName = "    John    ";
string lastName = "     Doe     ";

Console.WriteLine($"My name is {firstName} {lastName.Trim()}.");

string sentence = $"My name is {firstName.Trim()} {lastName.Trim()}.";
Console.WriteLine(sentence.ToArray());
Console.WriteLine(sentence.ToUpper());
Console.WriteLine(sentence.ToLower());

Console.WriteLine(sentence.Replace("John", "Jane"));
Console.WriteLine(sentence.StartsWith("My name"));
Console.WriteLine($"Sentence Length: {sentence.Length}");

int a = 5;
int b = 20;
int c = a + b;
Console.WriteLine(c);

int d = 2100000000;
int e = 2100000000;
long test_f = checked(d + e);
Console.WriteLine(test_f);
long f = (long)d + (long)e; //casting to long to avoid overflow
Console.WriteLine(f);

double x = 42.1; //natural type
float y = 38.2F;
double z = x + y;
Console.WriteLine(z);

decimal x1 = 42.1M;
decimal y1 = 38.2M;
decimal z1 = x1 + y1;
Console.WriteLine(z1);
Console.WriteLine($"The answer is {z1}!");