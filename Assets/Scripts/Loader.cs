using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{


    public GameObject mapManager;


    private void Awake()
    {
        if(MapManager.instance == null)
        {
            Instantiate(mapManager);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
