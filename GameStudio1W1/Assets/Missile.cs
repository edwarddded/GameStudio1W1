using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 9f;
    public float PositionMin;
    public float PositionMax;
    SpriteRenderer sr;
    float health = 2f;
    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Bullet")
        {
            health --;
            if (health ==0)
            {
                Destroy(gameObject);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.up * speed * Time.deltaTime;
        if (transform.position.y >= PositionMax)
        {
            speed = -speed;
            sr.flipX = true;
        }
        else if (transform.position.y <= PositionMin)
        {
            speed = -speed;
            sr.flipX = false;
        }
    }
}
