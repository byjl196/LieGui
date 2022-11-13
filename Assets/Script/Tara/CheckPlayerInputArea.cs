using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// 检测玩家的输入并做出监测
/// </summary>
public class CheckPlayerInputArea : MonoBehaviour
{

    public Vector2 dir;

    public bool isTriggerOnce=false;

    [SerializeField]
    bool isTrigged = false;

    //public UnityEvent FuncAEvent = new UnityEvent();
    public UnityEvent FuncBEvent = new UnityEvent();
    //public UnityEvent FuncCEvent = new UnityEvent();


    public bool isCanTrigger
    {
        get { return GameCore.gamecore.input.currentTarget == GameCore.gamecore.player.input; }


    }

    private void Start()
    {
        isTrigged = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var player = collision.GetComponent<InputComponent>();
            //player.FuncAEvent.AddListener(InvokeA);
            player.FuncBEvent.AddListener(InvokeB);
            //player.FuncCEvent.AddListener(InvokeC);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            dir = collision.GetComponent<InputComponent>().dirInput;

        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var player=  collision.GetComponent<InputComponent>();
            //player.FuncAEvent.RemoveListener(InvokeA);
            player.FuncBEvent.RemoveListener(InvokeB);
            //player.FuncCEvent.RemoveListener(InvokeC);
            dir = Vector2.zero;
        }



    }

    //public void InvokeA()
    //{
    //    if (!isCanTrigger)
    //    {
    //        return;
    //    }

    //    if (isTriggerOnce)
    //    {
    //        if (isTrigged)
    //        {
    //            return;
    //        }
    //    }
    //    isTrigged = true;
    //    FuncAEvent.Invoke();
    //}

    public void InvokeB()
    {
        if (!isCanTrigger)
        {
            return;
        }
        if (isTriggerOnce)
        {
            if (isTrigged)
            {
                return;
            }
        }
        isTrigged = true;
        FuncBEvent.Invoke();
    }
    //public void InvokeC()
    //{
    //    if (!isCanTrigger)
    //    {
    //        return;
    //    }
    //    if (isTriggerOnce)
    //    {
    //        if (isTrigged)
    //        {
    //            return;
    //        }
    //    }
    //    isTrigged = true;
    //    FuncCEvent.Invoke();
    //}

}
