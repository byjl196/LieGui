using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayDialog : MonoBehaviour
{

    public bool isTriggerOnce;
    bool isTriggered;

    public UnityEvent onUnLocked = new UnityEvent();

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
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            isPlayerInSide = false;
            if (GameCore.gamecore.player.currentLock == this)
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

        if (keycode == lockId)
        {
            isTriggered = true;
            onUnLocked.Invoke();
        }
    }


    public void ResetLock()
    {
        isTriggered = false;
    }
}
