using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
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
                scale.x -= 500;
                scale.y -= 500;
                scale.z -= 500;
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
