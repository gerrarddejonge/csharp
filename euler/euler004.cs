/*
 * Project Euler  <https://projecteuler.net>
 *
 * Problem 4
 *
 * A palindromic number reads the same both ways.
 * The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 * Find the largest palindrome made from the product of two 3-digit numbers.
 *
 */

using System;

struct Palindrome {
	public int product;
	public int factor1;
	public int factor2;
	public Palindrome(int p, int f1, int f2) {
		product = p;
		factor1 = f1;
		factor2 = f2;
	}
};

class Program {
	static void Main() {
		const int highest = 999;
		const int lowest = 100;
		Palindrome largest = new Palindrome(0, 0, 0);

		for (int i = highest; i >= lowest; --i) {
			for (int j = highest; j >= lowest; --j) {
				int prod = i * j;
				if (ispalindrome(prod)) {
					if (prod > largest.product) {
						largest.product = prod;
						largest.factor1 = i;
						largest.factor2 = j;
					}
				}
			}
		}
		Console.WriteLine($"The largest palindrome {largest.product} is product of {largest.factor1} and {largest.factor2}");
	}

	static bool ispalindrome(int x) {

	String str = x.ToString();
	int i = 0;
	int j = str.Length - 1;
	while (i < j) {
		if (str[i] != str[j])
			return false;
		++i;
		--j;
	}
	return true;
	}
}
