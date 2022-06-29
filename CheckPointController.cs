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
        //loop dang for, cho kí tu int i = o, trong unity set cplength(do dài's list) = 3 thì 0<3, khi dó i+1 và do thing below, sau do loop cho den khi i + cplenght(vidu=3) thì stop
        {
            checkpoints[i].ResetCheckPoint();
            // i này t??ng tr?ng cho s? trong bang list checkpoint
           
        }
    }

    public void SetSpawnPoint(Vector3 newSpawnPoint) //varible newSpawnPoint only exist within this function
    {
        spawnPoint = newSpawnPoint;
    }

}
