using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteHole : MonoBehaviour
{
    public GameObject gravitsys;
    public ButtonTrail buttontrail;

    void Start()
    {
        gravitsys = GameObject.Find("GravitySys");
    }

    void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Celestial")
        {
            if(collision.gameObject.transform.localScale.x > 0)
            {
                Vector3 scale = collision.gameObject.transform.localScale;
                scale.x += 100;
                scale.y += 100;
                scale.z += 100;
                collision.gameObject.transform.localScale = scale;
            }
            else
            {
                if(collision.gameObject.name == "Sun")
                {
                    gravitsys.GetComponent<GravitySystem>().celestials.Remove(collision.gameObject);
                    buttontrail.celestials.Remove(collision.gameObject);
                    collision.gameObject.SetActive(false);
                }
                else
                {
                    gravitsys.GetComponent<GravitySystem>().celestials.Remove(collision.gameObject);
                    buttontrail.celestials.Remove(collision.gameObject);
                    Destroy(collision.gameObject);
                }
            }
        }
    }
}
