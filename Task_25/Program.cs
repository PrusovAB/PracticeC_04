Console.Clear();
Console.WriteLine("Введите число которое нужно возвести в степень: ");
int numberBase = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число которое будет степенью: ");
int numberDegree = Convert.ToInt32(Console.ReadLine());

int  SearchNumber(int numBas ,int numDeg){
	int rezult = 1;
	if (numBas <= 0){
		if(numDeg %2 ==0){
			numBas = numBas * -1;
		}
	}
	for(int i = 0; i < numDeg; i++){
		rezult = +rezult * numBas;
	}
	return rezult;
}
int serchNumber = SearchNumber(numberBase,numberDegree);

Console.WriteLine($"Число {numberBase} в степене {numberDegree} равен: {serchNumber}");