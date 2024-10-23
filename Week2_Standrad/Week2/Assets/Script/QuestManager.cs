using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // [�������� 1] ���� �ʵ� ����
    private static QuestManager instance;

    // [�������� 2] ���� ������Ƽ ����
    public static QuestManager Instance
    {
        //���� ������
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
        //���� ������ ��
        //set
    }

    //QuestDataSO ���� ����
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
    // [�������� 3] �ν��Ͻ� �˻� ����
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
            Debug.Log($"Quest {i + 1} - {quest.questName} (�ּ� ���� {quest.questRequiredLevel})");
        }
    }
}
