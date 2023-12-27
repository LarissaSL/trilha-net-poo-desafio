namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _Modelo;
        private string _IMEI;
        private int _Memoria;

        public string Numero { get; set; }
        public string Modelo 
        { 
            get => _Modelo;
        }
        public string IMEI 
        { 
            get => _IMEI; 
        }
        public int Memoria 
        { 
            get => _Memoria;
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            _Modelo = modelo;
            _IMEI = imei;
            _Memoria = memoria;
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