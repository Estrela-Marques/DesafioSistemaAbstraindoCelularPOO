namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone :  Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
           
        }

        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string Telegram)
        {
            Console.WriteLine($"Instalando {Telegram} na App Store do iPhone.");
        }
    }
}