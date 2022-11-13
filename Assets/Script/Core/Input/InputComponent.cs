using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class InputComponent : MonoBehaviour
{
    public Vector3 dirInput;


    public UnityEvent FuncAEvent = new UnityEvent();
    public UnityEvent FuncBEvent = new UnityEvent();
    public UnityEvent FuncCEvent = new UnityEvent();



    public void DirEventInput(Vector2 input)
    {
        //DirEvent.Invoke();
        dirInput = input;
    }


    public void FuncA()
    {
        FuncAEvent.Invoke();
    }
    public void FuncB()
    {
        FuncBEvent.Invoke();
    }
    public void FuncC()
    {
        FuncCEvent.Invoke();
    }




}
