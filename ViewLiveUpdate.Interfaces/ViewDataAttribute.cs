using System;
using System.Collections.Generic;
using System.Text;

namespace ViewLiveUpdate.Interfaces
{
    public enum EntityPropertyType
    {
        String,
        Long
    }

    public class ViewDataAttribute : Attribute
    {
        public string Name { get; set; }
        public EntityPropertyType EntityPropertyType { get; set; }

        public ViewDataAttribute(string name, EntityPropertyType epType)
        {
            Name = name;
            EntityPropertyType = epType;
        }
    }
}
