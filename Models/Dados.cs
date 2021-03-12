namespace mvc.Models
{
    public class Dados
    {
        public static Servico ServicoAtual {get; set; }

        static Dados() 
        {
        ServicoAtual = new Servico();
        }
    }
}