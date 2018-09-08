using System.Drawing;
using System.Runtime.Serialization;

namespace CartomancyCore
{
    [DataContract]
    public class BiomeTemplate : CartomancyObject
    {
        [DataMember]
        public int StartX { get; set; }

        [DataMember]
        public int StartY { get; set; }

        [DataMember]
        public Classification.BiomeType BiomeType;

        public BiomeTemplate(string name) : base(typeof(BiomeTemplate))
        {
            Name = name;
        }
    }
}
