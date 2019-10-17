using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform player;
    public GameObject prefab;
    public float shootSpeed = 5.0f;
    public float bulletLife = 5.0f;
    public float shootDelay = 4.0f;
    public float shootDistance = 4.0f;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        //player.position.x;
        //player.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Vector2 shootDirection = new Vector2(player.position.x - transform.position.x, 
                                                 player.position.y - transform.position.y);
        if(timer >= shootDelay && shootDirection.magnitude <= shootDistance)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            shootDirection.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDirection * shootSpeed;
            Destroy(bullet, bulletLife);
        }
    }
}
