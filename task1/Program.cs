Console.WriteLine("Введите число");
string numbers = Convert.ToString(Console.ReadLine());
string[] array = numbers.Split(' ');
int[] intArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    intArray[i] = Convert.ToInt32(array[i]);
}
 int count = 0;
 for (int i = 0; i < intArray.Length; i++ )
 {
     if(intArray[i] > 0) 
     {
         count = count + 1;
     }
 }
 Console.WriteLine ($"Количество чисел больше 0:  {count}" );
