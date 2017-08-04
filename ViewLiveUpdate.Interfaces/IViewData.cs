using System;
using System.Collections.Generic;
using System.Text;

namespace ViewLiveUpdate.Interfaces
{
    public interface IViewData<TEntity,TProperty> where TEntity : IEntity
    {
        IList<TProperty> Properties { get; set; }
    }
}
