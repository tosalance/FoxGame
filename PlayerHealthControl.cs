using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthControl : MonoBehaviour
{
    public static PlayerHealthControl instance;

    public int currentHealth, maxHealth;

    public float invincibleLength;
    private float invincibleCounter;

    private SpriteRenderer theSR;


    private void Awake()
    {
        instance = this; 
        theSR = GetComponent<SpriteRenderer>();

    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; 
    }

    // Update is called once per frame
    void Update()
    {
        if(invincibleCounter > 0)
        {
            invincibleCounter = invincibleCounter - Time.deltaTime;
            
            if(invincibleCounter <= 0)
            {
                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, 1f);
            }
        }
    }

    public void Dealdamaged()
    {
        if (invincibleCounter <= 0)
        {

            currentHealth--;

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                gameObject.SetActive(false);
            }
            else
            {
                invincibleCounter = invincibleLength;
                /*theSR.color= new Color(theSR.color.r, theSR.color.g, theSR.color.b, .5f);*/

                PlayerControl.instance.KnockBack();
            }

            UIController.instance.UpdateHealthDisplay();

        }

    }
}
