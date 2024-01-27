using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotSpawner : MonoBehaviour
{
    public GameObject robot;
    public float spawnRate = 2;
    private float timer = 0;
    public float xOffset = 5;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate){
            timer = timer + Time.deltaTime;
        }
        else {
            spawnPipe();
            timer=0;
        }
    }

        void spawnPipe(){
            float minPoint = transform.position.x - xOffset;
            float maxPoint = transform.position.x + xOffset;
            Instantiate(robot, new Vector3(Random.Range(minPoint, maxPoint), transform.position.y, 0), transform.rotation);
        }
}
