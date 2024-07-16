using Dio.Common.Models;


int[] arrayInteiros = new int[3];


List<string> listaString = new List<string>();
listaString.Add("SP");
listaString.Add("BH");
listaString.Add("MG");

for(int contador = 0; contador < listaString.Count; contador++)
{
  Console.WriteLine($"Posicao Nº {contador} -- {listaString[contador]}");
}

int contadorForeach = 0;
foreach(string item in listaString)
{
  Console.WriteLine($"Posicao Nº {contadorForeach} - {item}");
  contadorForeach++;
}



//arrayInteiros[0] = 72;
//arrayInteiros[1] = 64;
//arrayInteiros[2] = 50;

//int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
//Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


//arrayInteiros[3] = 1;
//Array.Resize(ref arrayInteiros,  6);
//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
//Console.WriteLine($"{arrayInteiros.Length}");


//percorrendo o array com o FOR, necessario declarar contador e limite.
//for(int contador = 0; contador < arrayInteiros.Length; contador++)
//{
  //Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
//} 

//percorrendo o array com o FOREACH, não necessario de um contador nem acapacidade limite.
//foreach(int valor in arrayInteiros)
//{
  //Console.WriteLine(valor);
//}



//string opcao;
//bool exibirMenu = true;

//while(exibirMenu)
//
 //   Console.Clear();
   // Console.WriteLine("Digite a sua opção:");
    //Console.WriteLine("1 - Cadastro de Cliente");
    //Console.WriteLine("2 - Buscar Cliente");
    //Console.WriteLine("3 - Apagar Cliente");
    //Console.WriteLine("4 - Encerrar");

    //opcao = Console.ReadLine();

    //switch(opcao)
    //{
        //case "1":
          //  Console.WriteLine("Cadastro de Cleinte");
            //break;
        
        //case "2":
          //  Console.WriteLine("Buscar Cliente");
            //break;
        
        //case "3":
          //  Console.WriteLine("Apagar Cliente");
            //break;

        //case "4":
          //  Console.WriteLine("Encerrar");
            //exibirMenu = false;
            //break;

        //default:
          //  Console.WriteLine("Opção invalida");
            //break;
    //}
//}




//int numero = 35;
//int contador = 0;

//while(contador <= 10)
//{
    //Console.WriteLine($"{numero} x {contador} = {numero * contador}");
  //  contador++;
//}

//for(int contador = 0; contador <= 10; contador++)
//{
  //  Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//}




//Console.WriteLine("Digite uma letra");
//string letra = Console.ReadLine();

//switch (letra)
//{
    //case "a":
    //case "e":
    //case "i":
    //case "o":
    //case "u":
        //Console.WriteLine("vogal");
      //  break;

    //default:
        //Console.WriteLine("Não é uma vogal");
  //      break;
//}



//int quantidadeEstoque = 10;
//int quantidadeVendas = 0;
//bool possivelVenda = quantidadeVendas > 0 && quantidadeEstoque >= quantidadeVendas;

//Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
//Console.WriteLine($"Quantidade compra: {quantidadeVendas}");
//Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

//if (quantidadeVendas == 0)
//{
    //Console.WriteLine("Venda invalida");
//}
//else if (possivelVenda)
//{
    //Console.WriteLine("Venda realizada");
//}
//else
//{
    //Console.WriteLine("Desculpe mas, não temos produtos suficientes em estoque.");
//}











//Pessoa pessoaTeste = new Pessoa();

//pessoaTeste.Nome = "Jubileu";
//pessoaTeste.Idade = 29;
//pessoaTeste.Apresentar();