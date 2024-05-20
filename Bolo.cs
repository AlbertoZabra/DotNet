namespace ConsoleApp1
{

// Classe abstrata DispositivoEletronico
public abstract class Bolo
{
    // Atributos comuns
    public string Sabor { get; set; }
    public int Tamanho { get; set; }

    // Construtor
    public Bolo(string sabor, int tamanho)
    {
        Sabor = sabor;
        Tamanho = tamanho;
    }

    // Método abstrato AddSabor()
    public abstract void AddSabor();

    // Método virtual para obter descrição
    public virtual string FinalizarBolo()
    {
        return $"Sabor: {Sabor}, Tamanho: {Tamanho}";
    }

}



























}