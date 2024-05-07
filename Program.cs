﻿using ParkingSystem.NET.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento estacionamento = new(precoInicial, precoPorHora);

string opcao;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    do
    {
        opcao = Console.ReadLine();
        if (string.IsNullOrEmpty(opcao))
        {
            Console.WriteLine("Por favor, digite uma opção!");
        }
    } while (string.IsNullOrEmpty(opcao));

    switch (opcao)
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;

        case "2":
            estacionamento.RemoverVeiculo();
            break;

        case "3":
            estacionamento.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }

    if (opcao == "2" || opcao == "3")
    {
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
    }
}

Console.WriteLine("Encerrando Sistema...");
Console.WriteLine("Obrigado por Estacionar seu Veículo conosco!");
Console.WriteLine("Volte Sempre!");
