using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spawner : MonoBehaviour
{
    int x = 5;
    public GameObject top;

    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    public IEnumerator SpawnObject()
    {
         while(x == 5)
         {
            Instantiate(top,transform.position, Quaternion.identity);
            yield return new WaitForSeconds(5f);
         }
    }
}
