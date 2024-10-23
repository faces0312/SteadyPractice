using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [System.Serializable]
    public class Object_Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    public List<Object_Pool> pools;
    public Dictionary<string, List<GameObject>> objectPoolsDictionary;

    void Start()
    {
        objectPoolsDictionary = new Dictionary<string, List<GameObject>>();
        foreach (Object_Pool pool in pools)
        {
            List<GameObject> obj_Pool = new List<GameObject>();
            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                obj_Pool.Add(obj);
            }
            objectPoolsDictionary.Add(pool.tag, obj_Pool);
        }

        
    }

    public GameObject Get(string key)
    {
        //키 값이 없으면
        if (!objectPoolsDictionary.ContainsKey(key))
            return null;

        List<GameObject> objectPool = objectPoolsDictionary[key];
        foreach (GameObject obj in objectPool)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }

        // 모든 오브젝트가 사용 중일 경우 새로 생성

        GameObject newObj = Instantiate(pools.Find(a => a.tag == key).prefab);
        objectPool.Add(newObj);
        return newObj;
    }

    public void Release(GameObject obj, string key)
    {
        if (!objectPoolsDictionary.ContainsKey(key))
            return;

        obj.SetActive(false);
    }
}
