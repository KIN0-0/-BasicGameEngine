using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveH : MonoBehaviour
{
    public float speed = 1.0f; //�ӵ��� �� ������ �ۺ������̱� ������ �ν����Ϳ��� ������ �����ϴ�.
 
    void Start()
    {
        
    }

    void Update() //�� �����Ӹ��� ��� ����. �ӵ��� ����. ������ �Ϸ��� FixedUpdate
    {
        this.transform.Translate(speed / 50, 0, 0); //�����̵�(+x�� �������� �̵�)
    }
}
