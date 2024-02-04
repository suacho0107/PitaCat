using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class fishdrop : MonoBehaviour
{
    Rigidbody rb;
    FishingMiniGame sc2;  //FishingMiniGame��ũ��Ʈ �������� ���� ���
    public  Image[] fise2;   //������� ���� ������ ���� �迭->�̹��� �ֱ�(fishboard�� 5�� ������ ex)1-1)
    public GameObject[] fishes;  //����⸦ �������� ȭ�鿡 ����ϱ����� �迭->����� ������ 5�� �ֱ�
    public Transform trans;
    int [] fishscore  = new int[] { 0,0,0,0,0 }; //Ŭ��������
    public bool fclear=false;

    // ���� ����
    public GameObject clearPanel2;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
       sc2= GameObject.Find("fishingMiniGame").GetComponent<FishingMiniGame>();  //FishingMiniGame��ũ��Ʈ �������� ���� ���
    }

    //������ ����-����ƽ���� �����ؼ� �ٸ� �Լ������� ���� ���� ������ ��.
    public static int randdrop() {
        int rand = Random.Range(0, 5);
        return rand;
    }
    static int ad;

    //����� ���
    public void  fishDrop()
    {
        ad=randdrop();
        float rand2 = Random.Range(1, 1.5f);
        Vector3 v = new Vector3(0f, rand2, rand2);
        Instantiate(fishes[ad], trans.position + v, Quaternion.identity);
        
    }
    //�����UI ���� ����
    public void changefishcolor(int a)
    {

        fise2[a].color = new Color(255, 255, 255);

    }
    //����⸦ ������
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "fish")
        {
            //����� ���� �ٲٱ�
            changefishcolor(ad);
            Destroy(col.gameObject);
            fishscore[ad] = 1;
            Debug.Log(ad+"����� �߰�");

            isclearfishgame();
            if(isclearfishgame()==true)
            {
                // �̰��̾� !_SetActive(���� �г� on, ��ư Ŭ�� �� Ŭ����� �̵�)
                // Debug.Log("clear");
                clearPanel2.SetActive(true);
            }
        }
        
    }//���� �̴ϰ��� Ŭ���� ���� Ȯ�ι�
    bool  isclearfishgame()
    {
        int cou=0;
        for (int i = 0; i < fishscore.Length; i++) 
        {
            if (fishscore[i] >= 1)
                cou++;
        }
        if (cou == 5)
            fclear = true;
        else
            fclear = false;

        return fclear;
    }
}
