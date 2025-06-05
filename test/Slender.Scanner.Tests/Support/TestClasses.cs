using System;

namespace Slender.Scanner.Tests.Support
{

    public abstract class AbstractClosedGenericTestClass : IGenericTestInterface<object> { }

    public abstract class AbstractDerivedClosedGenericTestClass : AbstractOpenGenericTestClass<object> { }

    public abstract class AbstractOpenGenericTestClass<TGeneric> : IGenericTestInterface<TGeneric> { }

    public abstract class AbstractTestClass : ITestInterface { }

    public abstract class AbstractTestClass2 : ITestInterface { }

    public class ClosedGenericTestClass : AbstractOpenGenericTestClass<object> { }

    public class DerivedClosedGenericTestClass : OpenGenericTestClass<object> { }

    public class DerivedClosedGenericTestClass2 : AbstractClosedGenericTestClass { }

    public class DerivedClosedGenericTestClass3 : AbstractDerivedClosedGenericTestClass { }

    public class Disposable : IDisposable
    {

        #region - - - - - - Methods - - - - - -

        public void Dispose()
            => GC.SuppressFinalize(this);

        #endregion Methods

    }

    public interface IGenericTestInterface<TGeneric> { }

    public interface ITestInterface { }

    public class OpenGenericTestClass<TGeneric> : AbstractOpenGenericTestClass<TGeneric> { }

    public static class StaticTestClass { }

    public class TestClass1 : AbstractTestClass { }

    public class TestClass2 : AbstractTestClass { }

    public class TestClass3 : AbstractTestClass2 { }

    public class TestClass4 : AbstractTestClass2 { }

    public delegate void TestDelegate();

    public enum TestEnum { }

    public struct TestValueType { }

}
