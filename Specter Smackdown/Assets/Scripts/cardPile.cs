using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 

public class cardPile : MonoBehaviour, IPointerClickHandler
{
    public GameObject[] cards;
    private GameObject tempGO;
    public Vector3[] cardPos;
    public int cardCount = 11;
    public int cardBlank = 4;
    public int missingCards = 0;


    public void OnPointerClick(PointerEventData eventData)
    {
        for(;missingCards > 0; missingCards--){

            //chooses a random card and swaps it with a slot
            int rnd = Random.Range(cardBlank, 9);
			tempGO = cards[rnd];
			cards[rnd] = cards[4-missingCards];
            cards[4-missingCards] = tempGO;

            //put it in the right spot and make it active
            cards[4-missingCards].SetActive(true);
            cards[4-missingCards].transform.position = cardPos[4-missingCards];

            //tell the card its slot
            cards[4-missingCards].GetComponent<cardRegen>().NewSlot(5-missingCards);

        }
    }

    /*makes sure the gap is on the right
    intakes the slot so it knows how many to slide down ie. if the 2nd card is missing the 3rd and 4th
    have to slide down*/
    public void SlideDown(int slot){
        //stores the used card so the rest can move
        tempGO = cards[slot-1];
        for(int i = slot; i < cardBlank; i++){
             cards[i-1] = cards [i];
             cards[i-1].transform.position = cardPos[i-1];

             //used to let moved cards keep track of their position
             cards[i-1].GetComponent<cardRegen>().NewSlot(i);
        }
        //After all cards are slid the used card is in the 4th spot
        cards[3] = tempGO;
        cards[3].GetComponent<cardRegen>().NewSlot(4);
        missingCards++;
    }
}
