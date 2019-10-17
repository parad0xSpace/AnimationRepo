using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject prefab;
    public float shootSpeed = 100.0f;
    public float bulletLife = 5.0f;
    public float shootDelay = 0.2f;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(Input.GetButton("Fire1") && timer >= shootDelay)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            //get mouse position in xy pizels on screen
            Vector3 mousePosition = Input.mousePosition;
            Debug.Log("mouse pos 1: " + mousePosition);
            //convert xy pixels to game world position
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Debug.Log("mouse pos 2: " + mousePosition);
            mousePosition.z = 0;
            Vector2 shootDirection = new Vector2(mousePosition.x - transform.position.x, 
                                                 mousePosition.y - transform.position.y);
            shootDirection.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDirection * shootSpeed;
            Destroy(bullet, bulletLife);
        }
    }
}
