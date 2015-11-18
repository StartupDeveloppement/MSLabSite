using System;
using System.Threading.Tasks;
using MSLab.OpenData.Paris.Connexion;

namespace MSLab.OpenData.Paris.ConsoleClient
{
    class TestApi
    {
        public static void Main(string[] args)
        {
            TestIt().Wait();
            //test();
        }

        private static async void test()
        {
            try
            {
                await TestIt();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private static async Task TestIt()
        {
            Console.WriteLine("Liste des datasets");
            ParisOpenData dataParis = new ParisOpenData();
            var datasets = dataParis.GetDatasets();
            foreach (var dataset in await datasets)
            {
                Console.WriteLine("Getting result for dataset " + dataset.datasetid);
                dataset.datasetid.Replace("-","-");
                var listResult = dataParis.GetResults(dataset);
                foreach (var result in await listResult)
                {
                    Console.WriteLine(string.Format("{0} :{1}", result.fields.etablissement,  result.fields.nombre_d_ordinateurs));
                }
                Console.WriteLine("End of result for " + dataset.datasetid);
            }
            Console.WriteLine("End of calls");
        }

    }
}

