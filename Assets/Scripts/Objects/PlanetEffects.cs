using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetEffects : MonoBehaviour
{
    [SerializeField] GameObject Destroy;

    void OnDisable()
    {
        GameObject part = Instantiate(Destroy, gameObject.transform.position, Quaternion.identity);
        part.transform.localScale = gameObject.transform.localScale / 50;
    }

    void OnDestroy()
    {
        GameObject part = Instantiate(Destroy, gameObject.transform.position, Quaternion.identity);
        part.transform.localScale = gameObject.transform.localScale / 50;
    }
}
