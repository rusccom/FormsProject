using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FormsProject.BaseSelection
{
    public static class SerializationDBInfo
    {
        private static string filePath = Directory.GetCurrentDirectory()+"\\connectionInfo.bin";

        public static ListInfo GetInfo()
        {
            ListInfo result = new ListInfo();

            if (File.Exists(filePath))
            {
                Stream FileStream = File.OpenRead(filePath);
                BinaryFormatter deserializer = new BinaryFormatter();
                result = (ListInfo)deserializer.Deserialize(FileStream);
                FileStream.Close();
            }
            return result;
        }

        public static void SetInfo(ListInfo baseInfo)
        {
            if (baseInfo.Update)
            {
                Stream FileStream = File.Create(filePath);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(FileStream, baseInfo);
                FileStream.Close();
            }
        }
    }
}
