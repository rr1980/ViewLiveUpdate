namespace ViewLiveUpdate.Interfaces
{
    public interface IViewDataProperty
    {
        string Type { get; set; }
        string Name { get; set; }
        dynamic Value { get; set; }
    }
}
