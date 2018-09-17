using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using NUnit.Framework;

namespace Fundamentals.Tests
{

    [TestFixture]
    class DynamicTest
    {

        [Test]
        public void FirstDynamic()
        {
            dynamic text = "Hello";
            int length = text.Length;

            Assert.AreEqual(5, length);

            text = new List<int>();

            Assert.AreEqual(typeof(int), CallMe(text));

            // This would compile due to the dynamic type
            // int length = text.Lentgh;

            
        }

        [Test]
        public void ExpandoDynamic()
        {
            dynamic expando = new ExpandoObject();
            IDictionary<string, object> dictionary = expando;
            
            dictionary["Name"] = "jon";
            expando.Age = 35;

            Action greeting = () => Console.WriteLine("Hello!");
            expando.Greeting = greeting;

            expando.Greeting();

            Assert.AreEqual("jon", expando.Name);
            Assert.AreEqual(35, dictionary["Age"]);
        }

        [Test]
        public void DynamicSqlTest()
        {
            dynamic sql = new DynamicSql();

            dynamic results = sql.Books(author: "Jon Skeet", year: 2010);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        public Type CallMe<T>(IEnumerable<T> sequence)
        {
            return typeof(T);
        }

        internal class DynamicSql : DynamicObject
        {
            public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
            {
                var callInfo = binder.CallInfo;

                StringBuilder builder = new StringBuilder("SELECT * FROM " + binder.Name + " WHERE ");
                for (int i = 0; i < callInfo.ArgumentCount; i++)
                {
                    if (i != 0)
                    {
                        builder.Append(" AND ");
                    }

                    builder.AppendFormat("{0} = @{0}", callInfo.ArgumentNames[i]);
                }

                Console.WriteLine("Would execute SQL: {0}", builder);

                for (int i = 0; i < callInfo.ArgumentCount; i++)
                {
                    Console.WriteLine("Would set parameter {0} to {1}", callInfo.ArgumentNames[i], args[i]);
                }

                result = new[] { new { Title = "C# in Depth" } };
                return true;
            }
        }
    }
}
