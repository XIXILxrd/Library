using Library.Collection;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Library
{
    [Serializable]

    public class Serializer<T>
    {
        private LinkList<T>? list;

        public Serializer(LinkList<T> list)
        {
            this.list = list;
        }

        //public void ToXML(string path)
        //{
        //    if (list == null)
        //    {
        //        throw new NullReferenceException();
        //    }

        //    T[] tempArray = new T[list.Count];
        //    list.CopyTo(tempArray, 0);

        //    try
        //    {
        //        XmlSerializer serializer = new XmlSerializer(tempArray.GetType());

        //        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
        //        {
        //            serializer.Serialize(fs, tempArray);

        //            Console.WriteLine("Object has been serialized");
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}

        //public LinkList<T>? FromXML(string path)
        //{
        //    try
        //    {
        //        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
        //        {
        //            T[]? tempArray = new T[list.Count];

        //            XmlSerializer serializer = new XmlSerializer(tempArray.GetType());

        //            tempArray = serializer.Deserialize(fs) as T[];

        //            if (tempArray != null)
        //            {
        //                foreach (T item in tempArray)
        //                {
        //                    list.Add(item);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }

        //    return list;
        //}

        public void ToJSON(string path)
        {
            try
            {
                File.WriteAllText(
                path, JsonConvert.SerializeObject(
                    list, Formatting.Indented, new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    }));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public LinkList<T> FromJSON(string path)
        {
            LinkList<T> deserializesList = new LinkList<T>();

            try
            {
                var nodes = JsonConvert.DeserializeObject<LinkList<T>>(
                File.ReadAllText(path), new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                });

                if (nodes != null)
                {
                    foreach (T item in nodes)
                    {
                        deserializesList.Add(item);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
            return deserializesList;
        }
    }
}
