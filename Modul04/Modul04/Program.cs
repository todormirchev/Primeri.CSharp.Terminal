﻿using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			string[,] _table = {
				{"Иван", "Георгиев", "19"},
				{"Васил", "Иванов", "23"},
				{"Милен", "Георгиев", "58"},
				{"Цветан", "Борисов", "14"},
				{"Гергана", "Василева", "25"},
				{"Ивана", "Христова", "21"}

			};

			//Антетка на таблица
			Console.WriteLine("Име".PadRight(12) + "Фамилия".PadRight(12) + "Години".PadRight(12) );
			Console.WriteLine("===============================");


			//Тяло на таблица

			//Пример с for
			//for (int i = 0; i < _table.Length/3; i++ )
			//{
			//	for (int j = 0; j < 3; j++)
			//	{
			//		Console.Write(_table [i,j].PadRight(12));
			//	}
			//	Console.WriteLine();

			//}


			//Пример с while
			//int i = 0;
			//while (i<_table.Length/3)
			//{
			//	Console.WriteLine(_table[i,0].PadRight(12)  + 
			//	                  _table[i, 1].PadRight(12) + 
			//	                  _table[i, 2].PadRight(12));
			//	i++;
			//}


			//Пример с DO...While
			int i = 0;
			do
			{
				Console.WriteLine(_table[i, 0].PadRight(12) +
					                  _table[i, 1].PadRight(12) + 
					                  _table[i, 2].PadRight(12));
				i++;
			} while(i<_table.Length/3);



		}
	}
}
