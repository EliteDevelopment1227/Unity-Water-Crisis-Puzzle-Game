using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Water2D;
public class SpawnWater : MonoBehaviour
{
    public static SpawnWater instance;
    public bool WaterSpawned;
    public float waterDrop = 0;

    public void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        WaterSpawned = false;
    }

    public void SpawnReady() {
       WaterSpawned = true;
        Water2D_Spawner.instance.SpawnAll();
    }

    public void WaterScore() {
        waterDrop++;
    }
}
