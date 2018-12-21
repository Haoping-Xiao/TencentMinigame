﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public static int checkPoint = 0;
    public static int LevelNum = 0;
    public static int InkNum = 0;
    public static int TotalInk = 30;



    public static bool isWindGet = false, isFireGet = false;
    private bool isWindGetSet = false, isFireGetSet = false;

    public static bool isInPaintMode = false;
    public static float InkDistance = 20.0f;
    public static float InkTotalDistance = 20.0f;
    //黑色画笔控制
    public static int BlackLine_numzero = 0;
    public static int BlackLine_num = 0;
    //红色画笔控制
    public static int RedLine_numzero = 0;
    public static int RedLine_num = 0;
    public static int Fire_num = 0;
    public static int Fire_numzero = 0;
    //蓝色画笔控制
    public static int BlueLine_numzero = 0;
    public static int BlueLine_num = 0;

    private UIController UICon;
    private GameObject Player;
    float duration = 2.0f;
    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player").gameObject;
        UICon = GameObject.Find("Canvas").gameObject.GetComponent<UIController>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Player.transform.position.x > 161f &&!isWindGetSet) {
            //获得风之力,调色板加颜色，放字幕
            UICon.showUIButton(1);
            isWindGet = true;
            isWindGetSet = true;
        }
        if (Player.transform.position.x > 345.7f && !isFireGetSet) {
            //获得火之力,调色板加颜色，放字幕
            UICon.showUIButton(2);
            isFireGet = true;
            isFireGetSet = true;
        }
            
	}
}
