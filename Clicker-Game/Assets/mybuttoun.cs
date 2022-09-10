using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mybuttoun : MonoBehaviour
{



    int score = 0;
    int inc = 1;
    public int price;



    public Text ScoreText;
    public Text IncText;
    public Text PriceText;


    public void ScoreUp(){

        score+=1;
        ScoreText.text = "Your Score : " + score.ToString();
       

    }


    public void Increment()
    {


       if(score > price * inc)
        {

            score -= price * inc;
            ScoreText.text = "Your Score : " + score.ToString();

            inc += 1;
            price = (inc * price);


            IncText.text = "Your INC : " + inc.ToString();
           
            PriceText.text = "Price : " + price.ToString();
            


        }



    }




}
