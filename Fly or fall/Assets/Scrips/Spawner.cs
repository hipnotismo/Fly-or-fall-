using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour{

    public GameObject obstacle;

    private float timeBtwSpawn;
    public float starTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    private void Update(){
        if (timeBtwSpawn <= 0)
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            timeBtwSpawn = starTimeBtwSpawn;
            if(starTimeBtwSpawn > minTime)
            {
                starTimeBtwSpawn -= decreaseTime;

            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
