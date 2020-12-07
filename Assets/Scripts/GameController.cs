using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //get Question Object
    //get buttons by getting children

    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject Q4;
    public GameObject Q5;
    public GameObject Q6;
    public GameObject Q7;
    public GameObject Q8;
    public GameObject Endscreen;

    GameObject Button1;
    GameObject Button2;
    GameObject Button3;

    string Answer;
    public Text Restext;

    bool buttonClicked = false;

    int index = 0;

    void Start()
    {

    }

    void Update()
    {
        //when button clicked Show ENDSCREEN

        if (Q1.activeSelf && buttonClicked)
        {
            Q1.SetActive(false);
            Endscreen.SetActive(true);

            buttonClicked = false;
        }
        if (Q2.activeSelf && buttonClicked)
        {
            Q2.SetActive(false);
            Endscreen.SetActive(true);

            buttonClicked = false;
        }
        if (Q3.activeSelf && buttonClicked)
        {
            Q3.SetActive(false);
            Endscreen.SetActive(true);

            buttonClicked = false;
        }

    }

    void getButtons(GameObject Question)
    {
        var Button1 = Question.transform.GetChild(0).gameObject;
        var Button2 = Question.transform.GetChild(1).gameObject;
        var Button3 = Question.transform.GetChild(2).gameObject;
    }

    public void GetClickedButton(string Answer)
    {
        if(Answer == "Car")
        {
            Restext.text = "You escaped";
        }
        if (Answer == "Gun")
        {
            Restext.text = "Lion ate you";
        }
        if (Answer == "Meat")
        {
            Restext.text = "You tried to feed the lion but he is not hungry";
        }
        if (Answer == "Get inside of water")
        {
            Restext.text = "You don't know how to swim...";
        }
        if (Answer == "Go fishing")
        {
            Restext.text = "You catch a fish but You need to cook it first";
        }
        if (Answer == "Drink water")
        {
            Restext.text = "Water was poisinous. You died. Unfortunetly";
        }

        if (Answer == "Yell at it")
        {
            Restext.text = "Someone is on the boat. He invited you on the board";
        }
        if (Answer == "Just look at it")
        {
            Restext.text = "Nice Boat";
        }
        if (Answer == "Get inside")
        {
            Restext.text = "Someone is inside and not very looking welcoming";
        }

        buttonClicked = true;

        //check answers 
        // SO MANY SPAGETTI CODE
    }


    public void nextQuestion()
    {
        if (index == 0)
        {
            index++;
            Q2.SetActive(true);
            Endscreen.SetActive(false);
            return;
        }
        if (index == 1)
        {
            index++;
            Q3.SetActive(true);
            Endscreen.SetActive(false);
            return;
        }
        if (index == 2)
        {
            index++;
            Q4.SetActive(true);
            Endscreen.SetActive(false);
            return;
        }
        if (index == 3)
        {
            index++;
            Q5.SetActive(true);
            Endscreen.SetActive(false);
            return;
        }
        if (index == 4)
        {
            index++;
            Q6.SetActive(true);
            Endscreen.SetActive(false);
            return;
        }
        if (index == 5)
        {
            index++;
            Q7.SetActive(true);
            Endscreen.SetActive(false);
            return;
        }

    }

}
