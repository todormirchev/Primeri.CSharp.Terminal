﻿using System;
using System.Collections.Generic;

namespace ListExplore
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Дефиниции
			string _userinput = "";
			List<int> _list = new List<int>();

			_list.Add(5);
			_list.Add(3);
			_list.Add(9);




			//Потребителски вход
			do
			{
				Console.Write("? ");
				_userinput = Console.ReadLine();

				//Добавяне на стойнисти


				//Преглед на листа
				if (_userinput.Contains("show"))
				{
					Console.Write("List: ");
					for (int i = 0; i < _list.Count; i++)
					{
						Console.Write(_list[i]);

						if (i != _list.Count - 1) Console.Write(", ");

					}
					Console.WriteLine();
				}


				//Размер на листа 



			} while (_userinput!= "exit");


		}
	}
}