// Программа, вычисляющая разницу между максимальным и минимальным элементами массива, состоящего из вещественных чисел.

int sizeArray = InputNumber("Введите размер массива: ");
int leftRangeArray = InputNumber("Введите значение начала диапазона: ");
int rigthRangeArray = InputNumber("Введите значение конца диапазона: ");
double[] arrayRealNumbers = FillArrayWithRandomRealNumbers(sizeArray, leftRangeArray, rigthRangeArray);
PrintArray(arrayRealNumbers);

double[] FillArrayWithRandomRealNumbers(int size, int leftRange, int rigthRange)
{
	double[] fillableArray = new double[size];
	Random rand = new Random();
	for (int i = 0; i < fillableArray.Length; i++)
	{
		fillableArray[i] = Math.Round(rand.Next(leftRange, rigthRange) + rand.NextDouble(), 2);
	}
	return fillableArray;
}

void PrintArray(double[] outputArray)
{
	System.Console.WriteLine(string.Join("; ", outputArray));
}

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
