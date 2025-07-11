using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    // Attached to DontDestroy object in 01 StartScene.

    public static DontDestroy Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}