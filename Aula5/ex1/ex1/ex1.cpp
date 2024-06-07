#include <iostream>
#include <string>
#include <iomanip>
using namespace std;
int main()
{
	int numero;
	
	cout << "Entre com o seu numero para saber se ele eh par ou impar: ";
	cin >> numero;
	if (numero % 2 == 0) {
		cout << "O numero eh par" << endl;
	}
	else {
		cout << "O seu numero eh impar" << endl;
	}
}
