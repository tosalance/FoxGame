using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour
{

    public static CheckPointController instance;

    private CheckPoint[] checkpoints;
    // checkpoint[]: checkpoint Array

    public Vector3 spawnPoint;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        checkpoints = FindObjectsOfType<CheckPoint>(); 

        spawnPoint = PlayerControl.instance.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeactivateCheckPoints()
    {
        for(int i = 0; i < checkpoints.Length; i++)
        //loop dang for, cho k� tu int i = o, trong unity set cplength(do d�i's list) = 3 th� 0<3, khi d� i+1 v� do thing below, sau do loop cho den khi i + cplenght(vidu=3) th� stop
        {
            checkpoints[i].ResetCheckPoint();
            // i n�y t??ng tr?ng cho s? trong bang list checkpoint
           
        }
    }

    public void SetSpawnPoint(Vector3 newSpawnPoint) //varible newSpawnPoint only exist within this function
    {
        spawnPoint = newSpawnPoint;
    }

}
