namespace DesafioPOO.Models

{
    // Herdar da classe "Smartphone"

    public class Iphone : Smartphone
    {

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // Passar os parâmetros do construtor para as propriedades
        }
        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando o aplicativo " + nomeApp + " no Iphone.");
        }
    }
}