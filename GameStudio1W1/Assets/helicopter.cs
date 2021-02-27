using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helicopter : MonoBehaviour
{
    private float MoveSpeed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * MoveSpeed *Time.deltaTime;

        transform.Translate(rotation, 0, 0);
        transform.Translate(0, translation, 0);
    }

        
}
