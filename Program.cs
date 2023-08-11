Console.Write("Введите номер задачи: ");
int a = 0;
try{
a = Convert.ToInt32(Console.ReadLine());
} catch (System.FormatException){
    Console.Write("Это не номер");
    return;
}

switch (a){

    case 25:
    task25();
    break;

    case 27:
    task27();
    break;

    case 29:
    task29();
    break;

    default: 
    Console.WriteLine("Нет такой задачи(");
    break;
}

// Task 25. Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

int powNumb(){
    Console.Write("\nВведите число: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите степень: ");
    int powN = Convert.ToInt32(Console.ReadLine());
    
    int result = 1;
    for(int i = 1; i <= powN; i++){
        result *= numb;
    }
    
    return result;
}


void task25(){
    bool complete = false;
    while(complete == false){
        Console.WriteLine("1 - Выполнить\n2 - Выход\n");
        int a = Convert.ToInt32(Console.ReadLine());

        switch (a){
            case 1:
            Console.WriteLine("\nРезультат: " + powNumb() + "\n");
                break;
            case 2:
            complete = true;
            break;
            default: 
            Console.WriteLine("Пожалуйста, выберите один из предложенных вариантов");
            break;
        }

    }
}

// Task27. Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе.

int[] numbers(string abc){
    int[] numbers = new int[abc.Length];

    for(int i = 0; i < numbers.Length; i++){
        numbers[i] = Convert.ToInt32(abc[i].ToString());
    }

    return numbers;
}

void task27(){
    Console.WriteLine("Введите число");
    string a = Console.ReadLine();

    try{
        int num = Convert.ToInt32(a);
        int[] numbers2 = numbers(a);
        num = 0;
        for(int i = 0; i < numbers2.Length; i++){
            num += numbers2[i];
        }
        Console.WriteLine("Сумма цифр в числе "+ a + " = " + num);
    } catch(FormatException){
        Console.WriteLine("Это не число");
    }
}

// Task29. Напишите программу, которая задаёт массив из m элементов
// и выводит их на экран.

int[] createArray(int size){
    int[] numbers = new int[size];

    Console.WriteLine("Введите "+ size + " числа:");

    for(int i = 0; i < size; i++){
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    return numbers;
}

void task29(){
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] mass = createArray(size);

    Console.WriteLine("Ваш массив: ");
    for (int i = 0; i < size; i++){
        Console.WriteLine(mass[i]);
    }
}