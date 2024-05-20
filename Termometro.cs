using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //Classe
    public class Termometro
    {
        //Para criar o atributo abaixo, digite prop<tab><tab> que ele monta o atributo com os gets e sets
        private double Temperatura { get; set; }
        private double TemperaturaMinima { get; set; }
        private double TemperaturaMaxima { get; set; }
        private int TemperaturaCelsius { get; set; }
        
        // Construtor é o contrato que você precisa definir como o objeto será criado, mas vc pode criar o construtor vazio, aí vc precisa definir na criação do objeto.
       public Termometro()
        {
        Temperatura = 0.0; // Inicializa a temperatura com 0.0 graus
        TemperaturaMinima = 0.0;
        TemperaturaMaxima = 100.0;
        }      
        

        //Metodos - São as ações que o objeto pode fazer
        public void AjustarTemperatura(double novaTemperatura)
        {
            Temperatura = novaTemperatura;
        }
        public void AjustarTemperaturaCelsius(int novaTemperaturaCelsius)
        {
            TemperaturaCelsius = novaTemperaturaCelsius;
        }


        public void DefinirFaixaTemperatura(double novaminima, double novamaxima)
        {
            TemperaturaMinima = novaminima;
            TemperaturaMaxima = novamaxima;
        }
        public string MostrarTemperatura()
        {
            if (TemperaturaMaxima < Temperatura || Temperatura < TemperaturaMinima){
                return $"A temperatura é: {Temperatura} e esta fora do padrão Permitido Min: {TemperaturaMinima} e Max: {TemperaturaMaxima}";
            }else{ return $"A temperatura é {Temperatura} e está dentro dos padrões";}
        }
        public string LerTemperatura()
        {
            return $"A temperatura em celsius é: {TemperaturaCelsius}";
            }
        }
   
        }
        
    
