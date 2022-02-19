//1. მოცემულია სამნიშნა რიცხვი, აღვვწეროთ სამი ცვლადი a1, a2, a3, მოვათავსოთ აღწერილ ცვლადებში რიცხვის ციფრები.
{
	int number = 127;
	int a1;
	int a2;
	int a3;

	a1 = number / 100;
	a2 = (number / 10) % 10;
	a3 = number % 10;
}

//2. მოცემულია მთელი ორნიშნა რიცხვი, აღვწეროთ result ცვლადი და მასში მოვათავსოთ მოცემული რიცხვის ციფრების ჯამი.
{
	int number = 97;
	int result;
	int firstDigit;
	int lastDigit;
	
	firstDigit = number / 10;
	lastDigit = number % 10;
  	result = firstDigit + lastDigit;
}

//3. მოცემულია ოთხნიშნა რიცხვი, აღვწეროთ result ცვლადი და მასში მოვათავსოთ მოცემული რიცხვის ლუწი ციფრების ჯამი.
{
	int num = 1234;
	int even;
	int result = 0;
	
	while (n > 0)
	{
		even = n % 10;
		if (even % 2 == 0)
		{
			result = result + even;
		}
			
			n = n / 10;
	}	
}
	
	
}
