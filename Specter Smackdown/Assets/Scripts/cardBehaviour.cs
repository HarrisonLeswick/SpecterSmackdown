using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 

public class cardBehaviour : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    private Vector3 scaleNormal = new Vector3(1.5f, 2.0f, 1.0f);
    private Vector3 scaleChange = new Vector3(2.25f, 3.0f, 1.0f);

public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("clicked");
    }

public void OnPointerEnter(PointerEventData eventData)
   {
        gameObject.transform.localScale = scaleChange;
   }

     
public void OnPointerExit(PointerEventData eventData)
   {
        gameObject.transform.localScale = scaleNormal;
   }
}
