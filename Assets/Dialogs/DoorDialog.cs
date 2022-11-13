using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class DoorDialog : MonoBehaviour
{


    public DialogManager DialogManager;

    bool isShowup = false;

    public void PlayDialog()
    {
        if (isShowup)
        {
            DialogManager.Hide();
            isShowup = false;
        }
        else
        {
            isShowup=true;
            var dialogTexts = new List<DialogData>();
            dialogTexts.Add(new DialogData("ÐèÒªÁ­µ¶", "Default"));
            DialogManager.Show(dialogTexts);
        }

    }


}
