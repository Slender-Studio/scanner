using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace Slender.AssemblyScanner.Tests.Unit
{

    public class TypeExtensionsTests
    {

        #region - - - - - - GetBaseTypes Tests - - - - - -

        [Theory]
        [MemberData(nameof(GetBaseTypes_VariousTypes_ShouldGetBaseTypesInLeastDerivedOrder_MemberData))]
        public void GetBaseTypes_VariousTypes_ShouldGetBaseTypesInLeastDerivedOrder(Type type, IEnumerable<Type> expected)
            => type.GetBaseTypes().Should().BeEquivalentTo(expected);

        private static IEnumerable<object[]> GetBaseTypes_VariousTypes_ShouldGetBaseTypesInLeastDerivedOrder_MemberData()
            => new[]
            {
                new object[] { typeof(Class1), new[] { typeof(object) } },
                new object[] { typeof(Class2), new[] { typeof(object), typeof(Class1) } },
                new object[] { typeof(Class3), new[] { typeof(object), typeof(Class1), typeof(Class2) } },
                new object[] { typeof(Class4), new[] { typeof(object), typeof(Class1), typeof(Class2), typeof(Class3) } },
                new object[] { typeof(Class5), new[] { typeof(object), typeof(Class1), typeof(Class2) } },
                new object[] { typeof(Struct1), new[] { typeof(object), typeof(ValueType) } }
            };

        #endregion GetBaseTypes Tests

        #region - - - - - - GetDirectInterfaces Tests - - - - - -

        [Theory]
        [MemberData(nameof(GetDirectInterfaces_VariousTypes_OnlyGetsInterfacesImplementedByType_MemberData))]
        public void GetDirectInterfaces_VariousTypes_OnlyGetsInterfacesImplementedByType(Type type, IEnumerable<Type> expected)
            => type.GetDirectInterfaces().Should().BeEquivalentTo(expected);

        private static IEnumerable<object[]> GetDirectInterfaces_VariousTypes_OnlyGetsInterfacesImplementedByType_MemberData()
            => new[]
            {
                new object[] { typeof(Class1), new[] { typeof(IInterface1) } },
                new object[] { typeof(Class2), new[] { typeof(IInterface2) } },
                new object[] { typeof(Class3), new[] { typeof(IInterface3) } },
                new object[] { typeof(Class4), new[] { typeof(IInterface5), typeof(IInterface6) } },
                new object[] { typeof(Class5), new[] { typeof(IInterface7) } },
                new object[] { typeof(Struct1), new[] { typeof(IInterface1), typeof(IInterface2) } },
                new object[] { typeof(Struct2), new[] { typeof(IInterface5) } },
                new object[] { typeof(Struct3), new[] { typeof(IInterface7) } }
            };

        #endregion GetDirectInterfaces Tests

    }

    public class Class1 : IInterface1 { }

    public class Class2 : Class1, IInterface2 { }

    public class Class3 : Class2, IInterface3 { }

    public class Class4 : Class3, IInterface4, IInterface5, IInterface6 { }

    public class Class5 : Class2, IInterface3, IInterface5, IInterface6, IInterface7 { }

    public interface IInterface1 { }

    public interface IInterface2 { }

    public interface IInterface3 { }

    public interface IInterface4 { }

    public interface IInterface5 : IInterface1, IInterface2 { }

    public interface IInterface6 : IInterface3, IInterface4 { }

    public interface IInterface7 : IInterface5, IInterface6 { }

    public struct Struct1 : IInterface1, IInterface2 { }

    public struct Struct2 : IInterface1, IInterface5 { }

    public struct Struct3 : IInterface7 { }

}
