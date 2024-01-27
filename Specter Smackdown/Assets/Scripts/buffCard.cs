using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 


public class buffCard : MonoBehaviour, IPointerClickHandler
{
    public  GameObject ghost;
    public float multi = 0;
    public float multiLength = 0;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        ghost.GetComponent<ghostBehaviour>().Debuff(multi, multiLength);
    }

}
