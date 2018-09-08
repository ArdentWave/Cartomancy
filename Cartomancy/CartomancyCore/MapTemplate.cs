using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace CartomancyCore
{
    [DataContract]
    public class MapTemplate : CartomancyObject
    {
        [DataMember]
        public int SizeHorizontal { get; set; }

        [DataMember]
        public int SizeVertical { get; set; }

        public MapTemplate() : base(typeof(MapTemplate))
        {

        }
    }
}
