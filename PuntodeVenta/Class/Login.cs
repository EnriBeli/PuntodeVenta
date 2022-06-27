using Newtonsoft.Json;
using PuntodeVenta.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVenta.Class
{
    public class Login
    {
        public static async Task<ResultPost> CallServiceLogin(string url, Object user)
        {
            ResultPost resultO = new ResultPost();
            string result = "";
            try
            {
                using (var v_Client = new HttpClient())
                {
                    v_Client.BaseAddress = new Uri("api/authenticateUser");

                    var httpContent = new StringContent(JsonConvert.SerializeObject(user, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }), Encoding.UTF8, "application/json");

                    var v_Response = v_Client.PostAsync(url, httpContent).Result;
                    var jsonResponse = await v_Response.Content.ReadAsStringAsync();


                    if (v_Response.IsSuccessStatusCode)
                    {
                        resultO.result = v_Response.Content.ReadAsStringAsync().Result;
                        resultO.error = false;
                    }
                    else
                    {
                        resultO.result = v_Response.StatusCode.ToString();
                        resultO.errors = jsonResponse;
                        resultO.error = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
                resultO.errors = ex.Message;
                resultO.error = true;
            }
            return resultO;
        }
    }
}
