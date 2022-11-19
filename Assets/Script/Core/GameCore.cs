using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCore : MonoBehaviour
{

    public static GameCore gamecore;

    public ItemSystem itemsystem;

    public InputSystem input;

    public PlayerMove player;

    public BackPackUi backPack;

    public DialogController dialog;


    private void Start()
    {
        gamecore = this;
    }





}
