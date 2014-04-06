using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.IO;

namespace ECA.Services
{
    public static class Helper
    {
        public static string  ConvertToJSON<T>(T objToSerialize)
        {
            string result = string.Empty;
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None;

            result = JsonConvert.SerializeObject(objToSerialize, settings);
            return result ;
        }
        public static string ConvertToXML<T>(T objToSerialize)
        {
            string result = string.Empty;
            MemoryStream stream = new MemoryStream();
            DataContractSerializer ser = new DataContractSerializer(objToSerialize.GetType());
            ser.WriteObject(stream, objToSerialize);
            stream.Seek(0, SeekOrigin.Begin);
            using (StreamReader streamReader = new StreamReader(stream))
            {
                result = streamReader.ReadToEnd();
            }
            return result;
        }
    }
}