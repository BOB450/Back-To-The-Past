using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    void Start()
    {
        Invoke("des", 12);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //Add damage later TODO
        Destroy(gameObject);
    }

    void des()
    {
        Destroy(gameObject);
    }
}
