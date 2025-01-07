using System.IO;
using System.Xml.Serialization;

namespace IntegrationXML.Services
{
    public class XmlHelper
    {
        public static void SalvarEmXml<T>(T objeto, string caminhoArquivo)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            // Usar using para garantir que o arquivo seja fechado corretamente após a escrita
            using (StreamWriter writer = new StreamWriter(caminhoArquivo))
            {
                serializer.Serialize(writer, objeto);
            }
        }
    }
}