using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject prefab;
    public float spawnTime;

    private void Start()
    {
        InvokeRepeating("Spawn", 2f, Random.Range(0,5));
    }

    private void Spawn()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
