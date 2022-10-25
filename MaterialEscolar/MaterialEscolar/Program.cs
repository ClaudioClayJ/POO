internal class Program
{
    private static void Main(string[] args)
    {
        Models.Caneta caneta = new Models.Caneta("Vermelha", 10, 0.5, "Bic", "PLastico", "Comun", 0.2);
        caneta.Exibir();
        caneta.Escrever("Lab 01");
        
    }
}