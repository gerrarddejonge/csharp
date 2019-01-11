/*
 * File:      christmas.cs
 * Copyright: (c) 2019 Gerrard de Jonge <development.gdj@netvisit.nl>
 * License:   GPLv2 (see file COPYING)
 *
 *
 * Description
 *            Prints a christmas tree for a given height
 *
 * Example
 *            Enter height [4-20]: 5
 *               *
 *              ***
 *             *****
 *            *******
 *           *********
 *               *
 */
 
 
using System;


class XMas {
	public int height {get; set;}
	
	public XMas() {
		height = 0;
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
	
	public void PrintTree() {
		var star = "*";
		for (int i = 0; i < height; i++) {
			star = PadSymbol(' ', height-i-1) + PadSymbol('*', i*2+1);
			Console.WriteLine($"{star}");
		}
		star = "*".PadLeft(height);
		Console.WriteLine($"{star}");
	}
}


class Program {
	public static void Main() {
		var xmas = new XMas();
		
		xmas.GetHeight();
		xmas.PrintTree();
	}
}
