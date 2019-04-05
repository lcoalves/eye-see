using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickFlip5 : MonoBehaviour {

    CardFlipper flipper;
    CardModel cardModel;
    int cardIndex = 0;

    public GameObject sprite5;

    public GameObject ishiharaImg;
    public Image secondImg;
    public Image thirdImg;

    private int count = 0;

    private GameObject camera;
    private bool leaveConvertendo = false;
    private float leaving = 0;

    void Awake()
    {   
        //4
        cardModel = sprite5.GetComponent<CardModel>();
        flipper = sprite5.GetComponent<CardFlipper>();

        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Start() { 


    }

    void Update() {
        if (leaveConvertendo == true)
        {
            leaving += Time.deltaTime;
            if (leaving >= 3)
            {
                camera.transform.position = new Vector3(camera.transform.position.x - 20, camera.transform.position.y - 12, camera.transform.position.z);
                leaveConvertendo = false;
                leaving = 0;
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

        count += 1;
        if (count == 1)
        {
            ishiharaImg.GetComponent<Image>().sprite = secondImg.sprite;
        }
        if (count == 2)
        {
            ishiharaImg.GetComponent<Image>().sprite = thirdImg.sprite;
        }
        if (count == 3)
        {
            camera.transform.position = new Vector3(camera.transform.position.x + 10, camera.transform.position.y, camera.transform.position.z);
            leaveConvertendo = true;
        }
    }
}