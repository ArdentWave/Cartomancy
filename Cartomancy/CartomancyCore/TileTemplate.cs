using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartomancyCore
{
    [DataContract]
    public class TileTemplate : CartomancyObject
    {
        [DataMember]
        public int X;

        [DataMember]
        public int Y;

        public TileTemplate(string name) : base(typeof(TileTemplate))
        {
            Name = name;
        }
    }
}
