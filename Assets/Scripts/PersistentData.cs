using UnityEngine;
using UnityEngine.UI;

public class PersistentData : MonoBehaviour
{
    public static PersistentData Instance;

    public string PlayerName;

    public int BestScore;
    public string BestName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }
}
