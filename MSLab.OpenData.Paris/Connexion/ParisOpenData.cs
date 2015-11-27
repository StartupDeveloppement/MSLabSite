using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using MSLab.OpenData.Paris.Data;

namespace MSLab.OpenData.Paris.Connexion
{
    internal class ParisOpenData
    {
        #region private properties
        private string OpenDataBaseAdress;
        private int MaxRecordsByCall;

        private MediaTypeWithQualityHeaderValue jsonHeader = new MediaTypeWithQualityHeaderValue("application/json");
        #endregion

        public ParisOpenData()
        {
            OpenDataBaseAdress = Business.Properties.Settings.Default.ParisOpenDataBaseAdresse;
            MaxRecordsByCall = Business.Properties.Settings.Default.MaxRecordsByCall;
        }

        #region internal methods  

        internal List<Dataset> GetDatasets()
        {
            using (var client = new HttpClient() { BaseAddress = new Uri(OpenDataBaseAdress) })
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(jsonHeader);

                Task<HttpResponseMessage> apiResponse = client.GetAsync(string.Format("{0}{1}", OpenDataBaseAdress, "datasets/1.0/search/?rows=1000"));

                if (apiResponse.Result.IsSuccessStatusCode)
                {
                    var resultatJsonBrut = apiResponse.Result.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<DatasetDetail>(resultatJsonBrut).datasets;
                }
                return null;
            }
        }

        internal string getRecords(string datasetId, int datasetrows, int startingRecordNumber)
        {            
            if (datasetrows> MaxRecordsByCall)
            {
                if (datasetrows>startingRecordNumber )
                    datasetrows = MaxRecordsByCall;
                else
                    datasetrows = datasetrows-startingRecordNumber;
            }


            using (var client = new HttpClient() { BaseAddress = new Uri(OpenDataBaseAdress) })
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(jsonHeader);

                Task<HttpResponseMessage> apiResponse = client.GetAsync(string.Format("records/1.0/search/?dataset={0}&rows={1}&start={2}", datasetId, datasetrows.ToString(),startingRecordNumber));

                if (apiResponse.Result.IsSuccessStatusCode)
                {
                    return apiResponse.Result.Content.ReadAsStringAsync().Result;
                }
                return null;
            }
        }

        #endregion
    }
}
