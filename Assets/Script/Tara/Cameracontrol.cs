using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Cameracontrol : MonoBehaviour
{

    public CinemachineVirtualCamera vcam;


    public void ChangeTarget(Transform target)
    {

        vcam.Follow = target;


    }


}
