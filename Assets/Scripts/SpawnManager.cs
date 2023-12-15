using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject starPrefab;
    public GameObject blackHolePrefab;

    private float xBound = 20;
    private float yBound = 10;
    private float blackHoleDelay = 3.0f;
    private float starDelay = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnStar", 0f, starDelay);
        InvokeRepeating("SpawnBlackHole", 0f, blackHoleDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnStar()
    {
        Instantiate(starPrefab, createRandomSpawn(), starPrefab.transform.rotation);
    }

    void SpawnBlackHole()
    {
        Instantiate(blackHolePrefab, createRandomSpawn(), blackHolePrefab.transform.rotation);
    }

    Vector3 createRandomSpawn()
    {
        return new Vector3(xBound, Random.Range(-yBound, yBound), 0);
    }
}
