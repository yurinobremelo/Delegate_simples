// See https://aka.ms/new-console-template for more information


public delegate void Notificador(string message);// delegate que recebe string e retorna void

class Program
{
    static void Main(string[] args)
    {
        var enviaAviso = new ExibirMensagem();
        Notificador notificador = enviaAviso.ExibeNaTela; // atribui o método ExibeNaTela ao delegate
        notificador += enviaAviso.EnviarPorEmail;

       
        notificador("Mensagem do sistema"); // chama o método através do delegate
      
    }
   class ExibirMensagem
   {
        public void ExibeNaTela(string message)
        {
            Console.WriteLine("Na tela: " + message);
        }
        public void EnviarPorEmail(string message)
        {
            Console.WriteLine("(Simulação) Envia por email:" + message);
        }
    }
}