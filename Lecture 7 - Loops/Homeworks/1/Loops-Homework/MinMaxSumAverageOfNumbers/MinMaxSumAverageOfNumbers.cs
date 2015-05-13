//Write a program that reads from the console a sequence of n integer numbers 
//and returns the minimal, the maximal number, the sum and the average of all numbers 
//(displayed with 2 digits after the decimal point). 
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 
//The output is like in the examples below.

using System;
using System.Collections.Generic;
using System.Linq;

class MinMaxSumAverageOfNumbers
{
	static void Main ()
	{
		int N = int.Parse (Console.ReadLine ());
		List<int> numbers = new List<int> ();
		int min, max, sum = 0;
		double average;

		for (int i = 0; i < N; i++) {
			numbers.Add(int.Parse(Console.ReadLine()));
			sum += numbers [i];
		}

		min = numbers.Min ();
		max = numbers.Max ();
		average = (double)sum / numbers.Count;

		Console.WriteLine ("min = {0}\nmax = {1}\nsum = {2}\naverage = {3:0.00}", min, max, sum, average);
	}
}