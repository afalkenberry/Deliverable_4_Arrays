// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;


//array for the for loop
int[] Fib = new int[] { };
int length2 = 27;
int firstInt = 0;
int secondInt = 1;
Fib = Fib.Append(firstInt).ToArray();
Fib = Fib.Append(secondInt).ToArray();

//array while loop
int[] Fib_2 = new int[] {};
int length = 26;
int Fib_firstInt = 0;
int Fib_secondInt = 1;
Fib_2 = Fib_2.Append(Fib_firstInt).ToArray();
Fib_2 = Fib_2.Append(Fib_secondInt).ToArray();





//Solving problem with while loop
while (Fib_2.Length < length)
{
	int x = Fib_2[Fib_2.Length - 1] + Fib_2[Fib_2.Length - 2];
	Fib_2 = Fib_2.Append(x).ToArray();
}


//Solving problem with for loop
int count = 0;
for (int i = 2; i < length2 - 1; i++)
{
	if (i <= length2)
	{
		int x = Fib[i - 1] + Fib[i - 2];
		Fib = Fib.Append(x).ToArray();
		count++;

	}


}


//display array results for both loops
for (int j = 0; j < Fib_2.Length; j++)
{
	foreach (int item in Fib_2)
	{
		
		Console.WriteLine(String.Format("Fibonacci number [{0}] is = {1}", j, Fib_2[j]));

		if (Fib_2.Length == length) //not sure why but if operand is anything other than "==" it loops through displaying each array item 25 times
		{
			break;
		}


	}
}

Console.WriteLine("\n");


	for (int k = 0; k < Fib.Length; k++)
	{
		foreach (int item1 in Fib)
		{
			Console.WriteLine(String.Format("Fibonacci number [{0}] is = {1}", k, Fib[k]));

			if (Fib.Length < length2)
			{
				break;
			}
		}
	}

	



	
	




