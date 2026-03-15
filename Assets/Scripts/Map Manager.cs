using UnityEngine;

public class MapManager : MonoBehaviour
{
    public static MapManager instance = null;

    private MapController mapScript;
    private int level = 1;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        mapScript = GetComponent<MapController>();
        InitGame();
    }

    private void InitGame()
    {
        mapScript.SetupScene(level);
    }
}
