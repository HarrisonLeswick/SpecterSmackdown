using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnManager : MonoBehaviour
{
    public GameObject player;
    public GameObject ghost;

    public int turnNum = 0;
    public bool playerTurn = false;
    public bool ghostTurn = true;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeTurn(){
        playerTurn = !playerTurn;
        ghostTurn = !ghostTurn;
        turnNum++;
        if(ghostTurn){
            player.GetComponent<playerBehaviour>().TestDamage();
        }
    }
}
