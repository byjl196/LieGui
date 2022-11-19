using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Doublsb.Dialog;

[System.Serializable]
public struct DialogDataContent
{ 
    public string content;
    public string character;
}

public class DialogBase : MonoBehaviour
{
    public List<DialogDataContent> dialogDatalist;
    public UnityEvent dialogFinishEvent = new UnityEvent();

    public DialogManager dialogManager { get { return GameCore.gamecore.dialog.DialogManager; } }

    public virtual void PlayDialog()
    {
        //dialogFinishEvent.AddListener(() => ChangeInputControl(GameCore.gamecore.player.gameObject));
        dialogFinishEvent.AddListener(ChangeToPlayer);
        GameCore.gamecore.dialog.currentDialog = this;
        GameCore.gamecore.dialog.OnDialogHide.AddListener(OnDialogEnd);


        var dialogcontent = SetContent();
        if (dialogcontent != null)
        {
            dialogManager.Show(dialogcontent);
        }
        ChangeInputControl(GameCore.gamecore.dialog.gameObject);
    }


    public virtual List<DialogData> SetContent()
    {
        var dialogTexts = new List<DialogData>();
        foreach (var item in dialogDatalist)
        {
            var character = "Default";
            if (item.character!=null)
            {
                character = item.character;
            }
            dialogTexts.Add(new DialogData(item.content, character));
        }
        return dialogTexts;
    }


    public virtual void OnDialogEnd()
    {
        GameCore.gamecore.dialog.currentDialog = null;
        dialogFinishEvent.Invoke();
        dialogFinishEvent.RemoveListener(ChangeToPlayer);
        GameCore.gamecore.dialog.OnDialogHide.RemoveListener(OnDialogEnd);
    }

    public void ChangeToPlayer()
    {

        ChangeInputControl(GameCore.gamecore.player.gameObject);
    }

    public void ChangeInputControl(GameObject target)
    {
        GameCore.gamecore.input.ChangeInputReciver(target.GetComponent<InputComponent>());
    }


}
