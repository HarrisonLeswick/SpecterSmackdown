using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 

public class damageCard : MonoBehaviour, IPointerClickHandler
{
     //Can target the ghost or the joker references the objects and uses a bool that is flicked on in the inspector
    public GameObject ghost;
    public bool targetGhost;
    public GameObject player;
    public bool targetPlayer;

    public float damage = 0;

    //activates if a damage card is clicked on
    public void OnPointerClick(PointerEventData eventData)
    {
        //uses functions on the player and ghost to deal damage
        if(targetGhost){
           ghost.GetComponent<ghostBehaviour>().TakeDamage(damage);
        }
        if(targetPlayer){
           player.GetComponent<playerBehaviour>().TakeDamage(damage);
        }
    }
}
