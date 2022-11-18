using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite o valor que você quer procurar");
    int valor = int.Parse(Console.ReadLine());
    double [] elementos ={0,1,2,3,4,5,6,7,8,9,10};
    int inicio = 0;
    int fim = elementos.Length + 1;
    double resultado = busca(elementos, valor, inicio, fim);
    Console.WriteLine(resultado);
  }
  public static int  busca(double [] elementos, int valor, int inicio, int fim){
    int meio = inicio + ((fim - inicio ) /2);
    if (fim < inicio){
      return -1;
    }
    if(valor == elementos[meio]){
      return meio;
    }
    else if (valor < elementos[meio]){
      return busca(elementos, valor,inicio,meio -1);
    }
    else{
      return busca(elementos, valor, fim, meio + 1);
    }
  }
}