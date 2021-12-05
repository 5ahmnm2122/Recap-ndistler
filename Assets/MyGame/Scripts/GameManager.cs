using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject targetPrefab;

    [SerializeField] GameObject targetParent;

    [SerializeField] int timer;

    [SerializeField] AudioSource shootSound;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAfterTime());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shootSound.Play();
        }
    }

    IEnumerator SpawnAfterTime()
    {
        yield return new WaitForSeconds(timer);
        GameObject spawnedTarget = Instantiate(targetPrefab) as GameObject;
        spawnedTarget.transform.SetParent(targetParent.transform,false);
        spawnedTarget.transform.position = new Vector2(Random.Range(-3f, 3f), Random.Range(-3f, 3f));
        StartCoroutine(SpawnAfterTime());
    }

}
