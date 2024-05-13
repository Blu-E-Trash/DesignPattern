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

            //씬이 전환되어도 오브젝트가 유지되도록
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            //유일성 보장
            Destroy(this.gameObject);
        }
    }

    public void LevelUp()
    {
        currentLevel += 1; //렙업
        Debug.Log("현재 레벨:"+ currentLevel);
        currentSkillPoint += 3; //스킬포인트 획득
        Debug.Log("지금 가지고 있는 스킬 포인트:" + currentSkillPoint);
    }
    public void UPSkill1() {
        //스킬1을 올린다면
        //포인트 1 소비
        if (currentSkillPoint >= 1)
        {
            currentSkillPoint -= 1;
            Debug.Log("스킬1를 올렸습니다.(스킬포인트 -1)");
            Debug.Log("현재 스킬2의 레벨:" + Skill1level);
            Debug.Log("남은 스킬 포인트:" + currentSkillPoint);
        }
        else
        {
            Debug.Log("스킬포인트가 부족합니다.");
            Debug.Log("현재 스킬2의 레벨:" + Skill1level);
        }
    }
    public void UpSkill2()
    {
        //스킬2를 올린다면
        //포인트 2 소비
        if (currentSkillPoint >= 2)
        {
            currentSkillPoint -= 2;
            Debug.Log("스킬2를 올렸습니다.(스킬포인트 -2)");
            Debug.Log("현재 스킬2의 레벨:" + Skill2level);
            Debug.Log("남은 스킬 포인트:" + currentSkillPoint);
        }
        else
        {
            Debug.Log("스킬포인트가 부족합니다.");
            Debug.Log("현재 스킬2의 레벨:" + Skill2level);
        }
    }
}
