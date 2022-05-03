//See https://aka.ms/new-console-template for more information
Console.WriteLine("a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b: ");
int b = Convert.ToInt32(Console.ReadLine());

float total = 0;


String op =string.Empty;

while(op != "+" && op != "-" && op != "*" && op != "/" )
{
    Console.WriteLine($"a: {a}, b: {b}");
    Console.WriteLine("What operator would you like to use? * Multiplication,  / Division, + Addition, and - Subtraction");
    op = Console.ReadLine();    
}


    if (op == "*")
    {
        total = a * b;
    }
    else if (op == "/")
    {
        total = (float)a / (float)b;
    }
    else if (op == "+")
    {
        total = a + b;
    }
    else if (op == "-")
    {
        total = a - b;
        
    }
    else
    {
        Console.WriteLine("This is not a valid operator");
    }

    Console.WriteLine(total);


