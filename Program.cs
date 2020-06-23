using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criamos uma nova lista do tipo "Produto"      
            List<Produto> produtos = new List<Produto>();
       
            // Criamos um produto para através do construtor padrão
            Produto produto1 = new Produto();
            produto1.Codigo = 1;
            produto1.Nome = "SmartTV LG";
            produto1.Preco = 2300.99f;

            // Adicionamos o produto criado na lista 
            produtos.Add(produto1);

            // Adicionamos mais produtos utilizando o novo construtor
            produtos.Add(new Produto(2, "Geladeira Eletrolux", 6800.90f));
            produtos.Add(new Produto(3, "Microondas Eletrolux", 800.90f));
            produtos.Add(new Produto(4, "Fogão Cromado", 1200.90f));
            produtos.Add(new Produto(5, "Xbox Series X", 16800.90f));
            produtos.Add(new Produto(6, "PS5", 16800.90f));
            
            // Varremos a lista com foreach
            foreach(Produto item in produtos){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0:c} - {1:5}",item.Preco,item.Nome);
                Console.ResetColor();
            }

            // Remover item passando o objeto como argumento
            produtos.Remove(produto1);

            // Remover item pelo índice 
            produtos.RemoveAt(2);

            // Usamos expressão lambda para eliminar um registro 
            produtos.RemoveAll(y => y.Nome == "Microondas Eletrolux");

            // Varremos nossa lista após a alteração
            foreach(Produto item in produtos){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0:c} - {1:5}",item.Preco,item.Nome);
                Console.ResetColor();
            }

            // Podemos encontrar um produto específico utilizando Lambda
            Produto ps5 = produtos.Find(x => x.Codigo == 6);
            Console.WriteLine("PS5 - R$"+ps5.Preco);

            // Aplicando o complemento da atividade:
            List<Cartao> cartoes = new List<Cartao>();

            Cartao visa = new Cartao();
            visa.Titular = "Paulo Brandão";
            visa.NumeroC = 58538423874270479;
            visa.Bandeira = "Visa";
            visa.Vencimento = "05/28";
            visa.CVV = 275;

            cartoes.Add(visa);

            cartoes.Add(new Cartao("João",81238632169,"Visa","02/28",590));
            cartoes.Add(new Cartao("Pedro",712303218731289,"MasterCard","06/24",431));
            cartoes.Add(new Cartao("Lucas",231223121321231,"Elo","05/23",555));
            cartoes.Add(new Cartao("Gabriel",212131312321313,"Cielo","12/25",857));
            cartoes.Add(new Cartao("Carlos",324325322352423,"HiperCard","03/27",345));

            foreach(Cartao c in cartoes){
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Informações do cartão \nTitular: {0} \nNúmero: {1} \nBandeira: {2} \nVencimento: {3} \nCVV: {4}\n",c.Titular,c.NumeroC,c.Bandeira,c.Vencimento,c.CVV);
                Console.ResetColor();
            }





       
        }
    }
}
