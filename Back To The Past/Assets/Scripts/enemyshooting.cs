using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public GameObject target;
    public float bulletForce = 20f;
    public Rigidbody2D rb;
    public float bulletRate;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
        InvokeRepeating("Shoot", 0.0f, bulletRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        

        Vector2 lookDir = (Vector2)target.transform.position - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
    }
}

