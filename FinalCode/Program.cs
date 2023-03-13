string[] CheckElements(string[] firstArr) 
{
    int counter = 0;

    for(int i = 0; i < firstArr.Length; i++) 
    {
        if(firstArr[i].Length <= 3) 
        {
            counter++;
        }
    }

    string[] secondArr = new string[counter];
    int j = 0;

    for(int i = 0; i < firstArr.Length; i++) 
    {
        if(firstArr[i].Length <= 3) 
        {
            secondArr[j] = firstArr[i];
            j++;
        }
    }
    return secondArr;
}

void PrintArray(string[] finalArray) 
{
    Console.WriteLine();
    Console.Write(" ");

    for(int i = 0; i < finalArray.Length; i++) 
    {
        if(i < finalArray.Length - 1) 
        {
            Console.Write($"{finalArray[i]}, ");
        }
        else {
            Console.Write($"{finalArray[i]}.");
        }
    }
}

string[] array = new string[6] {"GitHub", "010", "GB", "Open", ":D", "Diagramma"};

Console.WriteLine();
Console.WriteLine("Изначально заданный массив:");


for(int i = 0; i < array.Length; i++) 
{
    if(i < array.Length - 1) 
    {
        Console.Write($"{array[i]}, ");
    }
    else 
    {
        Console.Write($"{array[i]}.");
    }
}
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Массив, с элементами длиной не более 3 символов:");
PrintArray(CheckElements(array));
