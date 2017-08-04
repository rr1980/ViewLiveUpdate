using ViewLiveUpdate.Interfaces;

namespace ViewLiveUpdate.ViewDatas.Core
{

    public class ViewDataBuilderService
    {
        public IViewData<TEntity, IViewDataProperty> Build<TEntity>(IViewData<TEntity, IViewDataProperty> viewData, TEntity entity) where TEntity : IEntity
        {
            var propertiesAttributes = CustomAttributeExtractorExtensions.GetPropertyAttributesFromType<ViewDataAttribute>(entity.GetType());

            foreach (var attr in propertiesAttributes)
            {
                var newProp = _buildProp(attr, entity);
                viewData.Properties.Add(newProp);
            }

            return viewData;
        }

        private IViewDataProperty _buildProp<E>(CustomAttributeExtractorExtensions.PropertyAttributeContainer<ViewDataAttribute> attr, E result)
        {
            return new ViewDataProperty()
            {
                Name = attr.Attribute.Name,
                Type = attr.Attribute.EntityPropertyType.ToString(),
                Value = attr.Property.GetValue(result, null)
            };
        }
    }
}