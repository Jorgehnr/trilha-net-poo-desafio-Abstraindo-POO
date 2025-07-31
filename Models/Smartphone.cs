namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }        
        private string Imei { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

        }

        public void Ligar(string discador)
        {
            Console.WriteLine("Ligando... Numero Discado: " + discador);
        }

        public void ReceberLigacao(string identificador)
        {
            Console.WriteLine("Recebendo ligação... Numero identificado: " + identificador);
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}