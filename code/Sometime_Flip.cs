using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_Flip : MonoBehaviour
{
    public float maxCount = 50.0f; //�ʱ� �󵵰�
    int count = 0; //ī��Ʈ��
    bool flipFlag = false; //��, ���� �Ǵ��� ���� �ο� �������� ���

    // Start is called before the first frame update
    void Start()
    {
        count = 0; //ī���͸� ����
    }

    // Update is called once per frame
    void Update()
    {
        count = count + 1;
        if (count >= maxCount)
        {
            this.transform.Rotate(0, 0, 180); //rotate(x,y,z)
            count = 0;
            flipFlag = !flipFlag;
            this.GetComponent<SpriteRenderer>().flipY = flipFlag; //��������Ʈ ���� ��� ������Ʈ�� �ִ� �ø�Y��� �Ӽ��� flipFlag���� �����Ѵ�.
        }
    }
}
