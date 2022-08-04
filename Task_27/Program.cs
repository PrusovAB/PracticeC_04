Console.Clear();
Console.WriteLine("Введите число числа которых нужно сложить: ");
int numberBase = Convert.ToInt32(Console.ReadLine());

int  SearchSum(int numBas){
	if(numBas<0){
		numBas = numBas * -1;
	}
	int rezult = 0;
	int remainderNum = 0;
	while(numBas >= 1)
	{
		remainderNum = numBas % 10;
		numBas = numBas /10;
		rezult = rezult + remainderNum;
	}
	return rezult;
}

int sum = SearchSum(numberBase);

Console.WriteLine($"сумма всеx чисел числа {numberBase } ровна {sum}");