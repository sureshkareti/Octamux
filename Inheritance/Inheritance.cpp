// Inheritance.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

class A
{
private:
	int a;
public:
	A(int x = 0) :a(x)
	{}	
};

class B :public A
{
private:
	int b;
public:
	B(int x = 0, int y = 0) :A(x), b(y)
	{}
};

class C : public B
{
private:
	int c;
public:
	C(int x = 0, int y = 0, int z = 0) : B(x, y), c(z)
	{}
	void display()
	{
		cout << c;
	}
};
int main()
{
	C obj(10,20,30);
	obj.display();
//	obj.a = 10;
//	obj.b = 20;
//	obj.c = 30;
    return 0;
}

