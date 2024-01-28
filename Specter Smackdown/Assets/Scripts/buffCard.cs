using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 


public class buffCard : MonoBehaviour, IPointerClickHandler
{
    public GameObject ghost;
    public bool targetGhost;
    public GameObject player;
    public bool targetPlayer;

    public float multi = 0;
    public float multiLength = 0;

    public void OnPointerClick(PointerEventData eventData)
    {
        if(targetGhost){
            ghost.GetComponent<ghostBehaviour>().Debuff(multi, multiLength);
        }
        if(targetPlayer){
           player.GetComponent<playerBehaviour>().Debuff(multi, multiLength);
        }
    }

}
