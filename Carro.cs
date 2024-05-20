using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //Classe
    public class Carro(string modelo, int ano, string placa, double velocidadeAtual, string cor)
    {
        //Para criar o atributo abaixo, digite prop<tab><tab> que ele monta o atributo com os gets e sets
        public string Modelo { get; set; } = modelo;
        public string Cor { get; set; } = cor;
        public int Ano { get; set; } = ano;
        public string Placa { get; set; } = placa;
        public double VelocidadeAtual { get; set; } = velocidadeAtual;


        //Metodos - São as ações que o objeto pode fazer
        public void Acelerar(double Incremento)
        {
            this.VelocidadeAtual += Incremento;
        }
    }
}