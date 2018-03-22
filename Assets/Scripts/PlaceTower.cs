using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour {
    public GameObject towerPrefab;
    private GameObject tower;
    private BehaviourScript gameManager;
    AudioSource build;

    private bool CanPlaceTower()
    {
        int cost = towerPrefab.GetComponent<TowerData>().cost;
        return tower == null && gameManager.Gold >= cost;
    }

    void OnMouseUp()
    {
        if (CanPlaceTower())
        {
            tower = (GameObject)
              Instantiate(towerPrefab, transform.position, Quaternion.identity);

            build.Play();

            gameManager.Gold -= tower.GetComponent<TowerData>().cost;
            
        }
    }

    // Use this for initialization
    void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<BehaviourScript>();
        build = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
