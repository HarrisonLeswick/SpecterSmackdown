using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnManager : MonoBehaviour
{
    //References for the player and the ghost
    public GameObject player;
    public GameObject ghost;

    //tracks the turn number and whos turn it is using bools
    public int turnNum = 0;
    public bool playerTurn = false;
    public bool ghostTurn = true;

    //swaps the turn bools, tallies another turn 
    public void TakeTurn(){
        playerTurn = !playerTurn;
        ghostTurn = !ghostTurn;
        turnNum++;

        //Just for debugging will do 20 damage and reset the turn 
        if(ghostTurn){
            player.GetComponent<playerBehaviour>().TestDamage();
        }
    }
}
