namespace ConsoleApp1

{

    public class Cobertura : Bolo
{
    // Atributos adicionais
    public string Recheio { get; set; }
    public string Brigadeiro { get; set; }

    // Construtor
    public Cobertura(string sabor, int tamanho, string recheio, string brigadeiro)
        : base(sabor, tamanho)
    {
        Recheio = recheio;
        Brigadeiro = brigadeiro;
    }

    // Implementação do método AddSabor() para o Bolo de Cobertura
    public override void AddSabor()
    {
        Console.WriteLine("Saborizar o Bolo...");
        // Lógica específica para Saborizar o Bolo
        
    }


    // Sobrescrita do método FinalizarBolo()
    public override string FinalizarBolo()
    {
        return $"{base.FinalizarBolo()}, Recheio: {Recheio}, Sabor do Brigadeiro: {Brigadeiro}";
    }


}







}