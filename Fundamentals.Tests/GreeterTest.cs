using Fundamentals;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class GreeterTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SayHello_ReturnsHelloWithRecipientNameAndSpeakerName()
        {
            string recipient = "Jon";
            Greeter greeter = new Greeter("Rob");
            string greeting = greeter.SayHello(recipient);

            Assert.AreEqual("Hello Jon from Rob", greeting);
        }

        [Test]
        public void SayHello_ReturnsHelloWithRecipientNameButNoSpeakerName()
        {
            string recipient = "Jon";
            Greeter greeter = new Greeter(null);
            string greeting = greeter.SayHello(recipient);

            Assert.AreEqual("Hello Jon", greeting);
        }

        [Test]
        public void SayHello_ThrowsExceptionWithNullRecipient()
        {
            Greeter greeter = new Greeter("Rob");

            Assert.Throws<ArgumentNullException>(() => greeter.SayHello(null));
        }

        [Test]
        public void CanConstructGreeterWithNullSpeakerName()
        {
            new Greeter(null);
        }

        [Test]
        public void SpeakerProperty_IsSetFromConstructor()
        {
            Greeter greeter = new Greeter("Rob");
            Assert.AreEqual("Rob", greeter.Speaker);
            Assert.AreNotEqual("rob", greeter.Speaker);
        }

    }
}