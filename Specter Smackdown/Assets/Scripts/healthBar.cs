using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update

   public void SetMaxLaugh(float maxLaugh){
    slider.maxValue = maxLaugh;
   }

   public void SetLaugh(float laughs){
    slider.value = laughs;
   }
}
