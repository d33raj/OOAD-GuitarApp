using OOADGuitarApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADGuitarApp
{
    public class GuitarSpec
    {
        public Builder Builder { get; }
        public string Model { get; }
        public Types Type { get; }
        public Wood BackWood { get; }
        public Wood TopWood { get; }

        public GuitarSpec(Builder builder, string model, Types type, Wood backWood, Wood topWood)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
        }

        public bool Matches(GuitarSpec otherSpec)
        {
            return Builder == otherSpec.Builder && Model == otherSpec.Model &&
               Type == otherSpec.Type && BackWood == otherSpec.BackWood &&
               TopWood == otherSpec.TopWood;
        }
    }

}
