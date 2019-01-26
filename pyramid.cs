/*
 * File:      pyramid.cs
 * Copyright: (c) 2019 Gerrard de Jonge <development.gdj@netvisit.nl>
 * License:   GPLv2 (see file COPYING)
 *
 *
 * Description
 *            Prints a pyramid for a given height
 *
 * Example
 *            Enter height [4-20]: 5
 *               /\
 *              /  \
 *             /    \
 *            /      \
 *           ----------
 */

 
using System;

 
class Pyramid {
	public int height {get; set;}
	
	public Pyramid(int h) {
		height = h;
	}
	
	public void GetHeight() {
		while (height < 4 || height > 20) {
			Console.Write("Enter height [4-20]: ");
			height = Int32.Parse(Console.ReadLine());
		}
	}

	public string PadSymbol(char symbol, int times) {
		var str = "";
		for (int i = 0; i < times; i++) {
		  str += symbol;
		}
		return str;
	}

	public void PrintTriangle() {
		var line = "*";

		for (int i = 0; i < height-1; i++) {
			line = PadSymbol(' ', height-i-1) + '/' + PadSymbol(' ', i*2) + '\\';
			Console.WriteLine($"{line}");
		}
		line = PadSymbol('-', height*2);
		Console.WriteLine($"{line}");
	}
	
}
 
class Program {
	public static void Main() {
		var pyramid = new Pyramid(0);
		
		pyramid.GetHeight();
		pyramid.PrintTriangle();
	}
}
