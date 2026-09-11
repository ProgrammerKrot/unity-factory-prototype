using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fold4;
    Vector3 fper;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void click()
    {
        fper = fold4.transform.position;
        fper[0] = 1f;
        fold4.transform.position = fper;
    }
}
