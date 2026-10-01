namespace AgroLeite.Models
{
    public class ProducaoMensal
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double ValorTotal { get; set; }
        public string MesReferencia { get; set; }
        public int Ano {  get; set; }
        public double ValorLitro { get; set; }
        public double Litragem { get; set; }
        public double Media {  get; set; }  

    }
}
