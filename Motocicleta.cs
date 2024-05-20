namespace ConsoleApp1
{

    public class Motocicleta : Veiculo
    {   
        public int Cilindrada { get{return Cilindrada;} set{Cilindrada=value;} }

        public Motocicleta(string marca, string modelo, int ano, int cilindrada) : base(marca,modelo,ano)
        {
            Cilindrada = cilindrada;
        }
        
        public void ListarMoto()
        {            
            System.Console.WriteLine(Marca+" - "+Modelo+" - "+Ano+" - "+Cilindrada);
        }

    }




}