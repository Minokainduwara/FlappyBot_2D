using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleSpawner : MonoBehaviour
{
    public GameObject Enemy;
    private float timeSpawn;
    public float StartTimeSpawn;
    private Vector3 Spawnpos;
    float ypos;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        ypos = Random.Range(-3.0f, 2.0f);
        Spawnpos = new Vector3(transform.position.x, ypos, transform.position.z);
        if (timeSpawn <= 0)
        {
            Instantiate(Enemy, Spawnpos, transform.rotation);
            timeSpawn = StartTimeSpawn;
        }
        else
        {
            timeSpawn -= Time.deltaTime;
        }
    }
}
