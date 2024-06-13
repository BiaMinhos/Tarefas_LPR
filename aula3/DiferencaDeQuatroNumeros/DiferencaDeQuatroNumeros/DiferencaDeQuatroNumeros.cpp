#include <iostream>
#include <string>
#include <iomanip>
using namespace std;
int main()
{
	int a, b, c, d;

	cout << "Insira separadamente por um enter, 4 numeros " << endl;
	cin >> a;
	cin >> b;
	cin >> c;
	cin >> d;
	cout << fixed << setprecision(4) << "A diferenca do produto de A e B por C e D e: " << (a*b - c*d) << endl;

}