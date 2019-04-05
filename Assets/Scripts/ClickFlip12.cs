using UnityEngine;
using System.Collections;

public class ClickFlip12 : MonoBehaviour {

    CardFlipper flipper;
    CardModel cardModel;
    int cardIndex = 0;

    public GameObject sprite12;

    public GameObject light;
    private int count = 0;

    void Awake()
    {   
        //4
        cardModel = sprite12.GetComponent<CardModel>();
        flipper = sprite12.GetComponent<CardFlipper>();

        count = 0;
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
        count += 1;

        if (count == 1)
        {
            light.transform.eulerAngles = new Vector3(transform.rotation.x, 
                                                      transform.rotation.y + 310,
                                                      transform.rotation.z);
        }
        if (count == 2)
        {
            light.transform.eulerAngles = new Vector3(transform.rotation.x,
                                                      transform.rotation.y + 0,
                                                      transform.rotation.z);
        }
        if (count == 3)
        {
            light.transform.eulerAngles = new Vector3(transform.rotation.x,
                                                      transform.rotation.y + 35,
                                                      transform.rotation.z);
            count = 0;
        }
    }
}