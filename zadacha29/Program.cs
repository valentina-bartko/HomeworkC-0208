// Напишите метод, который задает массив из 8 элементов
// и выводит их на экран.

// Я понимаю задачу так: числа автоматически генерируются из диапазона от 1 до 99.

// метод создания массива
// метод заполнения массива
// метод печати массива

// Я пыталась сделать метод создания массива, но с ним ничего не работало, поэтому создала массив без метода.
//int [] array;

//void CreateArray ()
//{
//   int[] Array = new int[8];
//}

int[] array = new int[8];

void FillArray (int[] Array)
{
   int length = Array.Length;
   int index = 0;
   while (index < length)
   {
      Array [index] = new Random().Next(1, 100);
      index++;
   }
}

void Print (int[] Array)
{
   int length = Array.Length;
   int index = 0;
   while (index < length)
   {
      Console.Write($"{Array[index]}, ");
      index++;
   }
}

//CreateArray();
FillArray(array);
Print(array);
