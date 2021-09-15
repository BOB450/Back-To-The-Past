using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour
{

    public int playerHealth = 100;
    public Slider slider;
    public Image fill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Debug.Log("damage");
                playerHealth = playerHealth - 30;
            slider.value = playerHealth;
            Debug.Log(playerHealth);
        }

        if (collision.gameObject.tag == "enemyBullet")
        {
            Debug.Log("damage");
            playerHealth = playerHealth - 5;
            slider.value = playerHealth;
            Debug.Log(playerHealth);
        }
    }

    void OnTriggerEnter2D(Collider2D coll1)
    {

        if (coll1.gameObject.tag == "enemyBullet")
        {
            Debug.Log("damage");
            playerHealth = playerHealth - 5;
            slider.value = playerHealth;
            Debug.Log(playerHealth);
        }

    }

}
