using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treespawner : MonoBehaviour
{
    public GameObject Tree;
    private float timeSpawn;
    public float StartTimeSpawn;
    private Vector3 Spawnpos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spawnpos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        if (timeSpawn <= 0)
        {
            Instantiate(Tree, Spawnpos, transform.rotation);
            timeSpawn = StartTimeSpawn;
        }
        else
        {
            timeSpawn -= Time.deltaTime;
        }
    }
}
