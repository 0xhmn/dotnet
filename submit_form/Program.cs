using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace submit_form
{
    class Program
    {

        private string readHtmlPage(string url)
        {

            //setup some variables

            String txtName = "aniforgery test";
            String txtEmail = "sara@yahoo.com";
            String txtSubject = "sara subject";
            String txtMessage = "txtMessage";

            //setup some variables end

            String result = "";
            String strPost = "txtName=" + txtName + "&txtEmail=" + txtEmail + "&txtSubject=" + txtSubject + "&txtMessage=" + txtMessage;
            StreamWriter myWriter = null;

            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
            objRequest.Method = "POST";
            objRequest.ContentLength = strPost.Length;
            objRequest.ContentType = "application/x-www-form-urlencoded";

            try
            {
                myWriter = new StreamWriter(objRequest.GetRequestStream());
                myWriter.Write(strPost);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                myWriter.Close();
            }

            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr =
               new StreamReader(objResponse.GetResponseStream()))
            {
                result = sr.ReadToEnd();

                // Close and clean up the StreamReader
                sr.Close();
            }
            return result;
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                new Program().readHtmlPage("http://localhost:51084/contact.cshtml");
            }

            Console.Read();
        }
    }
}
