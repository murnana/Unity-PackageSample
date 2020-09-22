#region

using System;
using UnityEditor;
using UnityEngine;

#endregion

namespace Murnana.PackageSample.Editor
{
    /// <summary>
    /// <see cref="HelloWorld" /> のエディタ拡張
    /// </summary>
    [CustomEditor(typeof(HelloWorld))]
    internal sealed class HelloWorldInspector : UnityEditor.Editor
    {
        private SerializedProperty UserName { get; set; }

    #region UnityEditor.Editor

        private void OnEnable()
        {
            UserName = serializedObject.FindProperty("m_UserName");
            if (UserName == null)
            {
                Debug.LogException(new NullReferenceException("m_UserName"));
            }
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(UserName);

            if (serializedObject.hasModifiedProperties)
            {
                serializedObject.ApplyModifiedProperties();
            }
        }

    #endregion
    }
}
