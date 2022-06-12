using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

//Hilfsstruktur Aufz?hlung
public enum MyScenes
{
    WelcomeScene,
    Scene1,
    Scene2,
    Scene3,
    EndScene
}

public class Manager : MonoBehaviour
{

    public TMP_InputField ipfKidsName;
    public TMP_Text warning;
    public GameObject characterPig;
    public GameObject characterChicken;
    public GameObject characterCow;
    public GameObject characterSheep;
    private SoRuntimeData runtimeData;


    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");

    }

    public void UsePig()
    {

        characterChicken.SetActive(false);
        characterCow.SetActive(false);
        characterSheep.SetActive(false);
        if (characterPig.activeSelf)
        {
            characterPig.SetActive(false);
        }
        else
        {
            characterPig.SetActive(true);
        }

    }

    public void UseChicken()
    {

        characterPig.SetActive(false);
        characterCow.SetActive(false);
        characterSheep.SetActive(false);
        if (characterChicken.activeSelf)
        {
            characterChicken.SetActive(false);
        }
        else
        {
            characterChicken.SetActive(true);
        }
    }

    public void UseCow()
    {

        characterPig.SetActive(false);
        characterChicken.SetActive(false);
        characterSheep.SetActive(false);
        if (characterCow.activeSelf)
        {
            characterCow.SetActive(false);
        }
        else
        {
            characterCow.SetActive(true);
        }
    }
    public void UseSheep()
    {

        characterPig.SetActive(false);
        characterChicken.SetActive(false);
        characterCow.SetActive(false);
        if (characterSheep.activeSelf)
        {
            characterSheep.SetActive(false);
        }
        else
        {
            characterSheep.SetActive(true);
        }
    }

    public void SwitchTheScene(int x)
    {

        runtimeData.nameKid = ipfKidsName.text;

        if(characterPig.activeSelf)
        {
            runtimeData.showPic = "pig";
        }
        else if (characterSheep.activeSelf)
        {
            runtimeData.showPic = "sheep";
        }
        else if (characterChicken.activeSelf)
        {
            runtimeData.showPic = "chicken";
        }
        else if (characterCow.activeSelf)
        {
            runtimeData.showPic = "cow";
        }
        else
        {
            runtimeData.showPic = "";
        }
        if (runtimeData.showPic == "" && runtimeData.nameKid == "")
        {
            warning.text = "Bitte gib deinen Namen ein ODER w?hle einen Charakter aus :(";
            warning.fontSize = 30;
            warning.color = Color.red;
           
        }
        else
        {
           SceneManager.LoadScene(x);
        }

    
    }

}
