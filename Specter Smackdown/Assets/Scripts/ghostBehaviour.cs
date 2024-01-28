using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostBehaviour : MonoBehaviour
{

    public float laughs = 0;
    public float laughsLimit;
    public float dmgMulti = 1;
    public float multiLength = 0;

    public healthBar laughBar;

    public  GameObject turnManager;
    public  GameObject player;


    void Start()
    {
        laughBar.SetMaxLaugh(laughsLimit);  
    }
    
    public void TakeDamage(float damage){
        laughs += (damage * dmgMulti);
        laughBar.SetLaugh(laughs);
        Debug.Log("Ouch! Ghost took "+ damage + " damage! Now Ghost is at "+ laughs+" laughs!");
        if(multiLength > 0){
            multiLength--;
            if(multiLength == 0){
                dmgMulti = 1;
                Debug.Log("The buff wore off!");
            }
        }
        if(laughs >= laughsLimit){
            Debug.Log("Ghost Died");
        }
           turnManager.GetComponent<turnManager>().TakeTurn(); 
        }

    public void Debuff(float multi, float length){
        dmgMulti = multi;
        multiLength = length;
        Debug.Log("Ghost now does "+ dmgMulti +"x damage for "+ multiLength + " turn!");
           turnManager.GetComponent<turnManager>().TakeTurn(); 

        }

    
}
