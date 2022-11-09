int ReadInt(string message)
{
    Console.Write(message + "-> ");
    return Convert.ToInt32(Console.ReadLine());
}


int number = ReadInt("Сколько элементов вы хотите ввести?");

int[] myArray = new int[number];

for(int i = 0; i < number; i++)
{
   myArray[i] = ReadInt("Введите число"); 
}

Console.Write("[ " + myArray[0] + ", ");
for(int i = 1; i < myArray.Length - 1; i++)
{
    Console.Write(myArray[i] + ", ");
}
Console.Write(myArray[myArray.Length - 1] + " ]");
