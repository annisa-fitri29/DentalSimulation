using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuFunction : MonoBehaviour
{
    public GameObject MainTitle;
    public GameObject[] titleChildren;
    public GameObject About;
    public GameObject[] aboutChildren;

    void Start()
    {
        titleChildren = new GameObject[MainTitle.transform.childCount];
        for(int i = 0; i < titleChildren.Length ; i++)
        {
            titleChildren[i] = MainTitle.transform.GetChild(i).gameObject;
        
        }

        aboutChildren = new GameObject[About.transform.childCount];
        for(int i = 0; i < aboutChildren.Length ; i++)
        {
            aboutChildren[i] = About.transform.GetChild(i).gameObject;
        
        }
    }

    public void AboutClicked()
    {
        //disable main menu
        for(int i = 0; i < titleChildren.Length ; i++)
        {
            titleChildren[i].SetActive(false);
        }
        for(int i = 0; i < aboutChildren.Length ; i++)
        {
            aboutChildren[i].SetActive(true);
        
        }
    }

    public void BackClicked()
    {
        //enable main menu
        for(int i = 0; i < aboutChildren.Length ; i++)
        {
            aboutChildren[i].SetActive(false);
        }
        for(int i = 0; i < titleChildren.Length ; i++)
        {
            titleChildren[i].SetActive(true);
        }
    }
}
