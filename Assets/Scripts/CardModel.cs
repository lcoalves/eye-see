﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CardModel : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    public Sprite[] faces;
    public Sprite cardBack;
    public int cardIndex; // e.g. faces[cardIndex];

    public void ToggleFace(bool showFace)
    {
        if (showFace)
        {
            spriteRenderer.sprite = faces[cardIndex];
        }
        else
        {
            spriteRenderer.sprite = cardBack;
        }
    }

    void Update() { 
        //img.sprite = faces [cardIndex];

    }

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

}