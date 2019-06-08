/*
 * Project Euler  <https://projecteuler.net>
 *
 * Problem 6
 *
 *
 * The sum of the squares of the first ten natural numbers is,
 *    1^2 + 2^2 + ... + 10^2 = 385
 * The square of the sum of the first ten natural numbers is,
 *    (1 + 2 + ... + 10)^2 = 55^2 = 3025
 *
 * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
 * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 *
 */

using System;


class Program {
	static void Main() {
		int total1 = sumofthesquares(100);
		int total2 = squareofthesum(100);

		Console.WriteLine("The difference between {0} and {1} is {2}", total1, total2, total2 - total1);
	}
	static public int sumofthesquares(int x) {
		int sum = 0;
		for (var i = 1; i <= x; ++i) {
			sum = sum + (i*i);
		}
		return sum;
	}
	static public int squareofthesum(int x) {
		int sum = 0;
		for (var i = 1; i <= x; ++i) {
			sum = sum + i;
		}
		return (sum * sum);
	}
}
