using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;
    float randomHeight = 0.5f;
    // Start is called before the first frame update
    void SpawnPipes()
    {
        Instantiate(pipePrefab, new Vector2(8, Random.Range(-8.8f, -5.71f)), Quaternion.identity);
    }

    // Update is called once per frame
    void Start()
    {
       InvokeRepeating("SpawnPipes", 1.0f, 1.5f);
    }
}
