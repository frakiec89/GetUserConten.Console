using GetUserConten.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GetUserConten.BL
{
    public class UserControllerJSON : Core.IUserController
    {
        private string path = @"C:\Users\Ahtyamov\Desktop\Content\Content.json"; // зависимость

        public List<User> GetUsers()
        {
            using (StreamReader reader = new StreamReader(path, Encoding.UTF8, true))
            {
                var content = reader.ReadToEnd();
                var byteContent = Encoding.UTF8.GetBytes(content);
                var readOnlySpan = new Utf8JsonReader(byteContent);
                return   JsonSerializer.Deserialize<List<User>>(ref readOnlySpan);
            }
        }
    }
}
