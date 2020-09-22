#region

using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

#endregion

namespace Murnana.PackageSample.Tests
{
    [TestFixture]
    [TestOf(typeof(HelloWorld))]
    [TestMustExpectAllLogs]
    internal sealed class HelloWorldTests
    {
        [UnityTest]
        public IEnumerator HelloWorldTestsWithEnumeratorPasses()
        {
            var gameObject = new GameObject("Hello World");
            Assume.That(
                actual: gameObject,
                expression: Is.Not.Null,
                message: nameof(gameObject)
            );

            var helloWorld = gameObject.AddComponent<HelloWorld>();
            Assume.That(
                actual: helloWorld,
                expression: Is.Not.Null,
                message: nameof(helloWorld)
            );

            LogAssert.Expect(type: LogType.Log, message: "Hello World !");
            yield return null;
        }
    }
}
