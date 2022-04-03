namespace EntityFramework_class
{
    public class GRAFICOS_ID
    {        
        public int GraficoID {get;set;}
        public string? Material {get; set;}
        public string? Registro {get; set;}
        public ICollection<GRAFICOS_DADOS>? Dados{get;set;}
        //public List<GRAFICOS_DADOS> Dados {get; set;} = new();
        //public GRAFICOS_DADOS DADOS {get; set;} = new GRAFICOS_DADOS();
    }        
    //[Keyless]
    public class GRAFICOS_DADOS
    {
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IndexID;
        public float Carga {get; set;}
        public float Deslocamento {get; set;}
        public int GraficoForeingKey {get; set;}
        public GRAFICOS_ID? GRAFICOS_ID{get; set;}
    }
}
