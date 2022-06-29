using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public bool isGem, isHeal;

    private bool isCollected, isHealed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isCollected && !isHealed)
            // play collide into gem va iscolect la false thi moi dc thuc hien, tranh vong loop pickup gem lien tuc 
        {
            if (isGem)
            {

                LevelManager.instance.gemsCollected++;

                isCollected = true;
                Destroy(gameObject);

            }


            if (isHeal)
            {
                if (PlayerHealthControl.instance.currentHealth != PlayerHealthControl.instance.maxHealth)
                    // != not equal 
                {
                    PlayerHealthControl.instance.HealPlayer();
                    isHealed= true;
                    Destroy(gameObject);
                }


            }

        }

        
    }
}
