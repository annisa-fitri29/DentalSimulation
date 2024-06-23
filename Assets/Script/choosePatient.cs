using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choosePatient : MonoBehaviour
{
    public GameObject info;
    public GameObject[] chooseChildBtn;
    public GameObject[] infoChild;

    public void pressedNabil()
    {
        //disable Syifa
        chooseChildBtn[1].SetActive(false);
        //showInfo
        info.SetActive(true);
        infoChild[0].SetActive(true);
        infoChild[2].SetActive(true);
        infoChild[4].SetActive(true); //backbtn
    }

    public void pressedSyifa()
    {
        //disable Nabil
        chooseChildBtn[0].SetActive(false);
        //showInfo
        info.SetActive(true);
        infoChild[1].SetActive(true);
        infoChild[3].SetActive(true);
        infoChild[4].SetActive(true); //backbtn
    }

    public void toNabilCase()
    {

    }

    public void toSyifaCase()
    {

    }

    public void backPressed()
    {
        chooseChildBtn[0].SetActive(true);
        chooseChildBtn[1].SetActive(true);

        info.SetActive(false);
    }
}
