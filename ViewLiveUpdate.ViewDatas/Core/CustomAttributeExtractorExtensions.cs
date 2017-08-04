using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ViewLiveUpdate.ViewDatas.Core
{
    public static class CustomAttributeExtractorExtensions
    {
        public static List<PropertyAttributeContainer<TAttributeType>> GetPropertyAttributesFromType<TAttributeType>(this Type typeToReflect)
            where TAttributeType : Attribute
        {
            var list = new List<PropertyAttributeContainer<TAttributeType>>();

            var properties = typeToReflect.GetProperties();

            foreach (var propertyInfo in properties)
            {
                var attributes = propertyInfo.GetCustomAttributes<TAttributeType>(true).ToList();
                if (!attributes.Any()) continue;

                list.AddRange(attributes.Select(attr => new PropertyAttributeContainer<TAttributeType>(attr, propertyInfo)));
            }

            var interfaces = typeToReflect.GetInterfaces();

            foreach (var @interface in interfaces)
            {
                list.AddRange(@interface.GetPropertyAttributesFromType<TAttributeType>());
            }

            return list;
        }

        public class PropertyAttributeContainer<TAttributeType>
        {
            internal PropertyAttributeContainer(TAttributeType attribute, PropertyInfo property)
            {
                Property = property;
                Attribute = attribute;
            }

            public PropertyInfo Property { get; private set; }

            public TAttributeType Attribute { get; private set; }
        }
    }
}