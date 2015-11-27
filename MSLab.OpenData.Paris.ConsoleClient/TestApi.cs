using System;
using MSLab.OpenData.Paris.Business.Connexion;

namespace MSLab.OpenData.Paris.ConsoleClient
{
    public class TestApi
    {
        public static void Main(string[] args)
        {
            try
            {
                ParisDataManagement parisDataManagement = new ParisDataManagement();
                parisDataManagement.LesPrenomLesPlusDonnes(5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }

    }
}

