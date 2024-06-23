using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKidModel : MonoBehaviour
{
    public GameObject specialKidvfx;
    public GameObject normalKidvfx;
    public GameObject specialNeedKid;
    public GameObject normalKid;
    public GameObject mainMenu;
    public GameObject choosePatientUI;
    public GameObject[] choosePatientChild;

    public void EnableVfx()
    {
        mainMenu.SetActive(false);
        specialKidvfx.SetActive(true);
        normalKidvfx.SetActive(true);
        StartCoroutine(waitForSpawnVfx());
    }
    public void DisableVfx()
    {
        specialKidvfx.SetActive(false);
        normalKidvfx.SetActive(false);
    }
    public void EnableBothKids()
    {
        specialNeedKid.SetActive(true);
        normalKid.SetActive(true);
    }
    public void DisableSpecialNeed()
    {
        specialNeedKid.SetActive(false);
    }
    public void DisableNormalKid()
    {
        normalKid.SetActive(false);
    }

    IEnumerator waitForSpawnVfx()
        {
            yield return new WaitForSecondsRealtime(1);
            //spawning kids effect
            EnableBothKids();
            DisableVfx();

            //enable UI
            choosePatientUI.SetActive(true);
            for(int i = 0; i < choosePatientChild.Length ; i++)
            {
                choosePatientChild[i].SetActive(true);
            }

        }
}
