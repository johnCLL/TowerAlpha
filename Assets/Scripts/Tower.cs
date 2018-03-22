using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {

    private enemy target;
    private enemy2 target1;
    public GameObject arrType;
    private bool canA = true;
    private float ATime;
    private float cooldown=0.08f;
    AudioSource shoot;

    public enemy Target
    {
        get { return target; }
    }

	// Use this for initialization
	void Start () {

        shoot = GetComponent<AudioSource>();

        //GameObject enemyObject = GameObject.FindWithTag("enemy");
        //if (enemyObject != null)
        //{
        //    target = enemyObject.GetComponent<enemy>();
        //}

    }
	
	void Update () {

        Debug.Log(target);
        Attack();
		
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer==LayerMask.NameToLayer("enemy"))
        {
            target = other.GetComponent<enemy>();
            //target1 = other.GetComponent<enemy2>();
        }
    }

    private void Attack()
    {

        if(!canA)
        {
            ATime += Time.deltaTime;
            if (ATime >= cooldown)
            {
                canA = true;
                ATime = 0;
            }
        }
        if (target != null)
        {
            if (canA)
            {
                Shoot();
                shoot.Play();

                canA = false;
            }
        }
    }

    private void Shoot()
    {
        GameObject Arr = Instantiate(arrType, transform.position, Quaternion.identity);
        Arrow arrow = Arr.GetComponent<Arrow>();
        //arrow.transform.position = transform.position;
        arrow.Initialize(this);
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("enemy"))
        {
            target = null;
        }
    }
}
