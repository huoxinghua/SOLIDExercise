using Unity.VisualScripting;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<T>();
                if(_instance == null)
                {
                    GameObject singletonObject = new GameObject(typeof(T).Name);
                    _instance = singletonObject.AddComponent<T>();
                    DontDestroyOnLoad(singletonObject);
                    Debug.Log("Created new instance of " + typeof(T).Name);
                }
               
            }
            return _instance;
        }

    }
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
           // DontDestroyOnLoad(gameObject);  
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    private void OnDestroy()
    {
        if (_instance == this)
        {
            _instance = null;
        }
    }
}
