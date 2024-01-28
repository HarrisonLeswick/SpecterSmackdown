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
            int rnd = Random.Range(cardBlank, cards.Length);
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

    public void SlideDown(int slot){
        tempGO = cards[slot-1];
        for(int i = slot; i < cardBlank; i++){
             cards[i-1] = cards [i];
             cards[i-1].transform.position = cardPos[i-1];
             cards[i-1].GetComponent<cardRegen>().NewSlot(i);
        }
        cards[3] = tempGO;
        cards[3].GetComponent<cardRegen>().NewSlot(4);
        missingCards++;
    }
}
