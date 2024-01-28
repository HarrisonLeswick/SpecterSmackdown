using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 

public class damageCard : MonoBehaviour, IPointerClickHandler
{
    public GameObject ghost;
    public bool targetGhost;
    public GameObject player;
    public bool targetPlayer;

    public float damage = 0;

    public void OnPointerClick(PointerEventData eventData)
    {
        if(targetGhost){
           ghost.GetComponent<ghostBehaviour>().TakeDamage(damage);
        }
        if(targetPlayer){
           player.GetComponent<playerBehaviour>().TakeDamage(damage);
        }
    }
}
