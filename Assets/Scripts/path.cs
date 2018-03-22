using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour {
    float EWalkSpeed = 2f;
    
    public Transform mPointO;
    public Transform mPoint1;
    public Transform mPoint2;
    public Transform mPoint3;
    public Transform mPoint4;
    public Transform mPoint5;
    public Transform TwoWay;
    public Transform SecP1;
    public Transform SecP2;
    bool turn1 = false;
    bool turn2 = false;
    bool turn3 = false;
    bool turn4 = false;
    bool turn5 = false;
    bool SecWay = false;
    bool SecT1 = false;
    bool DeTT = false;
    bool SecT2 = false;
    bool final = false;
    float decision;


    // Use this for initialization
    void Start()
    {

        /*if (transform.position != new Vector3(-5.2f, 2.97f, 0f))
        {
            gameObject.transform.position += new Vector3(0f, -EWalkSpeed, 0f);
        }*/
    }
	
	// Update is called once per frame
	void Update () {

        Vector2 direction = mPointO.transform.position - transform.position;
        Vector2 direction1 = mPoint1.transform.position - transform.position;
        Vector2 direction2 = mPoint2.transform.position - transform.position;
        Vector2 direction3 = mPoint3.transform.position - transform.position;
        Vector2 direction4 = mPoint4.transform.position - transform.position;
        Vector2 direction5 = mPoint5.transform.position - transform.position;
        Vector2 Design = TwoWay.position - transform.position;
        Vector2 SD1 = SecP1.position - transform.position;
        Vector2 SD2 = SecP2.position - transform.position;

        if (turn1 == false)
        {
            transform.Translate(direction.normalized * EWalkSpeed * Time.deltaTime);
        }
        if (turn1 == true&&turn2==false)
        {
            transform.Translate(direction1.normalized * EWalkSpeed * Time.deltaTime);

        }

        

        

        if (turn1 == true && turn2 == true && DeTT == false)
        {
            transform.Translate(Design.normalized * EWalkSpeed * Time.deltaTime);
        }

        if (Design.magnitude <= 0.1f)
        {
            decision = Random.Range(0.0f, 1.0f);
            if (decision <= 0.5f)
            { SecWay = true;
                DeTT = true;
            }
            else
            {
                SecWay = false;
                DeTT = true;
            }
        }

        if (turn1 == true && turn2 == true && DeTT==true && SecWay == true && SecT1 == false)
        {
            transform.Translate(SD1.normalized * EWalkSpeed * Time.deltaTime);
        }

        if (turn1 == true && turn2 == true && DeTT == true && SecWay == true && SecT1 == true && SecT2 ==false)
        {
            transform.Translate(SD2.normalized * EWalkSpeed * Time.deltaTime);
        }
        if (turn1 == true && turn2 == true && DeTT == true && SecWay == true && SecT1 == true && SecT2 == true)
        {
            transform.Translate(direction5.normalized * EWalkSpeed * Time.deltaTime);
        }

        if (turn1 == true && turn2 == true && DeTT == true && SecWay == false && turn3 == false)
        {
            transform.Translate(direction2.normalized * EWalkSpeed * Time.deltaTime);
        }

        if (turn1 == true && turn2 == true && DeTT == true && SecWay == false && turn3 == true && turn4==false)
        {
            transform.Translate(direction3.normalized * EWalkSpeed * Time.deltaTime);
        }
        if (turn1 == true && turn2 == true && DeTT == true && SecWay == false && turn3== true &&turn4== true &&turn5==false)
        {
            transform.Translate(direction4.normalized * EWalkSpeed * Time.deltaTime);
        }
        if (turn1 == true && turn2 == true && DeTT == true && SecWay == false && turn3== true &&turn4== true &&turn5== true)
        {
            transform.Translate(direction5.normalized * EWalkSpeed * Time.deltaTime);
        }
        if (direction.magnitude<=0.1f)
        {
            turn1 = true;
        }
        if (direction1.magnitude <= 0.1f)
        {
            turn2 = true;
        }
        
        if (SD1.magnitude <=0.1f)
        {
            SecT1 = true;
        }

        if (SD2.magnitude <= 0.1f)
        {
            SecT2 = true;
        }
        if (direction2.magnitude <= 0.1f)
        {
            turn3 = true;
        }
        if (direction3.magnitude <= 0.1f)
        {
            turn4 = true;
        }
        if (direction4.magnitude <= 0.1f)
        {
            turn5 = true;
        }

        if (direction5.magnitude <= 0.1f)
        {
            final = true;
        }

        if(final == true)
        {
            Destroy(gameObject);
            BehaviourScript gameManager =
            GameObject.Find("GameManager").GetComponent<BehaviourScript>();
            gameManager.Health -= 1;
        }

    }


}
