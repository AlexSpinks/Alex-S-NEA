using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public static MapManager instance = null;
    private MapController MapScript;
    private int level = 1;
    // Start is called before the first frame update

    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        MapScript = GetComponent<MapController>();
        InitGame();
    }
    void InitGame()
    {
        MapScript.SetupScene(level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
