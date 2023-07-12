// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.


Console.WriteLine("Введите количество строк начадьного массива: ");
int userMassSize = int.Parse(Console.ReadLine()!);




string[] InitUserMass(int size)
{
    string[] mass = new string[size];
    return mass;
}




void FillMass(string[] mass)
{
    int j = 0;
    for (int i = 1; i <= userMassSize; i++)
    {
        Console.WriteLine($"Введите {i} строку");
        mass[j] = Console.ReadLine()!;
        j++;
    }
}






void PrintMass(string[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        if (i == 0) Console.Write($"[{mass[i]}, ");
        else if (i != mass.Length - 1) Console.Write($"{mass[i]}, ");
        else
        {
            Console.Write($"{mass[i]}]");
            Console.WriteLine();
        }




    }
    if (mass.Length == 0) Console.WriteLine("[]");
}


string[] userMass = InitUserMass(userMassSize);
FillMass(userMass);
Console.WriteLine();
PrintMass(userMass);

