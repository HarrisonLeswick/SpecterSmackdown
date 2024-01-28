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

    // Start is called before the first frame update
    void Start()
    {
        laughBar.SetMaxLaugh(laughsLimit);  
    }
    public void TakeDamage(float damage){
        laughs += (damage * dmgMulti);
        laughBar.SetLaugh(laughs);
        Debug.Log("Ouch! Player took "+ damage + " damage! Now Player is at "+ laughs+" laughs!");
        if(multiLength > 0){
            multiLength--;
            if(multiLength == 0){
                dmgMulti = 1;
                Debug.Log("The buff wore off!");
            }
        }
        if(laughs >= laughsLimit){
            Debug.Log("Player Died");
        }
    }

    public void Debuff(float multi, float length){
        dmgMulti = multi;
        multiLength = length;
        Debug.Log("I know do "+ dmgMulti +"x damage for "+ multiLength + " turn!");
    }

    public void TestDamage(){
        laughs += 20;
        Debug.Log("Player took 20 damage!");
       laughBar.SetLaugh(laughs);
       turnManager.GetComponent<turnManager>().TakeTurn(); 
    }
}
