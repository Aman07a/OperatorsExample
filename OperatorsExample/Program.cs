using System;

namespace OperatorsExample
{
	class Program
	{
		static void Main(string[] args)
		{
			// Arithmetical Operators
			decimal a = 10M;
			decimal b = 3M;
			// Output: 13
			decimal c = a + b;
			// Output: 7
			decimal d = a - b;
			// Output: 30
			decimal e = a * b;
			// Output: 3.33
			decimal f = a / b;
			// Output: 1
			decimal g = a % b;

			System.Console.WriteLine(c);
			System.Console.WriteLine(d);
			System.Console.WriteLine(e);
			System.Console.WriteLine(f);
			System.Console.WriteLine(g);

			// Assignment Operators
			a += 20M;
			// Output: 30
			System.Console.WriteLine(a);
			a -= 20M;
			// Output: 10
			System.Console.WriteLine(a);
			a *= 3M;
			// Output: 30
			System.Console.WriteLine(a);
			a /= 3M;
			// Output: 10
			System.Console.WriteLine(a);
			a %= 3M;
			// Output: 1
			System.Console.WriteLine(a);

			// Increment / Decrement Operators
			a = 10M;
			System.Console.WriteLine();
			// Output: 11
			System.Console.WriteLine(++a);
			// Output: 11
			System.Console.WriteLine(a++);
			// Output: 12
			System.Console.WriteLine(a);
			// Output: 11
			System.Console.WriteLine(--a);
			// Output: 11
			System.Console.WriteLine(a--);
			// Output: 10
			System.Console.WriteLine(a);

			// Comparison Operators
			System.Console.WriteLine();

			bool b1 = a == 10;
			// Output: true
			System.Console.WriteLine(b1);

			bool b2 = a != 10;
			// Output: false
			System.Console.WriteLine(b2);

			bool b3 = a < 10;
			// Output: false
			System.Console.WriteLine(b3);

			bool b4 = a > 10;
			// Output: false
			System.Console.WriteLine(b4);

			bool b5 = a <= 10;
			// Output: true
			System.Console.WriteLine(b5);

			bool b6 = a >= 10;
			// Output: true
			System.Console.WriteLine(b6);

			// Logical Operators
			System.Console.WriteLine();

			bool b7 = a == 10 & b == 10;
			// Output: false
			System.Console.WriteLine(b7);

			bool b8 = a == 10 && b == 10;
			// Output: false
			System.Console.WriteLine(b8);

			bool b9 = a == 10 | b == 10;
			// Output: true
			System.Console.WriteLine(b9);

			bool b10 = a == 10 || b == 10;
			// Output: true
			System.Console.WriteLine(b10);

			bool b11 = !(a == 10);
			// Output: false
			System.Console.WriteLine(b11);

			bool b12 = a == 10 ^ b == 10;
			// Output: true
			System.Console.WriteLine(b12);

			// Concatenation Operator
			System.Console.WriteLine();
			string name = "Scott";
			int age = 20;
			string message = "Hey " + name + ", your age is " + age + ".";
			System.Console.WriteLine(message);

			// Ternary Operator
			string title = (age < 13) ? "Child" : (age >= 13 && age < 19) ? "Teenager" : "Adult";
			System.Console.WriteLine(title);

			// Operator Precedence
			double z = 10 + 4 * 30 / 10;
			// Output: 22
			System.Console.WriteLine(z);

			System.Console.ReadKey();
		}
	}
}
