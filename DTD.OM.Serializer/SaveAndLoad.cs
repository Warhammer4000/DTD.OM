using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.OM.Globals;

namespace DTD.OM.Serializer
{
    public static class SaveAndLoad
    {
        public static T LoadLocalData<T>(string filename) where T : new()
        {
            if (File.Exists(LocalData.DataPath+filename))
            {
                using (StreamReader file = File.OpenText(LocalData.DataPath + filename))
                {
                    string data = file.ReadLine();
                    T t = Factory<T>.FromJson(data);
                    return t;
                }


            }

            return new T();
        }

        public static void SaveLocalData<T>(string filename, T t)
        {
            string data = Factory<T>.ToJson(t);
            using (StreamWriter file = File.CreateText(LocalData.DataPath + filename))
            {
                file.Write(data);
            }
        }
    }
}
