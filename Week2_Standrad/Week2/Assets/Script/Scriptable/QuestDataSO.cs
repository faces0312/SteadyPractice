using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultQuestSO", menuName = "QuestSO/Default")]
public abstract class QuestDataSO : ScriptableObject
{
    [Header("QuestName")]//퀘스트 이름
    public string questName;
    [Header("QuestRequiredLevel")]//퀘스트의 최소레벨
    public int questRequiredLevel;
    [Header("QuestNPC")]//퀘스트를 주는 NPC의 id (int)
    public int questNPC;
    [Header("QuestPrerequisites")]//선행 퀘스트의 id들의 리스트
    public List<int> questPrerequisites = new List<int>();
    [Header("QuestClear")]//clear 여부
    public bool is_Clear;
    //clear 클리어 메소드

    public abstract void Quest_Inform();
}
