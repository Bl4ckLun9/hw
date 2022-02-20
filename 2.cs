{
//1. მოცემულია სამნიშნა რიცხვი, აღვვწეროთ სამი ცვლადი a1, a2, a3, მოვათავსოთ აღწერილ ცვლადებში რიცხვის ციფრები.

	int Number = 127;
	int a1;
	int a2;
	int a3;

	a1 = Number / 100;
	a2 = (Number / 10) % 10;
	a3 = Number % 10;
}

{
//2. მოცემულია მთელი ორნიშნა რიცხვი, აღვწეროთ result ცვლადი და მასში მოვათავსოთ მოცემული რიცხვის ციფრების ჯამი.
	int Number = 97;
	int Result;
	int FirstDigit;
	int LastDigit;
	
	FirstDigit = Number / 10;
	LastDigit = Number % 10;
  	Result = FirstDigit + LastDigit;
}


{
//3. მოცემულია ოთხნიშნა რიცხვი, აღვწეროთ result ცვლადი და მასში მოვათავსოთ მოცემული რიცხვის ლუწი ციფრების ჯამი.
	int Num = 1234;
	int Even;
	int Result = 0;
	
	while (num > 0)
	{
		even = num % 10;
		if (even % 2 == 0)
		{
			result = result + even;
		}
			
			num = num / 10;
	}
}

{
//იგივე რაც 3. დავალება
	int Num = 1234;
	int Result;
	int FirstDigit;
	int SecondDigit;
	int ThirdDigit;
	int LastDigit;
	
	FirstDigit = Num / 1000;
}
	
	
