namespace App2.Models
{
    public class Repositorio
    {
        private static List<RespostaInscricao> LISTA = new List<RespostaInscricao>();   
        
        public static void AdicionarResposta(RespostaInscricao resposta)
        {
            LISTA.Add(resposta);
        }

        public static IEnumerable<RespostaInscricao> ListaFinal
        {
            get { return LISTA; }
        }
    }
}
