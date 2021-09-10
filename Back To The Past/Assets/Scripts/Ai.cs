using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ai : MonoBehaviour
{

    public Transform Player;
   public int MoveSpeed = 7;
   public     int MaxDist = 10;
    public int MinDist = 0;




    void Start()
    {

    }

    void Update()
    {

        


         transform.LookAt(Player);

        if (Vector2.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;



            if (Vector2.Distance(transform.position, Player.position) <= MaxDist)
            {
                //Here Call any function U want Like Shoot at here or something
            }

        }
    }
}