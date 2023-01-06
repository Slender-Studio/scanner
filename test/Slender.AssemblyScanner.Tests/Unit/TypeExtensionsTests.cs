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

    public struct Struct2 : IInterface5 { }

    public struct Struct3 : IInterface7 { }

}
