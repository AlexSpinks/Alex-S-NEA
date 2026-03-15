using System.Collections.Generic;
using UnityEngine;

public class PropRandomiser : MonoBehaviour
{
    public List<GameObject> propSpawnPoints;
    public List<GameObject> propPrefabs;

    private void Start()
    {
        SpawnProps();
    }

    private void SpawnProps()
    {
        foreach (GameObject spawnPoint in propSpawnPoints)
        {
            int rand = Random.Range(0, propPrefabs.Count);
            Instantiate(propPrefabs[rand], spawnPoint.transform.position, Quaternion.identity);
        }
    }
}
