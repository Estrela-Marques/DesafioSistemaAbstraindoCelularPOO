namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
           
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string Uber)
        {
            Console.WriteLine($"Instalando {Uber} na plataforma Windows Phone do Nokia.");
        }
    }
}