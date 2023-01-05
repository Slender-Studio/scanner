using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Slender.AssemblyScanner.Tests.Unit
{

    public class AssemblyScanVisitorTests
    {

        #region - - - - - - Fields - - - - - -

        private readonly Mock<IAssemblyScan> m_MockAssemblyScan = new();

        private readonly TestVisitor m_Visitor = new();

        #endregion Fields

        #region - - - - - - Constructors - - - - - -

        public AssemblyScanVisitorTests()
            => _ = this.m_MockAssemblyScan
                    .Setup(mock => mock.Types)
                    .Returns(new[]
                    {
                        typeof(ITestInterface), typeof(AbstractTestClass), typeof(AbstractTestClass2), typeof(TestClass1),
                        typeof(TestClass2), typeof(TestClass3), typeof(TestClass4), typeof(StaticTestClass),
                        typeof(TestDelegate), typeof(TestEnum), typeof(TestValueType)
                    });

        #endregion Constructors

        #region - - - - - - VisitAssemblyScan Tests - - - - - -

        [Fact]
        public void VisitAssemblyScan_ScanContainsVariousTypes_AllTypesVisitedCorrectly()
        {
            // Arrange
            var _ExpectedVisitor = new TestVisitor
            {
                VisitedAbstractTypes = new[] { typeof(AbstractTestClass), typeof(AbstractTestClass2) }.ToList(),
                VisitedAbstractTypesAndImplementationTypes = new[]
                {
                    (typeof(AbstractTestClass), new[] { typeof(TestClass1), typeof(TestClass2) }.AsEnumerable()),
                    (typeof(AbstractTestClass2), new[] { typeof(TestClass3), typeof(TestClass4) })
                }.ToList(),
                VisitedDelegateTypes = new[] { typeof(TestDelegate) }.ToList(),
                VisitedEnumerationTypes = new[] { typeof(TestEnum) }.ToList(),
                VisitedImplementationTypes = new[] { typeof(TestClass1), typeof(TestClass2), typeof(TestClass3), typeof(TestClass4) }.ToList(),
                VisitedInterfaceTypes = new[] { typeof(ITestInterface) }.ToList(),
                VisitedInterfaceTypesAndImplementationTypes = new[]
                {
                    (typeof(ITestInterface), new[] { typeof(TestClass1), typeof(TestClass2), typeof(TestClass3), typeof(TestClass4) }.AsEnumerable())
                }.ToList(),
                VisitedTypes = new[]
                {
                    typeof(ITestInterface), typeof(AbstractTestClass), typeof(AbstractTestClass2), typeof(TestClass1),
                    typeof(TestClass2), typeof(TestClass3), typeof(TestClass4), typeof(StaticTestClass),
                    typeof(TestDelegate), typeof(TestEnum), typeof(TestValueType)
                }.ToList(),
                VisitedValueTypes = new[] { typeof(TestValueType) }.ToList()
            };

            // Act
            this.m_Visitor.VisitAssemblyScan(this.m_MockAssemblyScan.Object);

            // Assert
            _ = this.m_Visitor.Should().BeEquivalentTo(_ExpectedVisitor);
        }

        #endregion VisitAssemblyScan Tests

    }

    public abstract class AbstractTestClass : ITestInterface { }

    public abstract class AbstractTestClass2 : ITestInterface { }

    public interface ITestInterface { }

    public static class StaticTestClass { }

    public class TestClass1 : AbstractTestClass { }

    public class TestClass2 : AbstractTestClass { }

    public class TestClass3 : AbstractTestClass2 { }

    public class TestClass4 : AbstractTestClass2 { }

    public delegate void TestDelegate();

    public enum TestEnum { }

    public struct TestValueType { }

    public class TestVisitor : AssemblyScanVisitor
    {

        #region - - - - - - Properties - - - - - -

        public List<Type> VisitedAbstractTypes { get; set; } = new();

        public List<(Type, IEnumerable<Type>)> VisitedAbstractTypesAndImplementationTypes { get; set; } = new();

        public List<Type> VisitedDelegateTypes { get; set; } = new();

        public List<Type> VisitedEnumerationTypes { get; set; } = new();

        public List<Type> VisitedImplementationTypes { get; set; } = new();

        public List<Type> VisitedInterfaceTypes { get; set; } = new();

        public List<(Type, IEnumerable<Type>)> VisitedInterfaceTypesAndImplementationTypes { get; set; } = new();

        public List<Type> VisitedTypes { get; set; } = new();

        public List<Type> VisitedValueTypes { get; set; } = new();

        #endregion Properties

        #region - - - - - - Methods - - - - - -

        protected override void VisitAbstract(Type abstractType)
            => this.VisitedAbstractTypes.Add(abstractType);

        protected override void VisitAbstractAndImplementations(Type abstractType, IEnumerable<Type> implementationTypes)
            => this.VisitedAbstractTypesAndImplementationTypes.Add((abstractType, implementationTypes));

        protected override void VisitDelegate(Type delegateType)
            => this.VisitedDelegateTypes.Add(delegateType);

        protected override void VisitEnumeration(Type enumerationType)
            => this.VisitedEnumerationTypes.Add(enumerationType);

        protected override void VisitImplementation(Type implementationType)
            => this.VisitedImplementationTypes.Add(implementationType);

        protected override void VisitInterface(Type interfaceType)
            => this.VisitedInterfaceTypes.Add(interfaceType);

        protected override void VisitInterfaceAndImplementations(Type interfaceType, IEnumerable<Type> implementationTypes)
            => this.VisitedInterfaceTypesAndImplementationTypes.Add((interfaceType, implementationTypes));

        protected override void VisitType(Type type)
        {
            this.VisitedTypes.Add(type);
            base.VisitType(type);
        }

        protected override void VisitValueType(Type valueType)
            => this.VisitedValueTypes.Add(valueType);

        #endregion Methods

    }

}
