﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NPCBarock : MonoBehaviour
{
    [Header("Text")]
    public TextMeshProUGUI textMeshPro;

    public string[] text;
    public GameObject[] textbox;
    public float radius = 5f;
    public GameObject player;
    void Update()
    {
        player = GameObject.Find("Player");
        if (player !=null)
        {
            CheckPlayer();
        }
        
    }

    public void OnMouseDown()
    {
        CheckPlayer2();
    }
    public void CheckPlayer2()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);


        if (distance <= radius)
        {
            textbox[1].SetActive(true);

        }
        
    }
    public void CheckPlayer()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);

        
        if (distance <= radius)
        {
            textbox[0].SetActive(true);

        }
        else
        {
            textbox[0].SetActive(false);
            textbox[1].SetActive(false);
        }
    }
}
