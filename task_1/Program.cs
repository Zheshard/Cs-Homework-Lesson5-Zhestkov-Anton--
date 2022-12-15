// Программа, которая показывает количество четных чисел в массиве, заполненном случайными положительными трехзначными числами.

const int SIZE_ARRAY = 10;
const int LEFT_RANGE_ARRAY = 100;
const int RIGTH_RANGE_ARRAY = 999;
int[] arrayPositive3DigitNumbers = FillArrayWithRandomNumbers(SIZE_ARRAY, LEFT_RANGE_ARRAY, RIGTH_RANGE_ARRAY);
PrintArray(arrayPositive3DigitNumbers);

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rigthRange)
{
	int[] fillableArray = new int[size];
	Random rand = new Random();
	for (int i = 0; i < fillableArray.Length; i++)
	{
		fillableArray[i] = rand.Next(leftRange, rigthRange + 1);
	}
	return fillableArray;
}

void PrintArray(int[] outputArray)
{
	System.Console.WriteLine(string.Join("; ", outputArray));
}