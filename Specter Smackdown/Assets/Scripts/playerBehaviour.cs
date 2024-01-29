using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehaviour : MonoBehaviour
{
    public float laughs = 0;
    public float laughsLimit;
    public float dmgMulti = 1;
    public float multiLength = 0;
    
    public healthBar laughBar;
    public  GameObject turnManager;


    void Start()
    {
        //updates the heatlh bar to the players health
        laughBar.SetMaxLaugh(laughsLimit);  
    }

    //used to deal damage to the player
    public void TakeDamage(float damage){
        //calculates damage using the debuff
        laughs += (damage * dmgMulti);
        laughBar.SetLaugh(laughs);
        Debug.Log("Ouch! Player took "+ damage + " damage! Now Player is at "+ laughs+" laughs!");
        //expends a turn of the debuff, refered to here as multi(multiplyer)
        if(multiLength > 0){
            multiLength--;
            if(multiLength == 0){
                dmgMulti = 1;
                Debug.Log("The buff wore off!");
            }
        }
        //checks if ur health is too low and kill you
        if(laughs >= laughsLimit){
            Debug.Log("Player Died");
        }
        //logs a turn so the player can know to go next
        turnManager.GetComponent<turnManager>().TakeTurn(); 
    }

    //a debuff card calls this function with the multiplyer and the how many rounds it lasts
    //this will make the player take more or less damage
    public void Debuff(float multi, float length){
        dmgMulti = multi;
        multiLength = length;
        Debug.Log("I now take "+ dmgMulti +"x damage for "+ multiLength + " turn!");
        turnManager.GetComponent<turnManager>().TakeTurn(); 
    }

    //USed for debugging because the ghost has no moves yet he just does 20 damage each turn
    public void TestDamage(){
        laughs += (20 * dmgMulti);
        Debug.Log("Ouch! Player took "+ (20 * dmgMulti) + " damage! Now Player is at "+ laughs +" laughs!");
       laughBar.SetLaugh(laughs);
       turnManager.GetComponent<turnManager>().TakeTurn(); 
    }
}
