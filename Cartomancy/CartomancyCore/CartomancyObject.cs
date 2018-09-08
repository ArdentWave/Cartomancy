using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace CartomancyCore
{
    [DataContract]
    public abstract class CartomancyObject
    {         
        [DataMember]
        public Guid UID { get; private set; }

        [DataMember]
        public string Name { get; set; } = "NO NAME";

        [DataMember]
        public string ObjectType { get { return _derivedClassType.Name; } private set { } }

        private Type _derivedClassType;

        public CartomancyObject(Type derivedClassType)
        {
            UID = Guid.NewGuid();            
            _derivedClassType = derivedClassType;
        }

        public string ToJsonString()
        {
            var ms = new MemoryStream();
            var ser = new DataContractJsonSerializer(_derivedClassType);

            ser.WriteObject(ms, this);

            byte[] json = ms.ToArray();

            ms.Close();

            return Encoding.UTF8.GetString(json, 0, json.Length);
        }
    }
}
