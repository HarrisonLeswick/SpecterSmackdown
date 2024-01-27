using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostBehaviour : MonoBehaviour
{

    public float health;
    public float dmgMulti = 1;
    public float multiLength = 0;
    //[SerializeField] private GameObject floating

    public void TakeDamage(float damage){
        health -= (damage * dmgMulti);
        Debug.Log("Ouch! I'm "+ health+" health");
        if(multiLength > 0){
            multiLength--;
            if(multiLength == 0){
                dmgMulti = 1;
                Debug.Log("The buff wore off!");
            }
        }
        if(health <= 0){
            Debug.Log("I Died");
        }
    }

    public void Debuff(float multi, float length){
        dmgMulti = multi;
        multiLength = length;
        Debug.Log("I know do "+ dmgMulti +"x damage for "+ multiLength + " turn!");
    }

    
}
