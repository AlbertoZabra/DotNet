using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //Classe
    public class Pessoa
    {

        public int Idade { 
        
            get { return Idade; }
            set{
                if (value<0){
                    Idade = 0;
                }else{
                    Idade = value;
                }
            }
            }

        public Pessoa(int novaIdade)
        {
           Idade = novaIdade; 
        }   
        
        public int LerIdade()
        {
            return Idade;
        }

        }





    }