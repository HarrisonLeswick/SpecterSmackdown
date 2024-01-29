using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 


public class buffCard : MonoBehaviour, IPointerClickHandler
{
    //Can target the ghost or the joker references the objects and uses a bool that is flicked on in the inspector
    public GameObject ghost;
    public bool targetGhost;
    public GameObject player;
    public bool targetPlayer;

    public float multi = 0;
    public float multiLength = 0;

    //activates if a buff card is clicked on
    public void OnPointerClick(PointerEventData eventData)
    {
        //uses functions on the player and ghost to debuff
        if(targetGhost){
            ghost.GetComponent<ghostBehaviour>().Debuff(multi, multiLength);
        }
        if(targetPlayer){
           player.GetComponent<playerBehaviour>().Debuff(multi, multiLength);
        }
    }

}
