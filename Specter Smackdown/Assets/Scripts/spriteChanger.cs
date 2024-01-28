using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteChanger : MonoBehaviour
{

    public SpriteRenderer ghostSprites;
    public Sprite ghostSprite1;
    public Sprite ghostSprite2;
    public Sprite ghostSprite3;
    public Sprite ghostSprite4;
    public Sprite ghostSprite5;

    private void Start()
    {
        ghostSprites = gameObject.GetComponent<SpriteRenderer>();
        ghostSprites.sprite = ghostSprite1;
    }


    // Update is called once per frame
    void Update()
    {
        if (GetComponent<ghostBehaviour>().laughs >= 25 && GetComponent<ghostBehaviour>().laughs < 50)
        {
            ghostSprites.sprite = ghostSprite2;
            
        }

        if (GetComponent<ghostBehaviour>().laughs >= 50 && GetComponent<ghostBehaviour>().laughs < 75)
        {
            ghostSprites.sprite = ghostSprite3;

        }

        if (GetComponent<ghostBehaviour>().laughs >= 75 && GetComponent<ghostBehaviour>().laughs < 100)
        {
            ghostSprites.sprite = ghostSprite4;

        }

        if (GetComponent<ghostBehaviour>().laughs >= 100)
        {
            ghostSprites.sprite = ghostSprite5;

        }
    }
}
