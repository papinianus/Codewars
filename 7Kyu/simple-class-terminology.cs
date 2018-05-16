namespace CustomAccessors
{
    public class DemoClass
    {
        private int _privateField;
        public string PublicField = "None";
        public int LimitedProperty { get; private set; }
        public DemoClass(int i)
        {
          _privateField = i;
        }
    }
}

namespace CustomAccessors
{
    using NUnit.Framework;
    using System.Reflection;
    using System;

    [TestFixture]
    public class AllTests
    {
        [Test]
        public void CheckConstructorExists()
        {
            //sut --> subject under test
            var sut = new DemoClass(15);
            Assert.Pass("Single int argument constructor exists");
        }

        [Test]
        public void CheckConstructorAssignsToPrivateField()
        {
            for (int i = 0; i < 30; i += 5)
            {
                var sut = new DemoClass(i);
                FieldInfo fi = typeof(DemoClass).GetField("_privateField", BindingFlags.NonPublic | BindingFlags.Instance);

                Assert.NotNull(fi, "_privateField doesn't exist");
                Assert.AreEqual(i, fi.GetValue(sut));
            }
        }

        [Test]
        public void CheckThatPublicFieldExists()
        {
            for (int i = 0; i < 30; i += 5)
            {
                var sut = new DemoClass(0);
                FieldInfo fi = typeof(DemoClass).GetField("PublicField", BindingFlags.Public | BindingFlags.Instance);

                Assert.NotNull(fi, "PublicField doesn't exist");
                Assert.AreEqual("None", fi.GetValue(sut));
                Assert.AreEqual("None", sut.PublicField);
                Assert.True(ReferenceEquals(fi.GetValue(sut), sut.PublicField));
            }
        }

        [Test]
        public void CheckThatLimitedPropertyExists()
        {
            Type type = typeof(DemoClass);
            ConstructorInfo ci = type.GetConstructor(new[] { typeof(int) });
            object classObject = ci.Invoke(new object[] { 24 });
            PropertyInfo pi = type.GetProperty("LimitedProperty", BindingFlags.Instance | BindingFlags.Public);

            Assert.NotNull(pi, "LimitedProperty doesn't exist");
            if (pi.GetGetMethod(nonPublic: false) == null)
            { Assert.Fail("Public getter not found"); }
            if (pi.GetSetMethod(nonPublic: true) == null)
            { Assert.Fail("Private setter not found"); }

            //now check that it is assignable
            MethodInfo mi = pi.GetSetMethod(true);
            for (int i = 0; i < 30; i += 5)
            {
                mi.Invoke(classObject, new object[] { i });
                Assert.AreEqual(i, ((DemoClass)classObject).LimitedProperty, "Your LimitedProperty is either not setting or getting correctly");
            }
        }
    }
}
