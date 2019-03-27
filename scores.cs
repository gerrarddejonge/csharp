/*
 * File:      scores.cs
 * Copyright: (c) 2019 Gerrard de Jonge <development.gdj@netvisit.nl>
 * License:   GPLv2 (see file COPYING)
 *
 * 
 * Description
 * You have to prepare the algorithm for the application.
 * Your application should do the following:
 * 
 * 1) Read the first name, last name, and four exam grades for each student from the input file “input_File.txt”.
 * 
 * 2) Calculate the average grade for each student.
 * 
 * 3) Find the corresponding letter grade as per the calculated average as the following.
 * 
 * a. From 90 to 100: A
 * b. From 80 to 89.9: B
 * c. From 70 to 79.9: C
 * d. From 60 to 69.9: D
 * e. From 50 to 59.9: F
 * f. Below 50: U
 * 
 * 4) Output the students’ first name, last name, average score, and corresponding letter grade in the output file “output_File.txt”.
 * 
 * The program’s input will look like the following (for example):
 * 
 * Ali Ahmad 78.3 67.2 72.6 65.2
 * Sami Ashraf 45.2 69.6 60.5 71.1
 * Mona Abdelghani 98.4 41.2 88.3 90.4
 * Samah Mohammad 76.8 74.2 66.8 79.1
 * Salem Hani 89.8 84.2 87.5 81.9
 * Arwa Farid 55.5 58.4 59.3 52.2
 * Salah Naser 97.2 94.1 92.1 91.5
 * 
 * 6) The output for this input file should be as the following
 * 
 * Ali Ahmad Average: 70.82 Grade: C
 * Sami Ashraf Average: 61.60 Grade: D
 * Mona Abdelghani Average: 79.58 Grade: C
 * Samah Mohammad Average: 74.22 Grade: C
 * Salem Hani Average: 85.85 Grade: B
 * Arwa Farid Average: 56.35 Grade: F
 * Salah Naser Average: 93.72 Grade: A
 */ 
 
using System;
using System.Collections.Generic;
  
class Student {
	public string firstname;
	public string familyname;
	public List<double> scores;
	public double Avg {
		get {
			double total = 0;
			foreach (var item in scores) {
				total += item;
			}
			return total / scores.Count;
		}
	}
	public char Score { 
		get {
			if (Avg >= 90) return 'A';
			else if (Avg >= 80) return 'B';
			else if (Avg >= 70) return 'C';
			else if (Avg >= 60) return 'D';
			else if (Avg >= 50) return 'F';
			else return 'U';
		}
	}
	
	public Student(string name, string fname) {
		firstname  = name;
		familyname = fname;
		scores = new List<Double>();
	}
	
	public override string ToString() => firstname + " " + familyname;
}
 
 
class Program {
	public static void Main() {
		const string infile  = "input_file.txt";
		const string outfile = "output_file.txt";
		List<Student> students = new List<Student>();
		
		ReadFile(students, infile);
		
		WriteFile(students, outfile);
		
	}
	
	public static void ReadFile(List<Student> students, string filename) {
		string line;
		System.IO.StreamReader file = new System.IO.StreamReader(filename);  
		while((line = file.ReadLine()) != null)  
		{  
			line = line.Trim();
			if (!string.IsNullOrEmpty(line))
			{
				var lines = line.Split(' ');
				var stud = new Student(lines[0], lines[1]);
				stud.scores.Add(float.Parse(lines[2]));
				stud.scores.Add(float.Parse(lines[3]));
				stud.scores.Add(float.Parse(lines[4]));
				stud.scores.Add(float.Parse(lines[5]));
				students.Add(stud);
			}
		}  
		file.Close();  
	}
	
	public static void WriteFile(List<Student> students, string filename)
	{
		System.IO.StreamWriter file = new System.IO.StreamWriter(filename);
		foreach (var item in students) {
			file.WriteLine($"{item} Average: {item.Avg:F2} Grade: {item.Score}");
		}
		file.Close();
	}

}
