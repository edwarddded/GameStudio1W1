﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoldierCollision : MonoBehaviour
{
    //soldier already pick up
    public Text Soldiertext;
    int pickup = 0;
    int value = 1;

    //total soldier pick up
    public Text total;
    int totalpick = 0;

    // Game Score
    public Text ScoreText;
    int score = 0;
    int scorevalue = 200;

    //Soldier aleady secured 

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

            //**********
            score += scorevalue;
            ScoreText.text = "Score:" + score.ToString();

            Debug.Log("Pick up");
        }
        else if (other.gameObject.tag == "Soldier" && pickup ==3)
        {
            Debug.Log("Full");
        }

        if (other.gameObject.tag == "Hospital" )
        {
            totalpick = totalpick + pickup;
            total.text = "Total Rescued Soldier:" + totalpick.ToString();
            Debug.Log("heal");
            pickup = 0;
        }
       
        
    }

    private void FixedUpdate()
    {
        if (pickup == 0 && totalpick ==6)
        {
            SceneManager.LoadScene(3);
        }
    }
}
