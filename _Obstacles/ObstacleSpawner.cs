using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {
    public GameObject[] obstacle;


    // Use this for initialization
    void Start() {
        StartCoroutine(TimedSpawner(1));
    }

    // Update is called once per frame
    void Update() {
        
    }

    private IEnumerator TimedSpawner(int Timer)
    {
        while (true) { 
        Instantiate(obstacle[Random.Range(0, obstacle.Length)], transform.position = new Vector3(Random.Range(-3, 3), 0, 6), Quaternion.identity);
        yield return new WaitForSeconds(Timer);
        }
    }
}
