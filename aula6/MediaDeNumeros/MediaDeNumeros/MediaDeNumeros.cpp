#include <iostream>
#include <string>
#include <iomanip>
using namespace std; 
int main()
{
    double soma = 0; int qtd = 0; int qtd_num;;
    cout << "Digite a quantidade de numeros analisados: ";
    cin >> qtd_num;
    int cont = 0;
    while (cont < qtd_num) {
        cout << "Digite o numero analisado" << endl;
        int num_analisado;
        cin >> num_analisado;
        if (num_analisado%2==0) {
            soma += num_analisado;
            qtd++;
        }
        cont++;
    }
    double media = soma / qtd;
    cout << "A media eh: " << media << endl;
}
