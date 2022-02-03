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
        this.dis.GetComponent<Text>().text = "��ǥ����" + ":" + lengthDis.ToString() + "m";
    }
}
