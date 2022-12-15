// Программа, вычисляющая сумму элементов одномерного масссива, заполненного случайными числами, стоящих на нечетных позициях.

int sizeArray = InputNumber("Введите размер массива: ");
int leftRangeArray = InputNumber("Введите минимальное значение диапазона чисел: ");
int rigthRangeArray = InputNumber("Введите максимальное значение диапазона чисел: ");
int[] oneDimensionalArray = FillArrayWithRandomNumbers(sizeArray, leftRangeArray, rigthRangeArray);
PrintArray(oneDimensionalArray);
System.Console.WriteLine(SumOfElementsWithAnOddIndex(oneDimensionalArray));

int InputNumber(string invitationText)
{
	int inputNum;
	while (true)
	{
		System.Console.WriteLine(invitationText);
		string inputStr = Console.ReadLine();
		if (int.TryParse(inputStr, out inputNum))
		{
			break;
		}
		System.Console.WriteLine("Введено неверное значение. Необходимо ввести число!");
	}
	return inputNum;
}

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

int SumOfElementsWithAnOddIndex(int[] sourceArray)
{
	int sum = 0;
	for (int i = 0; i < sourceArray.Length; i++)
	{
		if (i % 2 == 1)
		{
			sum = sum + sourceArray[i];
		}
	}
	return sum;
}