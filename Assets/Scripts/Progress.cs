using System.Runtime.CompilerServices;
using UnityEngine;

public class Progress : MonoBehaviour
{
    public int Coins = 0;
    public int Width = 0;
    public int Height = 0;

    public static Progress Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
