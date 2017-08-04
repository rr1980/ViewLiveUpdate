using System;
using System.Collections.Generic;
using System.Text;
using ViewLiveUpdate.Interfaces;

namespace ViewLiveUpdate.Entities
{
    public class Person : IEntity
    {
        [ViewData("Id", EntityPropertyType.Long)]
        public long Id { get; set; }

        [ViewData("Name", EntityPropertyType.String)]
        public string Name { get; set; }
    }
}
