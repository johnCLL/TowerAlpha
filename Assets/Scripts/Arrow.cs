using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    float mSpeed = 10;
    Rigidbody2D mRigidBody2D;
    public float damage = 50;
    //public GameObject target;
    public Vector3 startPosition;
    public Vector3 targetPosition;
    private enemy target;
    private Tower parent;


    private float distance;
    private float startTime;

    private BehaviourScript gameManager;

    void Start()
    {
 
    }

    void Update()
    {
        Move();

    }

    public void Initialize(Tower parent)
    {
        this.target = parent.Target;
        this.parent = parent;
    }

    private void Move()
    {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * mSpeed);
        }
    }

    void Awake()
    {
        mRigidBody2D = GetComponent<Rigidbody2D>();

        //mRigidBody2D.velocity = Vector2.right * mSpeed;
    }

    public void SetDirection(Vector2 direction)
    {
        mRigidBody2D.velocity = direction * mSpeed;
    }
}
