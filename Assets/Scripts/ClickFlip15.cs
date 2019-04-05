using UnityEngine;
using System.Collections;

public class ClickFlip15 : MonoBehaviour {

    CardFlipper flipper;
    CardModel cardModel;
    int cardIndex = 0;

    public GameObject sprite15;

    void Awake()
    {   
        //4
        cardModel = sprite15.GetComponent<CardModel>();
        flipper = sprite15.GetComponent<CardFlipper>();
    }

    void Start() { 


    }

    public void ClickToFlip()
    {
        if (cardIndex >= cardModel.faces.Length)
        {
            cardIndex = 0;
            //cardModel.ToggleFace(false);
            flipper.FlipCard(cardModel.faces[cardModel.faces.Length - 1], cardModel.cardBack, -1);
        }
        else
        {

            if (cardIndex > 0)
            {
                flipper.FlipCard(cardModel.faces[cardIndex - 1], cardModel.faces[cardIndex], cardIndex);
            }
            else
            {
                flipper.FlipCard(cardModel.cardBack, cardModel.faces[cardIndex], cardIndex);
            }

            //cardModel.cardIndex = cardIndex;
            //cardModel.ToggleFace(true);
            cardIndex++;
        }
    }
}