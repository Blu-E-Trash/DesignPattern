using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public int currentLevel = 1;
    public int currentSkillPoint = 0;
    public int Skill1level = 0;
    public int Skill2level = 0;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
                return null;
            return instance;
        }   
    }
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            //���� ��ȯ�Ǿ ������Ʈ�� �����ǵ���
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            //���ϼ� ����
            Destroy(this.gameObject);
        }
    }

    public void LevelUp()
    {
        currentLevel += 1; //����
        Debug.Log("���� ����:"+ currentLevel);
        currentSkillPoint += 3; //��ų����Ʈ ȹ��
        Debug.Log("���� ������ �ִ� ��ų ����Ʈ:" + currentSkillPoint);
    }
    public void UPSkill1() {
        //��ų1�� �ø��ٸ�
        //����Ʈ 1 �Һ�
        if (currentSkillPoint >= 1)
        {
            currentSkillPoint -= 1;
            Debug.Log("��ų1�� �÷Ƚ��ϴ�.(��ų����Ʈ -1)");
            Debug.Log("���� ��ų2�� ����:" + Skill1level);
            Debug.Log("���� ��ų ����Ʈ:" + currentSkillPoint);
        }
        else
        {
            Debug.Log("��ų����Ʈ�� �����մϴ�.");
            Debug.Log("���� ��ų2�� ����:" + Skill1level);
        }
    }
    public void UpSkill2()
    {
        //��ų2�� �ø��ٸ�
        //����Ʈ 2 �Һ�
        if (currentSkillPoint >= 2)
        {
            currentSkillPoint -= 2;
            Debug.Log("��ų2�� �÷Ƚ��ϴ�.(��ų����Ʈ -2)");
            Debug.Log("���� ��ų2�� ����:" + Skill2level);
            Debug.Log("���� ��ų ����Ʈ:" + currentSkillPoint);
        }
        else
        {
            Debug.Log("��ų����Ʈ�� �����մϴ�.");
            Debug.Log("���� ��ų2�� ����:" + Skill2level);
        }
    }
}
