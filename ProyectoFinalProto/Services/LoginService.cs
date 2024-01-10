using Newtonsoft.Json;
using ProyectoFinalProto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProto.Services
{
    public class LoginService : IloginRepository
    {
        public async Task<UserInfo> Login(string username, string password)
        {
            
            {
                var userInfo = new List<UserInfo>();
                var client = new HttpClient();

                string url = "https://petstore.swagger.io/v2/user/login?username=Admin&password=123";

                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();

                        // Deserializar la respuesta como un solo objeto UserInfo
                        var user = JsonConvert.DeserializeObject<UserInfo>(content);

                        return user;
                    }
                    else
                    {
                        // Manejar el error en lugar de cerrar la aplicación
                        Console.WriteLine($"Error en la solicitud: {response.StatusCode}");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    // Manejar excepciones, por ejemplo, problemas de red
                    Console.WriteLine($"Error en la solicitud: {ex.Message}");
                    return null;
                }
                finally
                {
                    // Asegurarse de liberar los recursos del cliente HttpClient
                    client.Dispose();
                }
            }
        }
    }
    
}
