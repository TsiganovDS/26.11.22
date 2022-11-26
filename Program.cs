Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
ArrayRandomNumbers(numbers);
Console.Write("Массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"Сумма элементов на нечётных позициях - {sum}");

void ArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(0, 99);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
              if (i < numbers.Length - 1)
              {
                  Console.Write(", ");
              }    
        }
    Console.WriteLine("]");
}
  

