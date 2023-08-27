using FluentAssertions;
using Slender.AssemblyScanner.Tests.Support;
using System;
using System.Collections.Generic;
using Xunit;

namespace Slender.AssemblyScanner.Tests.Unit
{

    public class TypeExtensionsTests
    {

        #region - - - - - - GetBaseType Tests - - - - - -

        [Theory]
        [MemberData(nameof(GetBaseType_VariousTypes_ShouldGetBaseTypeDefinition_MemberData))]
        public void GetBaseType_VariousTypes_ShouldGetBaseTypeDefinition(Type type, Type expected)
            => type.GetBaseType().Should().Be(expected);

        private static IEnumerable<object[]> GetBaseType_VariousTypes_ShouldGetBaseTypeDefinition_MemberData()
            => new[]
            {
                new object[] { typeof(AbstractTestClass), typeof(object) },
                new object[] { typeof(AbstractTestClass2), typeof(object) },
                new object[] { typeof(AbstractOpenGenericTestClass<>), typeof(object) },
                new object[] { typeof(AbstractClosedGenericTestClass), typeof(object) },
                new object[] { typeof(AbstractDerivedClosedGenericTestClass), typeof(AbstractOpenGenericTestClass<object>) },
                new object[] { typeof(ClosedGenericTestClass), typeof(AbstractOpenGenericTestClass<object>) },
                new object[] { typeof(DerivedClosedGenericTestClass), typeof(OpenGenericTestClass<object>) },
                new object[] { typeof(DerivedClosedGenericTestClass2), typeof(AbstractClosedGenericTestClass) },
                new object[] { typeof(DerivedClosedGenericTestClass3), typeof(AbstractDerivedClosedGenericTestClass) },
                new object[] { typeof(OpenGenericTestClass<>), typeof(AbstractOpenGenericTestClass<>) },
                new object[] { typeof(OpenGenericTestClass<object>), typeof(AbstractOpenGenericTestClass<object>) }
            };

        #endregion GetBaseType Tests

        #region - - - - - - GetImplementedInterfaces Tests - - - - - -

        [Theory]
        [MemberData(nameof(GetImplementedInterfaces_VariousTypes_ShouldGetImplementedInterfaceDefinitions_MemberData))]
        public void GetImplementedInterfaces_VariousTypes_ShouldGetImplementedInterfaceDefinitions(Type type, IEnumerable<Type> expected)
            => type.GetImplementedInterfaces().Should().BeEquivalentTo(expected);

        private static IEnumerable<object[]> GetImplementedInterfaces_VariousTypes_ShouldGetImplementedInterfaceDefinitions_MemberData()
            => new[]
            {
                new object[] { typeof(AbstractTestClass), new[] { typeof(ITestInterface) } },
                new object[] { typeof(AbstractTestClass2), new[] { typeof(ITestInterface) } },
                new object[] { typeof(AbstractOpenGenericTestClass<>), new[] { typeof(IGenericTestInterface<>) } },
                new object[] { typeof(AbstractClosedGenericTestClass), new[] { typeof(IGenericTestInterface<object>) } },
                new object[] { typeof(AbstractDerivedClosedGenericTestClass), new[] { typeof(IGenericTestInterface<object>) } },
                new object[] { typeof(ClosedGenericTestClass), new[] { typeof(IGenericTestInterface<object>) } },
                new object[] { typeof(DerivedClosedGenericTestClass), new[] { typeof(IGenericTestInterface<object>) } },
                new object[] { typeof(DerivedClosedGenericTestClass2), new[] { typeof(IGenericTestInterface<object>) } },
                new object[] { typeof(DerivedClosedGenericTestClass3), new[] { typeof(IGenericTestInterface<object>) } },
                new object[] { typeof(OpenGenericTestClass<>), new[] { typeof(IGenericTestInterface<>) } },
                new object[] { typeof(OpenGenericTestClass<object>), new[] { typeof(IGenericTestInterface<object>) } }
            };

        #endregion GetImplementedInterfaces Tests

    }

}
