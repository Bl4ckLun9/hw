// 1. ორი რიცხვის ჯამი
{
	int a = 10;
	int b = 20;
	int c = 30;
	
	int sumOfTwo = a + b;
}
// 2. სამი რიცხვის ჯამი
{
	int a = 10;
	int b = 20;
	int c = 30;

	int sumOfThree = a + b + c; 
}
// 3. მოცემულია რიცხვი. ავღწეროთ 3 ცვლადი. პირველს მივანიჭოთ მოცემული რიცხვი,
//მეორეს ცვლადს მივანიჭოთ 3-ით მეტი ვიდრე პირველ ცვლადს, მესამე ცვლადში მოვათავსოთ 1-ლი და მე-2 ცვლადის ჯამი.
{
	int num = 5;
	int firstNum;
	int secondNum;
	int res;

        firstNum = num;
        secondNum = firstNum + 3;
        res = firstNum + secondNum;
}
// 4. მოცემულია მთელი რიცხვი a. გამოვაცხადოთ ცვლადი sum და მოვათავსოთ მასში მოცემული a რიცხვის შემდეგი და წინა რიცხვების ჯამი.	
{
	int a = 7;
	int sum;

	sum = (a - 1) + (a + 1);
}
// 5. მოცემულია 2 ცვლადი. გავუცვალოთ ადგილები. (არ გამოვიყენოთ დამატებითი ცვლადი)
{
	int x = 10;
	int y = 20;

	x = x + y;
	y = x - y;
	x = x - y;
}
// 6. ვიპოვოთ მარკუთხედის ფართობი. მოცემულია 2 მთელი დადებითი რიცხვი a და b. ავღწეროთ ცვლადი სახელად area და მივანიჭოთ მართკუთხედის ფართობი.
{
	int a = 4;
	int b = 5;
	int area;

	area = a * b;
}
// 7. პირობა იგივეა რაც მეორე ამოცანაში ოღონდ ვიპოვოთ პერიმეტრი
{
	int a = 4;
	int b = 5;
	int perimeter;

	perimeter = 2 * (a + b);
}
// 8. ფუნთუშა ღირს a ლარი და b თეთრი. გამოთვალეთ რამდენი თეთრი არის გადასახდელი n რაოდენობის ფუნთუშაში. 
//პროგრამაში მოცემულია სამი მთელი რიცხვი: a, b, n შესაბამისად დავთვალოთ რამდენი თეთრი უნდა გადავიხადოთ.
{
	int a = 1;
	int b = 50;
	int n = 10;
	int total;

	total = (a * 100 + b) * n;
}

// 9. N მოსწავლე იყოფს K ვაშლს თანაბრად. მორჩენილი ვაშლები რჩება ისევ კალათაში. რამდენი ვაშლი შეხვდება თითოეულ მოსწავლეს?
{
	int n = 5;
	int k = 15;
	int result;

	result = k / n;
}
// 10. N მოსწავლე იყოფს K ვაშლს თანაბრად. მორჩენილი ვაშლები რჩება ისევ კალათაში. რამდენი ვაშლი დარჩება კალათაში?
{	
	int n = 3;
	int k = 14;
	int result;

	result = k % n;
}
//  11. მოცემულია რიცხვი. ავღწეროთ ცვლადი result. თუ მოცემული რიცხვი ლუწია აღწერილი ცვლადში ჩავწეროთ 0 თუ არა და 1
{
	int num = 7;
	int result;

	result = num % 2;
// 12. მოცემულია რიცხვი. ავღწეროთ ცვლადი result. თუ მოცემული რიცხვი ლუწია აღწერილი ცვლადში ჩავწეროთ 1 თუ არა და 0
{
	int num = 7;
	int result;
	
	result = (num + 1) % 2;
}
}
// 13. მოცემულია მთელი რიცხვი n. result ცვლადში მოვათავსოთ მოცემული რიცხვის შემდეგ მდგომი ლუწი რიცხვი
{
	int n = 200;
	int result;
	
	result = (n + 1) % 2 + n + 1;
}
//14. მოცემულია სამნიშნა რიცხვი, აღვვწეროთ სამი ცვლადი a1, a2, a3, მოვათავსოთ აღწერილ ცვლადებში რიცხვის ციფრები.
{
	int number = 127;
	int a1;
	int a2;
	int a3;

	a1 = number / 100;
	a2 = (number / 10) % 10;
	a3 = number % 10;
}
//15. მოცემულია მთელი ორნიშნა რიცხვი, აღვწეროთ result ცვლადი და მასში მოვათავსოთ მოცემული რიცხვის ციფრების ჯამი.
{
	int number = 97;
	int result;
	int firstDigit;
	int lastDigit;
	
	firstDigit = number / 10;
	lastDigit = number % 10;
  	result = firstDigit + lastDigit;
}
//16. მოცემულია ოთხნიშნა რიცხვი, აღვწეროთ result ცვლადი და მასში მოვათავსოთ მოცემული რიცხვის ლუწი ციფრების ჯამი.
{
	int num = 1234;
	int result;
	int firstDigitForEven;
	int secondDigitForEven;
	int thirdDigitForEven;
	int fourthDigitForEven;	
	
	
	firstDigitForEven = ((num / 1000) % 2 - 1) * -1 * (num / 1000);
	secondDigitForEven = (((num / 100) % 10) % 2 - 1) * -1 * (num / 100) % 10;
	thirdDigitForEven = (((num / 10) % 10) % 2 - 1) * -1 * (num / 10) % 10;
	fourthDigitForEven = ((num % 10) % 2 - 1) * -1 * (num % 10);
		
	result = firstDigitForEven + secondDigitForEven + thirdDigitForEven + fourthDigitForEven;
}
/*17. მოცემულია 2 ნატურალური რიცხვი n და m. თუ ერთი იყოფა მეორეზე მთელად გამოვიტანოთ 1 თუ არა და ნებისმიერი სხვა რიცხვი. მოვათავსოთ result ცვლადში ამოცანის შედეგი
მაგალითები:
Input Output
2 8 1
Input Output
8 2 1
*/
{
	int n = 4;
	int m = 8;
	int remainOfN;
	int remainOfM;
	int result;
	
	remainOfN = n % m;
	remainOfM = m % n;

	result = remainOfN * remainOfM + 1;
	
	
}

/*მოცემულია რიცხვი, თუ დადებითია იგივე რიცხვი შევინახოთ რეზალტში, თუ უარყოფითია დადებითად ვაქციოთ და ეგ შევინახოთ
9 -> 9
-17-> 17*/
{

	
	
}
