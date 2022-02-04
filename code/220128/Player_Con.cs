using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Con : MonoBehaviour
{
    float speed = 0; //���� ����
    private AudioSource audio;
    public AudioClip Woof;
    Vector2 startPos; //���콺�� ������ ���� ��ġ���� �� ����
    Vector2 endPos; //���콺�� ������ ������ ���� ��ġ���� �� ����
    //2���� ��ǥ�� ����(x, y). ����3�� (x, y, z).

    void Start()
    {
        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.Woof;
        this.audio.loop = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //���콺 ���� ��ư Ŭ�� �� 
        {
            this.startPos = Input.mousePosition; //���콺 ��ư���� ������ ���� ��ǥ��
            GetComponent<AudioSource>().Play();
        }
  
        else if (Input.GetMouseButtonUp(0)) //���콺 �����ٰ� �����ٸ�
        {
            this.endPos = Input.mousePosition; //���� ���� ��ǥ��
            float length = (this.endPos.x - this.startPos.x); //������ ��ǥ�� - ó�� ��ǥ��
            this.speed = length / 5000.0f;
            GetComponent<AudioSource>().Play();
        }
        
        transform.Translate(this.speed, 0, 0); //+x�������� �̵�
        this.speed *= 0.98f; // ����
    }
}
