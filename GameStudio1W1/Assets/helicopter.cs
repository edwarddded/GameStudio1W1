using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class helicopter : MonoBehaviour
{
    private float MoveSpeed = 6f;
    Rigidbody2D rb2d;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        float translation = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * MoveSpeed *Time.deltaTime;
        if (rotation <0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
        transform.Translate(rotation, 0, 0);
        transform.Translate(0, translation, 0);
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


        
}
