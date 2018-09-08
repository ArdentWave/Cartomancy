using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace CartomancyCore
{
    [DataContract]
    public abstract class CartomancyObject
    {
        [DataMember]
        public Guid UID { get; private set; }

        [DataMember]
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
