using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace Registro_Tarea.Controlador
{
    public class RegistrerController
    {
        public bool FirebaseAuth(FirebaseUser user)
        {
            string url = "https://identitytoolkit.googleapis.com/v1/accounts:signInWithCustomToken?key=[BMhElTCOwGFFKFqNYGnNOKaclzYX5DNJ5dreSc0YuLIDSvMPh3fGaDMIDsCp-df1SQxYyEKzVQ1EPTWdk722ftE]";
            string body = "{'email':'" + user.email + "','password':'" + user.password + "','returnSecureToken':true}";

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/json";

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(Encoding.UTF8.GetBytes(body), 0, Encoding.UTF8.GetBytes(body).Length);
            }

            try
            {
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    FirebaseUser payload = JsonConvert.DeserializeObject<FirebaseUser>(reader.ReadToEnd());

                    return payload.registered;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
    }
}