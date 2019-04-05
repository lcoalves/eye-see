using UnityEngine;
using System.Collections;

public class ClickFlip4 : MonoBehaviour {

    CardFlipper flipper;
    CardModel cardModel;
    int cardIndex = 0;

    public GameObject sprite4;

    private GameObject camera;
    private float timeChangeScene;
    bool changeScene = false;

    void Awake()
    {   
        //4
        cardModel = sprite4.GetComponent<CardModel>();
        flipper = sprite4.GetComponent<CardFlipper>();

        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Update()
    {
        if (changeScene)
        {
            timeChangeScene += Time.deltaTime;
            if (timeChangeScene >= 1.7f)
            {
                camera.transform.position = new Vector3(camera.transform.position.x + 10, camera.transform.position.y, camera.transform.position.z);
                changeScene = false;
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