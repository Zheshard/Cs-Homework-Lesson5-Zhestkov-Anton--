// Программа, вычисляющая разницу между максимальным и минимальным элементами массива, состоящего из вещественных чисел.

int sizeArray = InputNumber("Введите размер массива: ");
int leftRangeArray = InputNumber("Введите значение начала диапазона: ");
int rigthRangeArray = InputNumber("Введите значение конца диапазона: ");
double[] arrayRealNumbers = FillArrayWithRandomRealNumbers(sizeArray, leftRangeArray, rigthRangeArray);
PrintArray(arrayRealNumbers);
FindingMaxMin(arrayRealNumbers, out double min, out double max);
System.Console.WriteLine($"Минимальное значение массива min = {min}\nМаксимальное значение массива max = {max}");
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {max} - {min} = {max - min}");

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

void FindingMaxMin(double[] sourceArray, out double min, out double max)
{
	if (sourceArray[0] < sourceArray[1])
	{
		min = sourceArray[0];
		max = sourceArray[1];
	}
	else
	{
		min = sourceArray[1];
		max = sourceArray[0];
	}
	int i = 2;
	while (i < sourceArray.Length)
	{
		if (min < sourceArray[i])
		{
			if (max > sourceArray[i])
			{
				i++;
			}
			else
			{
				max = sourceArray[i];
				i++;
			}
		}
		else
		{
			min = sourceArray[i];
			i++;
		}
	}
}
