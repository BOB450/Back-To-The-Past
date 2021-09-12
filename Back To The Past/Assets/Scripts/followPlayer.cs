using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{

    private Vector2 velocity;
    public float smoothTimeY;
    public float smoothtimeX;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
      //  player = GameObject.FindWithTag("Player");
    }

    void LateUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothtimeX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);

        transform.position = new Vector3(posX, posY, transform.position.z);
    }

}
