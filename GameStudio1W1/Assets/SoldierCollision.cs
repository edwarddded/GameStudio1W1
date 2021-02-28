using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoldierCollision : MonoBehaviour
{
    //public MissileCollision MC;
    public Text Soldiertext;
    int pickup = 0;
    int value = 1;

    public Text ScoreText;
    int score = 0;
    int scorevalue = 200;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Soldier"&& pickup <3)
        {
            
            Destroy(other.gameObject);

            //*************
            pickup += value;
            Soldiertext.text = "Pick up Soldier:" + pickup.ToString();
            //the number of soldier already pick up

            //***********
            score += scorevalue;
            ScoreText.text = "Score:" + score.ToString();

            Debug.Log("Pick up");
        }
        else if (other.gameObject.tag == "Soldier" && pickup ==3)
        {
            Debug.Log("Full");
        }
    }
}
