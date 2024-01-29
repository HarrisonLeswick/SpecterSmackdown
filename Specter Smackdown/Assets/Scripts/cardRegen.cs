using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 

public class cardRegen : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    //used to reference the card manager
    public GameObject cardPile;

    //stores what slot it is in
    public int slot;

    //Used the enlarge the card when u hover on it
    private Vector3 scaleNormal = new Vector3(0.1f, 0.13f, 1.0f);
    private Vector3 scaleChange = new Vector3(0.15f, 0.2f, 1.0f);

    //When mouse is above a card it enlarges using its scale
    public void OnPointerEnter(PointerEventData eventData)
   {
        gameObject.transform.localScale = scaleChange;
   }

    //When the mouse leaves it will shrink back to its normal size
    public void OnPointerExit(PointerEventData eventData)
   {
        gameObject.transform.localScale = scaleNormal;
   }

    /*Disposes on a card. When used/clicked it will turn the card off and message the card manager
    to slide the rest down so the gap in cards is on the right*/
    public void OnPointerClick(PointerEventData eventData)
    {
        gameObject.SetActive(false);
        gameObject.transform.localScale = new Vector3(1.5f, 2.0f, 1.0f);;
        cardPile.GetComponent<cardPile>().SlideDown(slot);
    }

    /*if a card is visible it needs to know so it will store its slot number and if it 
    is not in a slot it will be in slot 0
    */
    public void NewSlot(int i){
        slot = i;
    }
}
