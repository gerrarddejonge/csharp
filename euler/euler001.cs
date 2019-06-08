/*
 * Project Euler  <https://projecteuler.net>
 *
 * Problem 1
 *
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * Find the sum of all the multiples of 3 or 5 below 1000.
 *
 */

using System;


class Program {
	static void Main() {
		int EULIMIT = 1000;
		int total = 0;

		for (int i = 1; i < EULIMIT; i++) {
			if (i % 3 == 0 || i % 5 == 0) {
				total += i;
			}
		}

		Console.WriteLine("The sum is {0}.", total);
	}
}
