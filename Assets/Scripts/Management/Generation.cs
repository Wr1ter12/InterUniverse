using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    [SerializeField] GameObject _star;
    [SerializeField] GameObject _planet;
    GameObject obj;
    [SerializeField] GravitySystem gravitsys;
    [SerializeField] GameObject buttontrail;
    [SerializeField] ButtonDestroy buttondestroy;
    int count;
    float rand;
    float scale;
    float masses;
    float axes;
    float range;

    void Start()
    {
        rand = Random.value;
        if(rand > 0.5)
        {
            obj = Instantiate(_star, new Vector3(0, 0, 0), Quaternion.identity);
            CreatingStar(obj);
        }
        else if (rand > 0.25)
        {
            obj = Instantiate(_star, new Vector3(5000f, 0, 0), Quaternion.identity);
            CreatingStar(obj);
            obj = Instantiate(_star, new Vector3(-5000f, 0, 0), Quaternion.identity);
            CreatingStar(obj);
        }
        else
        {
            obj = Instantiate(_star, new Vector3(5000f, 0, 0), Quaternion.identity);
            CreatingStar(obj);
            obj = Instantiate(_star, new Vector3(-5000f, 0, 0), Quaternion.identity);
            CreatingStar(obj);
            obj = Instantiate(_star, new Vector3(0, 5000f, 0), Quaternion.identity);
            CreatingStar(obj);
        }
        rand = Random.Range(3, 10);
        for(int i = 0; i < rand + 1; i++)
        {
            range += Random.Range(5000, 50000);
            obj = Instantiate(_planet, new Vector3(0, 0, range), Quaternion.identity);
            CreatingPlanet(obj);
        }
    }

    void CreatingStar(GameObject obj)
    {
        obj.name = count.ToString();
        count += 1;
        scale = Random.Range(50000, 300000);
        obj.gameObject.transform.localScale = new Vector3(scale, scale, scale);
        masses = Random.Range(100000, 500000);
        obj.GetComponent<Rigidbody>().mass = masses;
        axes = Random.Range(0.001f, 0.9f);
        obj.GetComponent<SpeedController>().speed = axes;
        gravitsys.GetComponent<GravitySystem>().Celestials();
        buttontrail.GetComponent<ButtonTrail>().Celestials();
        buttondestroy.GetComponent<ButtonDestroy>().Celestials();
    }

    void CreatingPlanet(GameObject obj)
    {
        obj.name = count.ToString();
        count += 1;
        scale = Random.Range(1000f, 30000f);
        obj.gameObject.transform.localScale = new Vector3(scale, scale, scale);
        masses = Random.Range(0.05f, 10000f);
        obj.GetComponent<Rigidbody>().mass = masses;
        axes = Random.Range(0.001f, 0.9f);
        obj.GetComponent<SpeedController>().speed = axes;
        gravitsys.GetComponent<GravitySystem>().Celestials();
        buttontrail.GetComponent<ButtonTrail>().Celestials();
        buttondestroy.GetComponent<ButtonDestroy>().Celestials();
    }
}
