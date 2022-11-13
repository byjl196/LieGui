using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackPackUi : MonoBehaviour
{

    public GameObject ItemImage;


    InputComponent input;

    public float itemuiInterval;
    public GameObject selecBoxUi;

    Vector3 selecboxStartpos;

    List<GameObject> existItemList=new List<GameObject>();

    private void Start()
    {
        input = GetComponent<InputComponent>();
        selecboxStartpos = selecBoxUi.transform.position;
    }

    private void Update()
    {
        MoveSelecBox();
    }
    bool isCanChangeSelec;

    public int page;


    [SerializeField]
    private int m_selecIndex;


    public int SelecIndex
    {
        get { return m_selecIndex; }
        private set
        {
            if (value > MaxIndex)
            {
                m_selecIndex = 0;
                page++;
                return;
            }

            if (value < 0)
            {
                m_selecIndex = MaxIndex;
                page--;
                return;
            }
            m_selecIndex = value;
        }

    }
    public int MaxIndex;
    void MoveSelecBox()
    {
        var inputvalue = input.dirInput.x;
        if (inputvalue != 0)
        {
            if (!isCanChangeSelec)
            {
                return;
            }
            isCanChangeSelec = false;
            SelecIndex += (int)Mathf.Sign(inputvalue);
            selecBoxUi.transform.position = selecboxStartpos + new Vector3(SelecIndex * itemuiInterval, 0, 0);
        }
        else
        {
            isCanChangeSelec = true;
        }

    }



    public void UpdateItemDisplay()
    {
        var itemsys = GameCore.gamecore.itemsystem.playerItems;
        int exiItemlistLength = existItemList.Count;

        if (exiItemlistLength < itemsys.Count)
        {
            for (int i = 0; i < itemsys.Count - exiItemlistLength; i++)
            {
                var newItemObj = GameObject.Instantiate(ItemImage);
                newItemObj.transform.SetParent(transform);
                existItemList.Add(newItemObj);
            }
        }

        if (exiItemlistLength > itemsys.Count)
        {
            for (int i = exiItemlistLength; i > itemsys.Count; i--)
            {
                existItemList[i].SetActive(false);
            }
        }

        foreach (var item in itemsys)
        {
            var index = itemsys.IndexOf(item);
            var uiobj = existItemList[index];
            uiobj.SetActive(true);
            uiobj.GetComponent<Image>().sprite = item.image;
            uiobj.transform.position = ItemImage.transform.position +new Vector3(index * itemuiInterval, 0, 0);
            //uiobj.transform.position= selecboxStartpos + new Vector3(SelecIndex * itemuiInterval, 0, 0);
        }

    }

    //public void UpdateItemDisplay()
    //{
    //    var itemsys = GameCore.gamecore.itemsystem;
    //    var list = itemsys.playerItems;



    //    if (list != Itemlist)
    //    {
    //        Itemlist = list;
    //    }
    //    else
    //    {
    //        return;
    //    }


    //    if (itemsys.playerItems.Count != 0)
    //    {
    //        foreach (var item in itemsys.playerItems)
    //        {
    //            var existItem = existItemList[itemsys.playerItems.IndexOf(item)];

    //            if (existItem != null)
    //            {
    //                existItem.GetComponent<Image>().sprite = item.image;
    //            }
    //            else
    //            {
    //                var newimage = GameObject.Instantiate(ItemImage);
    //                newimage.transform.SetParent(this.transform);
    //                newimage.GetComponent<Image>().sprite = item.image;
    //                newimage.transform.position = selecboxStartpos + new Vector3(itemsys.playerItems.IndexOf(item) * itemuiInterval, 0, 0);
    //            }
    //        }
    //    }

    //}


    public void Open()
    {
        gameObject.SetActive(true);
        UpdateItemDisplay();
    }
    public void Close()
    {
        gameObject.SetActive(false);
    }


    public void UpdateBackpackInfo()
    {

    }





}
