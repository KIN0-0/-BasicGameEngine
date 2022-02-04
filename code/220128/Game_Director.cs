using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI�� �� �� �ʼ� ���

public class Game_Director : MonoBehaviour
{
    GameObject player; //�÷��̾� ������Ʈ ������ ���� (�������� : GameObject)
    GameObject obj; //��ǥ�� ������Ʈ�� ������ ���� (�������� : GameObject)
    GameObject dis; //�÷��̾� ������Ʈ�� ��ǥ�� ������Ʈ ������ �Ÿ��� ǥ���� UI������Ʈ�� ������ ����

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("mongmong");
        this.obj = GameObject.Find("choco");
        this.dis = GameObject.Find("Dis");
    }

    // Update is called once per frame
    void Update()
    {
        float lengthDis = this.obj.transform.position.x - this.player.transform.position.x;
        if (lengthDis >= 0)
        {
            this.dis.GetComponent<Text>().text = "Goal " + ": " + lengthDis.ToString("F3") + "m";
        }
        //ToString("D����") ������, ���ڴ� �ڸ��� ToStrimg("D����") ToString("F����") �Ҽ��� ���� �ڸ���


        else //lengthDis�� 0���� �۾����ٸ�
        {
            this.dis.GetComponent<Text>().text = "OMG!\nyou got the chocolate!"; //�޼��� ���
        }
    }
}
