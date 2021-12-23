using System;

namespace NumberOperations; 

public class NumberOperations {
	public int Add(int a, int b) {
		return a + b;
	}
	public int Subtract(int a, int b) {
		return a - b;
	}
	public int Multiply(int a, int b) {
		return a * b;
	}
	public int Divide(int a, int b) {
		return a / b;
	}
	public bool IsEven(int a) {
		return a % 2 == 0;
	}
	public bool IsPrime(int a) {
		if (a == 1) {
			return false;
		}
		for (int i = 2; i < a; i++) {
			if (a % i == 0) {
				return false;
			}
		}
		return true;
	}
	public int Distance(int x1, int y1, int x2, int y2) {
		return (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
	}
}