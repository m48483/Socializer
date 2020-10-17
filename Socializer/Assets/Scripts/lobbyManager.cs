using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lobbyManager : MonoBehaviour
{
    public Button moveButton, talkButton, goodTalk, badTalk, goHome, goAM, moveHomeButton;
    public GameObject TalkUI;
    public Text TalkText;

    public string[] Talkread;

    void Start()
    {
        Button click1_1 = talkButton.GetComponent<Button>();
        Button click1_2 = moveButton.GetComponent<Button>();
        Button click2_1 = goodTalk.GetComponent<Button>();
        Button click2_2 = badTalk.GetComponent<Button>();
        Button click3_1 = goHome.GetComponent<Button>();
        Button click3_2 = goAM.GetComponent<Button>();
        //Button click4 = moveHomeButton.GetComponent<Button>();
        click1_1.onClick.AddListener(envisiable);
        click1_1.onClick.AddListener(talkChoice);
        click1_2.onClick.AddListener(envisiable);
        click1_2.onClick.AddListener(moveChoice);
        click2_1.onClick.AddListener(envisiable);
        click2_1.onClick.AddListener(goodChoice);
        click2_2.onClick.AddListener(envisiable);
        click2_2.onClick.AddListener(badChoice);
        click3_1.onClick.AddListener(envisiable);
        click3_1.onClick.AddListener(goHomeChoice);
        click3_2.onClick.AddListener(envisiable);
        click3_2.onClick.AddListener(goAMChoice);
        //click4.onClick.AddListener(envisiable);
        startMsg();
    }

    void Update()
    {
        
    }
    public void startMsg()
    {
        TalkText.text = Talkread[0];
    }
    public void envisiable()
    {
        moveButton.gameObject.SetActive(false);
        talkButton.gameObject.SetActive(false);
    }
    public void moveChoice()
    {
        TalkText.text = Talkread[1];
        talkButton.gameObject.SetActive(false);
        moveButton.gameObject.SetActive(false);
    }
    public void talkChoice()
    {
        TalkText.text = Talkread[2];
        //talkButton.gameObject.SetActive(false);
        moveButton.gameObject.SetActive(false);
    }
    public void goodChoice()
    {
        TalkText.text = Talkread[3];
        goodTalk.gameObject.SetActive(false);
        badTalk.gameObject.SetActive(false);
    }
    public void badChoice()
    {
        TalkText.text = Talkread[4];
    }
    public void goHomeChoice()
    {
        TalkText.text = Talkread[5];
        goHome.gameObject.SetActive(false);
        goAM.gameObject.SetActive(false);
    }
    public void goAMChoice()
    {

    }
}
