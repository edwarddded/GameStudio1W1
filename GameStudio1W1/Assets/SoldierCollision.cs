using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Soldier")
        {
            Destroy(other.gameObject);
            Debug.Log("Pick up");
        }
    }
}
