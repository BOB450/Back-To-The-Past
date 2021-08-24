using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D coll)
    {
        //Add damage later TODO
        Destroy(gameObject);
    }


}
