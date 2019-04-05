using UnityEngine;
using System.Collections;

public class ClickFlip3 : MonoBehaviour {

    CardFlipper flipper;
    CardModel cardModel;
    int cardIndex = 0;

    public GameObject sprite3;

    private GameObject camera;
    private float timeChangeScene;
    bool changeScene = false;

    void Awake()
    {   
        //3
        cardModel = sprite3.GetComponent<CardModel>();
        flipper = sprite3.GetComponent<CardFlipper>();

        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Update()
    {
        if (changeScene)
        {
            timeChangeScene += Time.deltaTime;
            if (timeChangeScene >= 1.7f)
            {
                Application.Quit();
            }
        }

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
        changeScene = true;
    }
}