using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroid;
    int spawnperiod;
    int asteroidcount;

    private void Awake()
    {
        asteroidcount = Random.Range(1, 2);
        for(int i = 0; i < asteroidcount; i++)
        {
            int x = Random.Range(-10000, 10000);
            int y = Random.Range(-3000, 3000);
            int z = Random.Range(35000, 45000);
            GameObject newaster = Instantiate(asteroid, new Vector3(x,y,z), Quaternion.identity);
            newaster.GetComponent<SpeedController>().speed = Random.Range(0.05f, 0.08f);
            newaster.GetComponent<Rigidbody>().mass = Random.Range(0.5f, 2f);
            int scales = Random.Range(10000, 12500);
            newaster.gameObject.transform.localScale = new Vector3(scales, scales, scales);
        }

        asteroidcount = Random.Range(1, 2);
        for(int i = 0; i < asteroidcount; i++)
        {
            int x = Random.Range(-10000, 10000);
            int y = Random.Range(-3000, 3000);
            int z = Random.Range(-35000, -45000);
            GameObject newaster = Instantiate(asteroid, new Vector3(x,y,z), Quaternion.Euler(0,180,0));
            newaster.GetComponent<SpeedController>().speed = Random.Range(0.05f, 0.08f);
            int scales = Random.Range(10000, 12500);
            newaster.gameObject.transform.localScale = new Vector3(scales, scales, scales);
        }

        asteroidcount = Random.Range(1, 2);
        for(int i = 0; i < asteroidcount; i++)
        {
            int x = Random.Range(35000, 45000);
            int y = Random.Range(-3000, 3000);
            int z = Random.Range(-10000, 10000);
            GameObject newaster = Instantiate(asteroid, new Vector3(x,y,z), Quaternion.Euler(0,90,0));
            newaster.GetComponent<SpeedController>().speed = Random.Range(0.05f, 0.08f);
            int scales = Random.Range(10000, 12500);
            newaster.gameObject.transform.localScale = new Vector3(scales, scales, scales);
        }

        asteroidcount = Random.Range(1, 2);
        for(int i = 0; i < asteroidcount; i++)
        {
            int x = Random.Range(-35000, -45000);
            int y = Random.Range(-3000, 3000);
            int z = Random.Range(-10000, 10000);
            GameObject newaster = Instantiate(asteroid, new Vector3(x,y,z), Quaternion.Euler(0,-90,0));
            newaster.GetComponent<SpeedController>().speed = Random.Range(0.05f, 0.08f);
            int scales = Random.Range(10000, 12500);
            newaster.gameObject.transform.localScale = new Vector3(scales, scales, scales);
        }
    }
}
