using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject Player;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }



    void Update()
    {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y,-10);
        
    }
}
