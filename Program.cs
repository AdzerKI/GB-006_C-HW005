// создание методов для всех задач

// создает рандомный массив int
int[] RandomArrayInt(int elements, int min, int max){
    int[] array = new int[elements];
    for(int i = 0; i < elements; i++){
        array[i] = new Random().Next(min, max + 1);
    }
    
    return array;
} 

// создает рандомный массив double
double[] RandomArrayDouble(int elements, double min, double max, int accuracy){
    double[] array = new double[elements];
    for(int i = 0; i < elements; i++){
        array[i] = new Random().NextDouble() * (max - min) + min;
        array[i] = Math.Round(array[i], accuracy);
    }
    
    return array;
} 

// метод возвращает строку из массива int
string ArrayIntToString(int[] arr){
    string result = "[";

    for(int i = 0; i < arr.Length; i++){
        if (i < arr.Length - 1){
            result = result + $"{arr[i]}, ";
        } else {
            result = result + $"{arr[i]}";
        }
    }

    result = result + "]";

    return result;
}

// Выводит массив Double в String
string ArrayDoubleToString(double[] arr){
    string result = "[";

    for(int i = 0; i < arr.Length; i++){
        if (i < arr.Length - 1){
            result = result + $"{arr[i]}; ";
        } else {
            result = result + $"{arr[i]}";
        }
    }

    result = result + "]";

    return result;
}

/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] array = RandomArrayInt(10, 100, 999);
int result = 0;

for (int i = 0; i < array.Length; i++){
    if (array[i] % 2 == 0){
        result++;
    } 
}

System.Console.WriteLine($"{ArrayIntToString(array)} -> {result}"); 

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] array = RandomArrayInt(10, 10, 99);
int result = 0;

for (int i = 0; i < array.Length; i++){
    if (i % 2 == 1){
        result = result + array[i];
    } 
}

System.Console.WriteLine($"{ArrayIntToString(array)} -> {result}"); 

/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

// рандом массив
double[] array = RandomArrayDouble(10, 10.00, 99.00, 2);

// минимум максимум
double min = array.Min();
double max = array.Max();

// результат
System.Console.WriteLine($"{ArrayDoubleToString(array)} -> {max - min}"); 