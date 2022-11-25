//Transform the algebraic expression with brackets into RPN form (Reverse Polish Notation). 
//Two-argument operators: +, -, *, /, ^ (priority from the lowest to the highest), brackets ( ). 
//Operands: only letters: a,b,...,z. Assume that there is only one RPN form (no expressions like a*b*c).

using System.Collections;

static string[] getData()
{
    int count = Convert.ToInt32(Console.ReadLine());
    string[] data = new string[count];
    for (int i = 0; i < count; i++)
    {
        string line = Console.ReadLine();
        data[i] = line;
    }
    return data;
}

static void convertToRPN(string data)
{
    int length = data.Length;
    Queue<char> queue = new Queue<char>();
    Stack<char> operatorStack = new Stack<char>();
    for (int i = 0; i < length; i++)
    {
        char c = data[i];
        if (c == '+' || c == '-' || c == '*' || c == '/' || c == '^')
        {
            operatorStack.Push(c);
        }
        else
        {
            if (c == '(');
            else if (c == ')')
            {
                while (queue.Count > 0)
                    Console.Write(queue.Dequeue());
                Console.Write(operatorStack.Pop());
            }
            else if (Char.IsLetter(c)) queue.Enqueue(c);
        }

        
    }
}

string[] data = getData();
for (int i = 0; i < data.Length; i++)
{
    convertToRPN(data[i]);
    Console.WriteLine("");
}

