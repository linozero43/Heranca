﻿//Heranca - Uma classe pode pegar todos os atributos e metodos de outra classe

//Carro - Modelo, Marca, Quilometragem
//CarroEletrico - Bateria, TempoDeCarga
//CarroCombustao - Combustivel

//

//using Heranca;

//CarroEletrico carroE = new CarroEletrico();
//carroE.marca = "BYD";
//carroE.bateria = 200;

//CarroCombustao carroC = new CarroCombustao();
//carroC.marca = "Peujeot";
//carroC.combustivel = "Diesel";


//Carro meuCarro;

//Console.WriteLine("Digite E - para ELETRICO ou Digite C - para Combustao");
//string opcao = Console.ReadLine();

//if (opcao == "E")
//{
//    meuCarro = new CarroEletrico();
//}
//else if (opcao == "C")
//{
//    meuCarro = new CarroCombustao();
//}

//using Heranca;

//PessoaF pFis = new PessoaF();
//pFis.nome = "Jurandir";
//pFis.CPF = "40028922";

//PessoaJ pJur = new PessoaJ();
//pJur.nome = "YudiPLAYStory";
//pJur.CNPJ = "741258963/0002-84";



using Heranca;

Carro car1 = new Carro();

CarroEletrico carE = new CarroEletrico();

car1.modelo = "Fusca";
car1.marca = "Volkswagem";
car1.quilometragem = 5000;

carE.modelo = "Tesla Model S";
carE.marca = "Tesla";
carE.quilometragem = 1000;
carE.bateria = 200;
carE.tempoDeCarga = 50;

carE.MostrarInfo("Juriscreide");










