int ReadInt(string message)
{
    Console.Write(message + "-> ");
    return Convert.ToInt32(Console.ReadLine());
}

int numbers = ReadInt("Введите число");
int numbers2 = numbers;
int sum = 0;
int num = 1; 

for(; numbers > 10; num++ )
{
    numbers /= 10;
}

int[] nums = new int[num];
for(int i = 0; i < num; i++)
{
    int sam = numbers2 %10;
    nums[i] = sam;
    numbers2 /= 10;
}

for(int i = 0; i < num; i++ )
{
    sum += nums[i];
}


Console.WriteLine("Сумма цифр в числе -> " + sum);
