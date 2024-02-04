using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class GManager : MonoBehaviour
{
    FishingMiniGame restart;
    PlayerMove rot;
    public GameObject fishingMinigame;
    public GameObject Explain;
    public GameObject restartbutton;
    public GameObject endtbutton;

    void Start()
    {
        restart = GameObject.Find("fishingMiniGame").GetComponent<FishingMiniGame>();
        rot= GameObject.FindWithTag("Player").GetComponent<PlayerMove>();
    }

    public void fStartButtonDown()   //���۹�ư
    {
        
        Explain.SetActive(false);
        fishingMinigame.SetActive(true);
        
        restart.Restart();

    }

    public void fRestartButtonDown()   //����۹�ư
    {
        restartbutton.SetActive(false);
        endtbutton.SetActive(false);
        restart.Restart();
        Debug.Log("����۹�ư ����");
    }

    public void fEndButtonDown()   //������ ��ư
    {
        fishingMinigame.SetActive(false);
        rot.fishrod.SetActive(false);
        restartbutton.SetActive(false);
        endtbutton.SetActive(false);
        
        Debug.Log("������ ��ư ����");
    }
}
