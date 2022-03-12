using System;
using Microsoft.EntityFrameworkCore.Sqlite;
using EntityFramework_class;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace csharp_entity_framework
{
    class Program
    {
        public static List<float> carga = new List<float>{0,5,10,12,14,16,18,20,22,24,26,28,30,24,20,16,12,8,4,0};
        public static List<float> deslocamento = new List<float>(){0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19};
        public static void CreateGraph(System.DateTime P_Registro, string P_Material, List<float> P_Carga, List<float> P_Deslocamento)
        {
            var teste = P_Carga.Zip(P_Deslocamento,(cg,ds) => new {Carga = cg, Deslocamento = ds});
            int id;         

            using(TestContext context = new TestContext())
            {                
                context.Grafico.Add(new GRAFICOS_ID(){ Material = P_Material, Registro = P_Registro.ToString()});
                Console.WriteLine("Grafico ID");
                context.SaveChanges();  
            
                id = context.Grafico.Max(i => i.GraficoID);             
            
                foreach(var value in teste)
                {
                    context.Dados.Add(new GRAFICOS_DADOS(){GraficoForeingKey = id, Carga = value.Carga, Deslocamento = value.Deslocamento});
                }
                
                Console.WriteLine("Grafico Dados");
                context.SaveChanges();
            }
        }

        public static void DeleteGraph(int id)
        {
            using(TestContext context = new TestContext())
            {
                context.Grafico.Remove(new GRAFICOS_ID(){GraficoID = id});
                Console.WriteLine("Grafico Deletado");
                context.SaveChanges();
            }
        }
        static void Main(string[] args)
        {
            //CreateGraph(DateTime.Now,"Aluminio", carga, deslocamento);
            DeleteGraph(1);
        }
    }
}
