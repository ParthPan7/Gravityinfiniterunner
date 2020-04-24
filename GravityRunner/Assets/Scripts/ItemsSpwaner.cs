using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsSpwaner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] items;
    private float minY = -2.5f, maxY = 2.5f;

    void Start()
    {
       
        StartCoroutine(ItemsSpawner(1f));
    }


    IEnumerator ItemsSpawner(float time)
    {
        yield return new WaitForSecondsRealtime(time);

        Vector3 position = new Vector3(transform.position.x,Random.Range(minY,maxY),0);
        Instantiate(items[Random.Range(0, items.Length)], position, Quaternion.identity);
        StartCoroutine(ItemsSpawner(Random.Range(1f, 2f)));
    }
}
