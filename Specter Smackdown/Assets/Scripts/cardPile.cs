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


    public void OnPointerClick(PointerEventData eventData)
    {
        for(int i = 0; i < cards.Length - 1; i++) {
			int rnd = Random.Range(i, cards.Length);
			tempGO = cards[rnd];
			cards[rnd] = cards[i];
            cards[i] = tempGO;
        }
        for(int i = 0; i < cards.Length; i++){
            cards[i].transform.position = cardPos[i];
        }
        for(int i = 0; i < cardBlank; i++){
            cards[i].SetActive(true);
        }
        for(int i = cardBlank; i < cards.Length; i++){
            cards[i].SetActive(false);
        }

    }
}
