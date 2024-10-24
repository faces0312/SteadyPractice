using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterQuestSO", menuName = "QuestSO/Monster")]
public class MonsterQuestDataSO : QuestDataSO
{
    public string questTxt;
    public int monster_Cnt;

    public override void Quest_Inform()
    {
        Debug.Log($"{questTxt}∏¶ {monster_Cnt} º“≈¡");
    }
}
