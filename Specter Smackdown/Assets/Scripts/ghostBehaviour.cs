using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostBehaviour : MonoBehaviour
{

    public enum DebuffMulti{
        OPFX,
        TwoX
    }
    public float health ;
    public float dmgMulti = 1;
    //[SerializeField] private GameObject floating

    public void TakeDamage(float damage){
        health -= (damage * dmgMulti);
        Debug.Log("Ouch! I'm "+ health+" health");
        if(health <= 0){
            Debug.Log("I Died");
        }
    }

    public void Debuff(){
       /* if(debuff == Debuff.OPFX){
            dmgMulti = 1.5f;
            Debug.log("1.5 damage");
        }
        else if(debuff == Debuff.TwoX){
            dmgMulti = 2.0f;
            Debug.log("2.0 damage");
        }*/
    }

    
}
