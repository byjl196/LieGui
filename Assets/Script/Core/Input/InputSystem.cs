using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{

    public InputComponent currentTarget;


    public void Update()
    {
        GetDirInput();
        FunctionA();
        FunctionB(); 
        FunctionC();
    }



    public void GetDirInput()
    {
        var inputx = Input.GetAxisRaw("Horizontal");
        var inputy = Input.GetAxisRaw("Vertical");
        currentTarget.DirEventInput(new Vector2(inputx, inputy));
    }

    void FunctionA()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            currentTarget.FuncAEvent.Invoke();
        }
    }
    void FunctionB()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentTarget.FuncBEvent.Invoke();
        }
    }


    void FunctionC()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            currentTarget.FuncCEvent.Invoke();
        }
    }



    public void ChangeInputReciver(InputComponent newReceiver)
    {
        currentTarget.dirInput = Vector2.zero;
        currentTarget = newReceiver;

    }



}
