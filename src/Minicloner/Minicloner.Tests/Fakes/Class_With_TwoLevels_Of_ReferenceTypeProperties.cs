using Minicloner.Tests.Fakes.Properties;

namespace Minicloner.Tests.Fakes
{
    public class Class_With_TwoLevels_Of_ReferenceTypeProperties
    {
        public Class_With_PublicAutoImplementedProperty ReferenceTypeProperty { get; set; }
        public Class_With_ReferenceTypeProperty TwoLeveled_ReferenceTypeProperty { get; set; }
    }
}