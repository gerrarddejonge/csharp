/*
 * File:      test5.cs
 * Copyright: (c) 2018 Gerrard de Jonge <development.gdj@netvisit.nl>
 * License:   GPLv2 (see file COPYING)
 *
 *
 * Description
 *            Testing some more array functions
 */
 
 using System;

class Test  
{  
	static void Main() {  
		int[] a1 = new int[] {1, 2, 3};  
		int[,] a2 = new int[,] {{1, 2, 3}, {4, 5, 6}};  
		int[,,] a3 = new int[10, 20, 30];  
		int[][] j2 = new int[3][];  
		j2[0] = new int[] {1, 2, 3};  
		j2[1] = new int[] {1, 2, 3, 4, 5, 6};  
		j2[2] = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};  
		
		
		for (int j = 0; j < 3; j++) {
		
			for (int i = 0; i < j2[j].Length; i++) {
				Console.Write("{0} ", j2[j][i]);
			}
			Console.WriteLine("");
		}
	}  
}  
 
