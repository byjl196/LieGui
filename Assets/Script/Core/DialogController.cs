using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class DialogController : MonoBehaviour
{
    public UnityEvent OnDialogHide=new UnityEvent();

    public void OnDialogHideCallBack()
    {
        OnDialogHide.Invoke();
    }


}
