using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeEx : MonoBehaviour

	{
    float mExpirationTime = 1f;
    float mTimer;

    void Update()
    {
        mTimer += Time.deltaTime;
        if (mTimer >= mExpirationTime)
        {
            Destroy(gameObject);
        }
    }
}
