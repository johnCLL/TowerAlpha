using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BehaviourScript : MonoBehaviour {
    public Text goldText;
    public bool gameOver = false;

    public Text healthLabel;
    public Text gameOverText;
    public GameObject[] healthIndicator;

    private int gold;
    public int Gold
    {
        get
        {
            return gold;
        }
        set
        {
            gold = value;
            goldText.GetComponent<Text>().text = "GOLD: " + gold;
        }
    }

    private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
            healthLabel.text = "Life: " + health;
            // 3
            if (health <= 0 && !gameOver)
            {
                gameOver = true;
                gameOverText.GetComponent<Text>().text = "GAMEOVER";
            }
            // 4 
            for (int i = 0; i < healthIndicator.Length; i++)
            {
                if (i < Health)
                {
                    healthIndicator[i].SetActive(true);
                }
                else
                {
                    healthIndicator[i].SetActive(false);
                }
            }
        }
    }

    // Use this for initialization
    void Start () {
        Gold = 400;
        Health = 5;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
