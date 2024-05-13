using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public void LevelUp()
    {

        GameManager.Instance.LevelUp();
    }
    public void UPSkill1P()
    {
        GameManager.Instance.UPSkill1();
    }
    public void UPSkill2P()
    {
        GameManager.Instance.UpSkill2();
    }
}
