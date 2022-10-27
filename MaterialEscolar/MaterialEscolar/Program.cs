using Models;
internal class Program
{
    private static void Main(string[] args)
    {
        /*Caneta caneta = new Caneta("Vermelha", 10, 0.5, "Bic", "PLastico", "Comun", 0.2);
        caneta.Exibir();
        caneta.Escrever("Lab 01");

        Lapis lapis = new Lapis("Verde", 6, 0.5, "Faber Castell", "Madeira Refinada");
        lapis.Exibir();
        lapis.Escrever("Sucesso!");*/

        /*Apontador apontador = new Apontador("Preto", "Faber Castell", 5);
        apontador.Mostrar();
        apontador.Apontar("teste");*/

        Borracha borracha = new Borracha("Branco", 3, 7, "Faber Castell");
        borracha.Exibir();
        borracha.Apagar();
        borracha.Apagando("");
    }
}