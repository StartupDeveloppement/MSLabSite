using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using MSLab.OpenData.Paris.Data;

namespace MSLab.OpenData.Paris.Connexion
{
    public class ParisOpenData
    {
        #region private properties
        private string OpenDataBaseAdress = Data.Properties.Settings.Default.ParisOpenDataBaseAdresse;
        private MediaTypeWithQualityHeaderValue jsonHeader = new MediaTypeWithQualityHeaderValue("application/json");
        #endregion

        #region public methods  

        public async Task<List<Dataset>> GetDatasets()
        {
            using (var client = new HttpClient() { BaseAddress = new Uri(OpenDataBaseAdress) })
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(jsonHeader);

                HttpResponseMessage apiResponse = await client.GetAsync(string.Format("{0}{1}", OpenDataBaseAdress, "datasets/1.0/search/?rows=100000"));

                if (apiResponse.IsSuccessStatusCode)
                {
                    var resultatJsonBrut = apiResponse.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<DatasetDetail>(resultatJsonBrut).datasets;
                }
                return null;
            }
        }

        public async Task<List<Record>> GetResults(Dataset dataset)
        {
            using (var client = new HttpClient() { BaseAddress = new Uri(OpenDataBaseAdress) })
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(jsonHeader);

                HttpResponseMessage apiResponse = await client.GetAsync(string.Format("{0}{1}{2}{3}", "records/1.0/search/?dataset=", dataset.datasetid, "&rows=",dataset.metas.records_count));

                if (apiResponse.IsSuccessStatusCode)
                {
                    var resultatJsonBrut = apiResponse.Content.ReadAsStringAsync().Result;
                    
                    return JsonConvert.DeserializeObject<DatasetData>(resultatJsonBrut).records;
                }
                return null;
            }
        }
        #endregion 
    }
}
