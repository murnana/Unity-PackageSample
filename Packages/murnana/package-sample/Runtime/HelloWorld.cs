#region

using UnityEngine;

#endregion

namespace Murnana.PackageSample
{
    /// <summary>
    /// サンプル Hello World
    /// </summary>
    internal sealed class HelloWorld : MonoBehaviour
    {
        [SerializeField] private string m_UserName = string.Empty;

        private void Awake()
        {
            Debug.Log($"Hello World {m_UserName}!");
        }
    }
}
