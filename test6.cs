/*
 * File:      test6.cs
 * Copyright: (c) 2018 Gerrard de Jonge <development.gdj@netvisit.nl>
 * License:   GPLv2 (see file COPYING)
 *
 */
 
 using System;

class test {
	static void Main() {

		double radius = 2.50;
		double area = Math.PI * radius * radius;
		Console.WriteLine(area);
		
		decimal radius1 = 2.50M;
		decimal pi = (decimal) Math.PI;
		decimal area1 = pi * radius1 * radius1;
		Console.WriteLine(area1);
		
	}
}

