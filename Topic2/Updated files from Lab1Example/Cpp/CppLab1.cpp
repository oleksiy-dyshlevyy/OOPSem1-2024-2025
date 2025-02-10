// CppLab1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include "MyCppClass.h"
#include <iostream>

using namespace std;

//struct Data
//{
//    int* var1;
//    char* str1;
//
//    int* DoSomething();
//    float* DoSomethingElse(int, float);
//};

//int* SomeActivity()
//{
//    int a = 0;
//    return &a;
//}

int myvar = 500;

int MyFynction(int param)
{
    int a = param;
    a++;
    int b = 0;
    myvar = 1000;
    for (int i = 0; i < param; i++)
        b++;
    if (b < param)
    {
        int c = 100;
        a = c;
        myvar = 30000;
    }
   // a = c;
    return a;
}


int main()
{
    int a = 5;
    int result = MyFynction(a);

   /* Data* myData = new Data();
    myData->DoSomething = SomeActivity;*/

    MyCppClass myObj;
    myObj.a = 10;
    myObj.Method1();
    
    cout << myObj.Method2();

    MyCppClass* myObj1 = new MyCppClass();
    myObj1->a = 10;

    std::cout << "Hello World!\n";
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
