using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;

namespace CartomancyCore
{
    [DataContract]
    public class BiomeTemplate : CartomancyObject
    {
        public enum BiomeType : int
        {
            Grass = 0
        };

        [DataMember]
        public int StartX { get; set; }

        [DataMember]
        public int StartY { get; set; }

        [DataMember]
        public BiomeType Type;

        [DataMember]
        public List<TileTemplate> TileTemplates { get; } = new List<TileTemplate>(); 

        public BiomeTemplate(string name) : base(typeof(BiomeTemplate))
        {
            Name = name;
        }
    }
}
