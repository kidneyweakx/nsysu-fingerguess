using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public bool isEnemy = false;
    public RectTransform HealthBar,Hurt;
    public GameObject loser, winner;


    void Update()

    {   
        if(!isEnemy){ 
           HealthBar.sizeDelta = new Vector2(variable.health, HealthBar.sizeDelta.y);
           if (Hurt.sizeDelta.x > HealthBar.sizeDelta.x) Hurt.sizeDelta += new Vector2(-1, 0)*Time.deltaTime*10;
        }
        else if(isEnemy){
            HealthBar.sizeDelta = new Vector2(variable.ehealth, HealthBar.sizeDelta.y);
            if (Hurt.sizeDelta.x > HealthBar.sizeDelta.x) Hurt.sizeDelta += new Vector2(-1, 0)*Time.deltaTime*10;
        }    
       
        if(variable.health <1){
            loser.SetActive(true);
        }else if(variable.ehealth<1){
            winner.SetActive(true);
        }
    }
}
