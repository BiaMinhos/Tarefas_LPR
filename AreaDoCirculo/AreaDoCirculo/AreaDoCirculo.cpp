#include <iostream>
#include <string>
#include <iomanip>
using namespace std;
int main()
{
	system("chcp 1252 > nul");
	float raio;
	float pi = 3.14159f;

	cout << "Insira seu valor de raio." << endl;
	cin >> raio;
	cout << fixed << setprecision(4) << "O valor da area desse circulo e: " << (pi * raio * raio) << endl;

}