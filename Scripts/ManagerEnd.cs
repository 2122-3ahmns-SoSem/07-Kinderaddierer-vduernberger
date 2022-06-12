using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerEnd : MonoBehaviour
{
    public TMP_Text displayKidsName;
    public TMP_Text displayScore;
    public TMP_Text message;
    public Image userImage;

    private int scorecount;
    private SoRuntimeData runtimeData;

    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");

        displayKidsName.text = runtimeData.nameKid;
        displayScore.text = runtimeData.scoreResult;
        scorecount = runtimeData.scoreMessage;
        SetUserImage(runtimeData.showPic);
        if (runtimeData.showPic == "" || runtimeData.nameKid != "")
        {
            userImage.enabled = false;
        }

        if (scorecount >= 3 )
        {
            message.text = "Wuhu!! Du rockst das, weiter so :)";
        }

       if (scorecount <=2 && scorecount >= 1)
        {
            message.text = "Schon gut, aber das kannst du noch besser!";
        }

       if (scorecount < 1)
        {
            message.text = "Versuchs nochmal, Übung macht den Meister :)";
        }
    }

    void SetUserImage(string imageName)
    {
        userImage.sprite = Resources.Load<Sprite>(imageName) as Sprite;
    }

    public void SwitchTheScene(int x)
    {
        SceneManager.LoadScene(x);

    }

}
