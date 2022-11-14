using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class DoorDialog : MonoBehaviour
{


    public DialogManager DialogManager;


    public void PlayDialog()
    {

        var dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("ÐèÒªÁ­µ¶", "Default"));
        DialogManager.Show(dialogTexts);

    }


}
