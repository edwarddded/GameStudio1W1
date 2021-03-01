using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag =="Tree")
        {
            Debug.Log(other.name);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Missile")
        {
            Debug.Log(other.name);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Soldier")
        {
            Debug.Log(other.name);
            Destroy(gameObject);
        }

    }

    // Update is called once per frame

}
