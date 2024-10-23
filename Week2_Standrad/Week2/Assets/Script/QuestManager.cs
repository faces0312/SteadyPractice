using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // [구현사항 1] 정적 필드 정의
    private static QuestManager instance;

    // [구현사항 2] 정적 프로퍼티 정의
    public static QuestManager Instance
    {
        //값을 읽을때
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<QuestManager>();

                if (instance == null)
                {
                    GameObject obj = new GameObject("QuestManager");
                    instance = obj.AddComponent<QuestManager>();
                }
            }
            return instance;
        }
        //값을 설정할 때
        //set
    }

    //QuestDataSO 정보 설정
    [SerializeField] private List<QuestDataSO> quests;
    /*private int a = 1;
    public int A 
    {
        get
        {
            if (a < 0)
                return a;
            else
                return -1;
        }
    }*/
    // [구현사항 3] 인스턴스 검사 로직
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        for (int i = 0; i < quests.Count; i++)
        {
            QuestDataSO quest = quests[i];
            Debug.Log($"Quest {i + 1} - {quest.questName} (최소 레벨 {quest.questRequiredLevel})");
        }
    }
}
