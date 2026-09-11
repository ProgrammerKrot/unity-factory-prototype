using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickoncar : MonoBehaviour
{
    Vector3 d, s, m;
    public GameObject fold;
    private bool rnr = false;
    public GameObject go_tr;
    public GameObject fold4;
    // Start is called before the first frame update
    void Start()
    {
        d = gameObject.transform.position;
        s = fold.transform.localScale;
        m = fold4.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (rnr)
        {
            if ((d[2] < 300) && (s[0] != 2))
            {
                d[2] += 1;
                gameObject.transform.position = d;
            }
            if (d[2] == 300)
            {
                s[0] = 2;
                gameObject.transform.localScale = new Vector3(6, 10, 17);
            }
            if ((d[2] > -4.2) && (s[0] == 2))
            {
                d[2] -= 1;
                gameObject.transform.position = d;

            }
            m[0] = 1f;
            fold4.transform.position = m;
        }
        if (go_tr.transform.position.x == 1f)
        {
            if (s[0] != 2)
                rnr = true;
            else
            {
                rnr = false;
                s[0] = 1;
            }
        }
    }



    private void Asw()
    {
        if (fold4.transform.position.x == 1f)
        {
            if (s[0] != 2)
                rnr = true;
            else
            {
                rnr = false;
                s[0] = 1;
            }
        }
    }
}
