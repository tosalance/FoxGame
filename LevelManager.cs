using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public float waitToRespawn;

    public int gemsCollected;
    public int healthCollected;

    private void Awake()
    {
        instance = this;    
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reSpawnPlayer()
    {

        StartCoroutine(RespawnCo());

    }


    // this structure call  CORROUTINE , it reset everything after player death
    private IEnumerator RespawnCo()
    {
        PlayerControl.instance.gameObject.SetActive(false);

        yield return new WaitForSeconds(waitToRespawn);

        PlayerControl.instance.gameObject.SetActive(true);

        PlayerControl.instance.transform.position = CheckPointController.instance.spawnPoint;

        PlayerHealthControl.instance.currentHealth = PlayerHealthControl.instance.maxHealth;
        
        UIController.instance.UpdateHealthDisplay();  

    }
}
