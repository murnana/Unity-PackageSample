#region

using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

#endregion

namespace Murnana.PackageSample.Editor.Tests
{
    [TestFixture]
    [TestOf(typeof(HelloWorldInspector))]
    [TestMustExpectAllLogs]
    internal sealed class HelloWorldInspectorTests
    {
        [Test]
        public void HelloWorldInspectorTestsSimplePasses()
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

            var editor = UnityEditor.Editor.CreateEditor(helloWorld);
            Assert.That(
                actual: editor,
                expression: Is.Not.Null,
                message: nameof(editor)
            );

            Object.DestroyImmediate(editor);
            Object.DestroyImmediate(helloWorld);
            Object.DestroyImmediate(gameObject);
        }
    }
}
