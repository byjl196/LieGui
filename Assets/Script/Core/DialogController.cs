using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Doublsb.Dialog;

public class DialogController : MonoBehaviour
{
    public UnityEvent OnDialogHide=new UnityEvent();

    public DialogBase currentDialog;

    public DialogManager DialogManager;


    public void OnDialogHideCallBack()
    {
        Debug.Log("dailog finish");
        OnDialogHide.Invoke();
    }


}
