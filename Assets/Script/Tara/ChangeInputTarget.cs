using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeInputTarget : MonoBehaviour
{
    public InputComponent inputREceiver;

    public void ChangeInputController()
    {
        GameCore.gamecore.input.ChangeInputReciver(inputREceiver);
    }

}
