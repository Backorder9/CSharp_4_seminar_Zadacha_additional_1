/* Дополнительно
1) Преобразовать массив так, чтобы сначала шли нулевые элементы, а затем все остальные.
-1 -3 -1 -3 -1 0 -4 -2 -> 0 -3 -1 -3 -1 -1 -4 -2 */

int[] Zeroes(int[] rrr)
{
int N = rrr.Length;
int[] ray = new int[N];
int currIndex = N-1; // текущий индекс
for (int i = currIndex; i >=0; i--)
   if (rrr[i] != 0) // перемещение вправо ненулевых элементов
   { 
        ray[currIndex]=rrr[i];
        currIndex--;
    }
for (int i = 0; i <= currIndex; i++)
ray[i] = 0; // обнуление оставшихся слева элементов
return ray;
}

void Print(int[] aaa, int[] bbb)
{
    Console.WriteLine();
    Console.WriteLine("Начальный массив: " + String.Join(", ", aaa) + ".");
    Console.WriteLine();
    Console.WriteLine("Итоговый массив, со смещением нулевых элементов влево: " + String.Join(", ", bbb) + ".");
    Console.WriteLine();
}

int[] array = {-1, -3, 0, -5, -7, -9, 0, -4, -2, 0};
int[] zeroarr = Zeroes(array);
Print(array, zeroarr);