using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeWater : MonoBehaviour
{

    public int WaterDrops;
    public GameObject Win;
    float pos;
    Vector2 newPos;

    bool Completed;
    // Start is called before the first frame update
    void Start()
    {
        newPos = new Vector2(transform.position.x, transform.position.y);
        Completed = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Destroy(collision.gameObject);
        collision.gameObject.SetActive(false);
        WaterDrops++;
        pos = pos+0.1f;
        newPos = new Vector2(transform.position.x, transform.position.y + pos);
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), newPos, 1 * Time.deltaTime);
        SpawnWater.instance.WaterScore();
        if (WaterDrops >= 80   && !Completed) {
            Completed = true;
                Win.SetActive(true);
                int CurrentLevel = PlayerPrefs.GetInt("Level", 1);
                PlayerPrefs.SetInt("Level", CurrentLevel+1);
                Adcontrol.instance.ShowInterstitial();
            

        }
    }
}
