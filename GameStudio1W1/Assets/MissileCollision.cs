using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissileCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Missile")
        {
            //SceneManager.LoadScene();
            Debug.Log("crash");
            SceneManager.LoadScene(2);
        }
        else if (other.gameObject.tag == "Border")
        {
            Debug.Log("hit");
            SceneManager.LoadScene(2);
        }
    }
}
