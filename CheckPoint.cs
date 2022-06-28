using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public SpriteRenderer theSR;

    public Sprite cpOn, cpOff;



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
        if (other.CompareTag("Player"))
        {
            CheckPointController.instance.DeactivateCheckPoints(); 

            theSR.sprite = cpOn;  
            
            CheckPointController.instance.SetSpawnPoint(transform.position);

        }
    }

    public void ResetCheckPoint()
    {
        theSR.sprite = cpOff;
    }
}
 
