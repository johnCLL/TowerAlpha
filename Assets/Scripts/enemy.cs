using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    public float hp;
    private BehaviourScript gameManager;
    private Spawn span;
    AudioSource dis;

    void Start()
    {
        GameObject gm = GameObject.Find("GameManager");
        gameManager = gm.GetComponent<BehaviourScript>();
        GameObject sp = GameObject.Find("Path");
        span = sp.GetComponent<Spawn>();
        hp = 100;
        dis = GetComponent<AudioSource>();


    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("array"))
        {
            hp = hp - 50;
            Destroy(col.gameObject);

        }
    }

    void Update()
    {
        if (hp <= 0)
        {
            dis.Play();
            Destroy(gameObject);
            
            gameManager.Gold += 50;
        }

    }

    
}
