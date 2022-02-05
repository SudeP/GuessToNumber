using UnityEngine;

#pragma warning disable // for name rules
public class CacheBehaviour<T> : MonoBehaviour
    where T : UnityEngine.Object
{
    public static T instance;
    private void Awake()
    {
        if (instance is null)
        {
            #region Intance
            //singeleton
            instance = this as T;
            //cause this code run full scene
            DontDestroyOnLoad(instance);
            #endregion
        }
        else
            Destroy(this);
    }
}
#pragma warning restore