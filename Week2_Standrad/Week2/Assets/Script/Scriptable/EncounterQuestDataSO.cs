using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EncounterQuestSO", menuName = "QuestSO/Encounter")]
public class EncounterQuestDataSO : QuestDataSO
{
    public string questTxt;
    public bool enCounter;

    public override void Quest_Inform()
    {
        Debug.Log($"{questTxt}와 대화하기");
    }
}
