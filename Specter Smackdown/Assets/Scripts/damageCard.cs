using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 

public class damageCard : MonoBehaviour, IPointerClickHandler
{
    public  GameObject ghost;

    public float damage = 0;
    // Start is called before the first frame update
    void Start()
    {
        //ghost = GameObject.Find("Ghost").GetComponent("ghostBehaviour");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {

        ghost.GetComponent<ghostBehaviour>().TakeDamage(damage);
    }
}
