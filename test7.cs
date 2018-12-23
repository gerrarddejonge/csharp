using System;

class test {
	static void Main() {

		int a = 5;
		int b = 7;
		int c = a + b;
		if (c > 10) {
			Console.WriteLine($"The answer {c} is greater than 10.");
		} else {
			Console.WriteLine($"The answer {c} is less than or equal to 10.");
		}
	}
}
