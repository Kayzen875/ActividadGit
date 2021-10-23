using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingManager : MonoBehaviour
{
    private static PoolingManager _instance;
    public static PoolingManager Instance => _instance;

    public List<GameObject> pooledObjects; //lista de objetos
    public GameObject objectToPool; //prefab de los objetos
    public int amount; //Cantidad de objetos a instanciar

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        //Instancia todos los objetos y los mete en la lista desactivados
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for(int i = 0; i < amount; i++)
        {
            tmp = Instantiate(objectToPool);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
        

    }

    public GameObject GetPooledObject()
    {
        //busca un objeto que este desactivado y lo retorna
        for (int i = 0; i < amount; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
