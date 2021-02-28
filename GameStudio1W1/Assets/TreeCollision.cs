﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreeCollision : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Tree")
        {
            SceneManager.LoadScene(2);
            Debug.Log("hit");
        }
    }
    // Update is called once per frame
   
}
