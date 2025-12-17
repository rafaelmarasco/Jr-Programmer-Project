using UnityEngine;

public class MainMenager : MonoBehaviour
{
    public static MainMenager Instance;
    public Color TeamColor;

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
