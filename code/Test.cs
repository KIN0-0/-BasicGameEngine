using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour //Ŭ���� �̸��� ��Ʈ��Ʈ ���� �̸��� �����ؾ� ��
{
    // Start is called before the first frame update
    void Start() //�Ź� �������� ���ŵǾ ��ŸƮ �޼ҵ� �ȿ� �ִ� ������ �ѹ��� �����,
    {
        this.transform.Translate(10.0f, 0, 0); //�� ��ũ��Ʈ�� ���� �ִ� ���� ������Ʈ�� �̵���Ų��. => Translate(x,y,z);
    }

    // Update is called once per frame
    void Update() //�� �����Ӹ��� ��������� ����, �߰��Ǵ� �޼ҵ�� ��������� �����.
    {
        
    }
}
