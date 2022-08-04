Console.Clear();

int[] GetRandomArray(int arrayLenght)
{
	Random rnd = new Random();
	int[] arr = new int[arrayLenght];

	for(int i = 0; i < arr.Length; i++)
	{
		arr[i] = rnd.Next(-1000,1000);
	}
	return arr;
}

int[] array = GetRandomArray(8);
WriteArrayToConsole(array);


void WriteArrayToConsole(int[] array)
{
	Console.Clear();
	Console.Write("[");
	for(int i = 0; i < array.Length; i++)
	{
		Console.Write(array[i]);
		if (i != array.Length-1)
		Console.Write(",");
	}
	Console.WriteLine("]");
}