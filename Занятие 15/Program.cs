using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_15
{
	
	class Program
	{
		public static void Main(string[] args)
		{
			Console.ReadKey();
		}
	}

	interface ISeries
	{
		void SetStart(int x);
		int GetNext();
		void Reset();
	}

	class ArithProgression : ISeries
	{
		
		int x = 0; //начальное значение
		int d = 1; //разность арифметической прогрессии

		public void SetStart(int x) // метод устанавливает начальное значение
		{
			x = Convert.ToInt32(Console.ReadLine());			
		}

		public int GetNext() //возвращает следующее число ряда
		{
			int secondNumber = x + d;
			return secondNumber;
		}

		public void Reset() //выполняет сброс к начальному значению
		{
			int firstNumber = x - d;
		}
	}

	class GeomProgression : ISeries
	{
		int x = 0; //начальное значение
		int k = 2; //шаг геометрической прогрессии

		public void SetStart(int x) // устанавливает начальное значение
		{
			x = Convert.ToInt32(Console.ReadLine());			
		}

		public int GetNext() //возвращает следующее число ряда
		{
			int secondNumber = x * k;
			return secondNumber;
		}

		public void Reset() //выполняет сброс к начальному значению
		{
			int firstNumber = x / k;
		}
	}
}

