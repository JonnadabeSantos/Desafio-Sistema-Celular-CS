namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public int Numero { get; set; }
        protected string Modelo { get; private set; }
        protected string IMEI { get; private set; }
        protected int Memoria { get; private set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(int numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}