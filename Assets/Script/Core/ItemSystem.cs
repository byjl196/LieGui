using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public struct ItemStruc
{
    public string Name;
    public int Id;
    public string Description;
    public Sprite image;
}

public class ItemSystem : MonoBehaviour
{


    public List<ItemStruc> RegisterItems = new List<ItemStruc>();
    public List<ItemStruc> playerItems = new List<ItemStruc>();


    public void PlayerGetItem(int id)
    {
        var targteItem = RegisterItems.Find(x => x.Id == id);
        playerItems.Add(targteItem);
    }
    public void PlayerRemoveitem(int id)
    {
        var targteItem = playerItems.Find(x => x.Id == id);
        playerItems.Remove(targteItem);
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
