using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rot : MonoBehaviour //Ŭ���� �̸� �ۼ�
{
    public int rot_a = 0; //�ʱ� ȸ�� ��

    // Start is called before the first frame update
    void Start()
    {
       this.transform.Rotate(0, rot_a, 0); //y�� ȸ��
    }

    // Update is called once per frame
    void Update()
    {
       // this.transform.Rotate(0, rot_a, 0); y���� �� �����Ӹ��� ȸ��
}
}
