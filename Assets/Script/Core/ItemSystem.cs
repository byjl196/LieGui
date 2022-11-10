using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public List<ItemStruc> items = new List<ItemStruc>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
