using System;

namespace Orleans.Sagas
{
    [GenerateSerializer]
    [Alias("Orleans.Sagas.ActivityDefinition")]
    public class ActivityDefinition
    {
        [Id(0)]
        public Type Type { get; }
        [Id(1)]
        public ISagaPropertyBag Properties { get; }

        public ActivityDefinition(Type type, ISagaPropertyBag properties)
        {
            Type = type;
            Properties = properties;
        }
    }
}
