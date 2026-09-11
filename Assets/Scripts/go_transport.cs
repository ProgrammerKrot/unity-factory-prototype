using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go_transport : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fold4;
    // Update is
    // called once per frame
    private void Start()
    {
        Vector3 xyz = fold4.transform.position;
    }
    public void clickb()
    {
        Vector3 xyz = new Vector3(1f, 0, 0);
        fold4.transform.position = xyz;
    }
}
