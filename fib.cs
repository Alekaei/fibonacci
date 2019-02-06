using System;

namespace fibonacci {
	public class Program {
		static void Main (string[] args) {
			Console.WriteLine(Program.fib(10));
		}
		static int fib(n) {
			if (n <= 1) return n;
			return fib(n - 1) + fib(n - 2);
		}
	}
}