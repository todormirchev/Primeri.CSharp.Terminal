using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main(string[] args)
		{


			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;

			//Събиране на числа
			a = 10;
			b = 5;

			sum = a + b;

			//Писане в конзола
			Console.Write(a);
			Console.Write(" + ");
			Console.Write(b);
			Console.Write(" = ");
			Console.WriteLine(sum);

			//допълнителни оператори
			Console.WriteLine("\n Използване на +=");
			a += b;//a=a+b
			Console.WriteLine(a);

			Console.WriteLine("\n Използване на -=");
			a -= b;//a=a-b
			Console.WriteLine(a);

			Console.WriteLine("\n Използване на *=");
			a *= b;//a=a+b
			Console.WriteLine(a);

			Console.WriteLine("\n Използване на ++");
			a++;//a=a+b
			Console.WriteLine(a);

			Console.WriteLine("Стандартно делене: " + (14/4).ToString ());
			Console.WriteLine("Остатък делене: " + (14 % 4).ToString());
		}
	}
}
