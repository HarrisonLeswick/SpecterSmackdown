using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 

public class cardRegen : MonoBehaviour, IPointerClickHandler
{
    public GameObject cardPile;
    public int slot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        gameObject.SetActive(false);
        gameObject.transform.localScale = new Vector3(1.5f, 2.0f, 1.0f);;
        cardPile.GetComponent<cardPile>().SlideDown(slot);


    }

    public void NewSlot(int i){
        slot = i;
    }
}
