using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LockCheck : MonoBehaviour
{


    public bool isTriggerOnce;
    bool isTriggered;

    public UnityEvent onUnLockSuccess=new UnityEvent();
    public UnityEvent onUnLockFailure=new UnityEvent();

    // Start is called before the first frame update
    void Start()
    {
        isTriggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int lockId;

    public bool isPlayerInSide;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            isPlayerInSide = true;
            GameCore.gamecore.player.SetCurrentLock(this);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            isPlayerInSide = false;
            if (GameCore.gamecore.player.currentLock==this)
            {
                GameCore.gamecore.player.SetCurrentLock(null);
            }
        }
    }

    public void CheckKey(int keycode)
    {
        if (!isPlayerInSide)
        {
            return;
        }

        if (isTriggerOnce)
        {
            if (isTriggered)
            {
                return;
            }
        }

        if (keycode== lockId)
        {
            isTriggered = true;
            onUnLockSuccess.Invoke();
        }
        else
        {
            onUnLockFailure.Invoke();
        }
    }


    public void ResetLock()
    {
        isTriggered = false;
    }

}
