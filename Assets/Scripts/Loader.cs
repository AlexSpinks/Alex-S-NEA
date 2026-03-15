using UnityEngine;

public class Loader : MonoBehaviour
{
    public GameObject mapManager;

    private void Awake()
    {
        if (MapManager.instance == null)
        {
            Instantiate(mapManager);
        }
    }
}
