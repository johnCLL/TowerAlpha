using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spawn : MonoBehaviour {
    public GameObject[] waypoints;
    public GameObject testEnemyPrefab;
    public GameObject testEnemyPrefab2;
    private float nextActionTime = 0.0f;
    public float period = 1.5f;
    int max = 60;
    private int count = 0;
    private enemy ene;


    public int Count
    {
        get
        {
            return count;
        }
    }

    // Use this for initialization
    void Start () {
        Instantiate(testEnemyPrefab);
        (testEnemyPrefab).GetComponent<path>().mPointO = waypoints[1].transform;
        (testEnemyPrefab).GetComponent<path>().mPoint1 = waypoints[2].transform;
        (testEnemyPrefab).GetComponent<path>().mPoint2 = waypoints[3].transform;
        (testEnemyPrefab).GetComponent<path>().mPoint3 = waypoints[4].transform;
        (testEnemyPrefab).GetComponent<path>().mPoint4 = waypoints[5].transform;
        (testEnemyPrefab).GetComponent<path>().mPoint5 = waypoints[6].transform;
        (testEnemyPrefab).GetComponent<path>().TwoWay = waypoints[7].transform;
        (testEnemyPrefab).GetComponent<path>().SecP1 = waypoints[8].transform;
        (testEnemyPrefab).GetComponent<path>().SecP2 = waypoints[9].transform;


        (testEnemyPrefab2).GetComponent<path>().mPointO = waypoints[0].transform;
        (testEnemyPrefab2).GetComponent<path>().mPoint1 = waypoints[2].transform;
        (testEnemyPrefab2).GetComponent<path>().mPoint2 = waypoints[3].transform;
        (testEnemyPrefab2).GetComponent<path>().mPoint3 = waypoints[4].transform;
        (testEnemyPrefab2).GetComponent<path>().mPoint4 = waypoints[5].transform;
        (testEnemyPrefab2).GetComponent<path>().mPoint5 = waypoints[6].transform;
        (testEnemyPrefab2).GetComponent<path>().TwoWay = waypoints[7].transform;
        (testEnemyPrefab2).GetComponent<path>().SecP1 = waypoints[8].transform;
        (testEnemyPrefab2).GetComponent<path>().SecP2 = waypoints[9].transform;

        GameObject ee = GameObject.Find("enemy");
        ene = ee.GetComponent<enemy>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextActionTime&&count<=max)
        {
            nextActionTime += period;
            Instantiate(testEnemyPrefab);
            //if (count >= 20)
            //{
            //    Instantiate(testEnemyPrefab2);
            //}
            count++;
        }
        if(count==10)
        {
            period = 1.3f;
        }
        if (count == 20)
        {
            period = 1;
        }
        if (count == 30)
        {
            period = 0.5f;
        }

    }
}
