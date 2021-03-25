using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuWater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Water2D.Water2D_Spawner.instance.Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
