using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    void Start()
    {
        Invoke("des", 12);
    }


    void OnTriggerEnter2D(Collider2D coll1)
    {

        Debug.Log("sdsdsdsdsd");
        //Add damage later TODO
        if (coll1.gameObject.tag == "walls")
        {
            Destroy(gameObject);
        }

        if (coll1.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }

    void des()
    {
        Destroy(gameObject);
    }
}
