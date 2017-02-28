using System;

namespace Moreniell.ArithmeticTrainer
{
	public class Example
	{
		public double First { get; }
		public double Second { get; }

		public char Operation { get; }
		
		public Example(double first, char operation, double second)
		{
			if (operation == '-')
			{
				First  = Math.Max(first, second);
				Second = Math.Min(first, second);
			}
			else
			{
				First = first;
				Second = second;
			}
			Operation = operation;
		}

		public double Answer
		{
			get
			{
				switch (Operation)
				{
					case '+':
						return First + Second;
					case '-':
						return First - Second;
					case '*':
						return First * Second;
					case '/':
						// IDEA: Версия для примеров с дробной частью.
						// return Math.Round(First / Second, 2);
						return First / Second;
					default:
						throw new InvalidOperationException("Неизвестная операция " + Operation);
				}
			}
		}
		
		public bool EqualsToAnswer(double solve)
		{
			return Answer.Equals(solve);
		}
		
		public override string ToString()
		{
			return $"{First} {Operation} {Second}".Replace("*", "×").Replace("/", "÷");
		}

		public override bool Equals(object obj)
		{
			return Equals((Example)obj);
		}

		protected bool Equals(Example other)
		{
			return First.Equals(other.First) && Second.Equals(other.Second) && Operation == other.Operation;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hashCode = First.GetHashCode();
				hashCode = (hashCode*397) ^ Second.GetHashCode();
				hashCode = (hashCode*397) ^ Operation.GetHashCode();
				return hashCode;
			}
		}
	}
}