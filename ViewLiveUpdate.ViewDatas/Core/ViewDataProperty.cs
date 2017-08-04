using ViewLiveUpdate.Interfaces;

namespace ViewLiveUpdate.ViewDatas.Core
{
    public class ViewDataProperty : IViewDataProperty
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public dynamic Value { get; set; }
    }
}