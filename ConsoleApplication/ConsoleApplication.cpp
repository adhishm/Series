// ConsoleApplication.cpp : main project file.

#include "stdafx.h"

using namespace System;
using namespace MathSeries;

int main(array<System::String ^> ^args)
{
	int nTerms = 20;

	array<int,1> ^terms = gcnew array<int>(nTerms);
	Console::WriteLine(L"Fibonacci Series");
	MathematicalSeries::FibonacciSeries(nTerms, terms);
	for (int i = 0; i < nTerms; i++)
	{
		Console::WriteLine(terms[i].ToString());
	}

	array<double, 1> ^dTerms = gcnew array<double>(nTerms);
	Console::WriteLine(L"Geometric series");
	MathematicalSeries::GeometricSeries(nTerms, 1.0, -1.5, dTerms);
	for (int i = 0; i < nTerms; i++)
	{
		Console::WriteLine(dTerms[i].ToString());
	}

    return 0;
}
