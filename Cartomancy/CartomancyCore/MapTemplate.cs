using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CartomancyCore
{
    [DataContract]
    public class MapTemplate : CartomancyObject
    {
        [DataMember]
        public int SizeHorizontal { get; set; }

        [DataMember]
        public int SizeVertical { get; set; }

        [DataMember]
        public List<BiomeTemplate> BiomeTemplates { get; } = new List<BiomeTemplate>();

        public MapTemplate(string name) : base(typeof(MapTemplate))
        {
            Name = name;
            BiomeTemplates.Add(new BiomeTemplate("Warrens") { Type = BiomeTemplate.BiomeType.Grass });
        }
    }
}
