using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApprovedMedicalSurvey.Shared
{
    public class WebRequsets
    {
        public string webGetMethod(string URL)
        {
            string jsonString = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";

            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            jsonString = sr.ReadToEnd();
            sr.Close();
            return jsonString;


        }

        public string webPostMethod(string postData, string URL,bool WithHeader )
        {
            string responseFromServer = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "POST";
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Accept = "/";
            if (WithHeader ==true)
            {
               request.Headers.Add("Authorization", "Bearer "+ GlobalVariables.jwt);

            }
            request.UseDefaultCredentials = true;
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            try
            {
                WebResponse response = request.GetResponse();
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return responseFromServer;

        }

    }
}
