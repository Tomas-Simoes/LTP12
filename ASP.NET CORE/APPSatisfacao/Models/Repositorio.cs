namespace APPSatisfacao.Models
{
    public class Repositorio
    {
        public static List<RespostaInquerito> ListaInquerito = new List<RespostaInquerito>();

        public static void AdicionarInquerito(RespostaInquerito resposta)
        {
            ListaInquerito.Add(resposta);
        }

        public static IEnumerable<RespostaInquerito> ListaFinal
        {
            get { return ListaInquerito; }
        }
    }
}
