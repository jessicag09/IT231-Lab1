// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a number:");
int num1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter another number:");
int num2 = Int32.Parse(Console.ReadLine());

static int Add(int num1, int num2)
{
    int sum = num1 + num2;
    return sum;
}
static int Multiply(int num1, int num2)
{
    int product = num1 * num2;
    return product;
}