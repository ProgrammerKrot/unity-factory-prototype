using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cargravity : MonoBehaviour
{
    public GameObject nrs;
    float score;
    private Vector3 m, mascar;
    // Start is called before the first frame update
    void Start()
    {
        score = m[0];
    }

    // Update is called once per frame
    void Update()
    {

        m = nrs.transform.position;
        mascar = gameObject.transform.localScale;
        if (score != m[0] )
        {
            if (mascar[1] - 1 > 0)
            {
                mascar[1] -= 1;
                gameObject.transform.localScale = mascar;
                score = m[0];
            }
            else
            {
                m[0] = score;
                nrs.transform.position = m;
            }
        }
    }
}