char[] alphabet = new char[26];
int num = 97;
for(int i = 0; i < alphabet.Length; i++)
{
    Console.WriteLine((char)(num));
    num++; 
}
int newNum = 122;
Console.WriteLine();
for (int i = 0; i < alphabet.Length; i++)
{
    Console.WriteLine((char)(newNum));
    newNum--;
}

int uppercase = 65;
int[] value = new int[26];
Console.WriteLine();
for (int i = 0; i < alphabet.Length; i++)
{
    value[i] = uppercase;
    Console.WriteLine((char)uppercase);
    uppercase++;
}

int[] fibonacci = {13, 1, 2, 3, 5, 8, 1, 34, 21, 55};

Array.Sort(fibonacci); 
foreach(int i in fibonacci)
{
    Console.WriteLine(i);
}

int numToFind = 34;
int index;
for(int i = 0;i < fibonacci.Length;i++)
{
    if (fibonacci[i] == numToFind)
    {
        index = i;
        Console.WriteLine(index);
        break;
    } else
    {
        index = -1;
    }
    
}