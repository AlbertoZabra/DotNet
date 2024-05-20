using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //Classe
    public class Contador
    {
        //Para criar o atributo abaixo, digite prop<tab><tab> que ele monta o atributo com os gets e sets
        public int Valor { get; set; }
        
        // Construtor é o contrato que você precisa definir como o objeto será criado, mas vc pode criar o construtor vazio, aí vc precisa definir na criação do objeto.
        public Contador(int valor)
        {
            Valor = valor;
        }

        public Contador()
        {
        }

        //Metodos - São as ações que o objeto pode fazer
        public void Incrementar()
        {
            this.Valor += 1;
            System.Console.WriteLine(Valor);
        }
        public void Decrementar()
        {
            this.Valor -= 1;
            System.Console.WriteLine(Valor);
        }
    }
}