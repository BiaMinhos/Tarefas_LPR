#include <iostream>
using namespace std;

int main()
{
    int num1, num2;
    cout << "Insira dois numeros separados por um enter:\n";
    cin >> num1;
    cin >> num2;

    if (num1 % num2 == 0 || num2 % num1 == 0) {
        cout << "Os números são múltiplos";
    }
    else {
        cout << "Os números não são múltiplos";
    }
}
