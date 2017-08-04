using System;
using System.Collections.Generic;
using System.Text;
using ViewLiveUpdate.Interfaces;
using ViewLiveUpdate.ViewDatas.Core;

namespace ViewLiveUpdate.ViewDatas
{
    public class PersonViewData<TEntity> : IViewData<TEntity, IViewDataProperty> where TEntity : IEntity
    {
        public IList<IViewDataProperty> Properties { get; set; } = new List<IViewDataProperty>();
    }
}
