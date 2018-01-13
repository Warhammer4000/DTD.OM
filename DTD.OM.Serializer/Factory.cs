using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DTD.OM.Serializer
{
    public static class Factory<T>
    {
        public static string ToJson(T t)
        {
            return JsonConvert.SerializeObject(t);
        }

        public static T FromJson(string data)
        {
            return JsonConvert.DeserializeObject<T>(data);
        }


    }
}
