using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject starPrefab;
    public GameObject blackHolePrefab;

    private float xBound = 20;
    private float yBound = 10;

    // Start is called before the first frame update
    void Start()
    {
        SpawnStar();
        SpawnBlackHole();
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
