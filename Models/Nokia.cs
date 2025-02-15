
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Se o seu aparelho estiver com o sistema Android, vá até a PlayStore para encontrar os app {nomeApp}. Caso não esteja, consulte a loja de aplicativos padrão do fabricamte");
        }

    }
}