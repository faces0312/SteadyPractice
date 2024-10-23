using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultQuestSO", menuName = "QuestSO/Default")]
public class QuestDataSO : ScriptableObject
{
    [Header("QuestName")]//����Ʈ �̸�
    public string questName;
    [Header("QuestRequiredLevel")]//����Ʈ�� �ּҷ���
    public int questRequiredLevel;
    [Header("QuestNPC")]//����Ʈ�� �ִ� NPC�� id (int)
    public int questNPC;
    [Header("QuestPrerequisites")]//���� ����Ʈ�� id���� ����Ʈ
    public List<int> questPrerequisites = new List<int>();
}
