using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brock : MonoBehaviour
{
    private bool clc = false;
    public Material mat;
    public Material brmat;
    public float k;
    private float st;
    public GameObject obj;
    public GameObject fold3;
    Vector3 fold;
    [SerializeField] Text label;
    float m, h, w;
    Vector3 torl;
    // Start is called before the first frame update
    void Start()
    {
        obj.transform.position = torl;
        fold3.transform.position = fold;
        st = k;
        m = fold[0];
        h = fold[1];
        w = fold[2];
    }

    // Update is called once per frame
    void Update()
    {
        print(fold);
        int rand_m = Random.Range(0, 834); //7
        //int rand_m = Random.Range(0, 60);
        int rand_h = Random.Range(0, 325); //9
        int rand_w = Random.Range(0, 327); //8
        if (gameObject.name == "zavodm")
        {
            fold3.transform.position = new Vector3 (m, h, w);
            if ((torl[0] % 13 == 0) && (rand_m % 834 == 0))
            {
                gameObject.GetComponent<MeshRenderer>().material = brmat;
                label.text = "Broken".ToString();
                m = 1f;
            }
        }
        else if (gameObject.name == "zavodh")
        {
            fold3.transform.position = fold; ;
            if ((rand_h % 325 == 0) && (torl[0] % 30 == 0))
            {
                gameObject.GetComponent<MeshRenderer>().material = brmat;
                label.text = "Broken".ToString();
                h = 1f;
            }
        }
        else
        {
            fold3.transform.position = fold;
            if ((rand_w %  327 == 0) && (torl[0] % 7 == 0))
            {
                gameObject.GetComponent<MeshRenderer>().material = brmat;
                label.text = "Broken".ToString();
                w = 1f;
            }
        }
        fold = new Vector3(m, h, w);
        fold3.transform.position = fold;

        if (clc)
        { 
            gameObject.GetComponent<MeshRenderer>().material = mat;
            label.text = "".ToString();
            if (gameObject.name == "zavodm")
            {
                fold3.transform.position = fold;
                m = 0;
            }
            else if (gameObject.name == "zavodh")
            {
                fold3.transform.position = fold;
                h = 0;
            }
            else
            {
                fold3.transform.position = fold;
                w = 0;
            }
            clc = false;
            fold = new Vector3(m, h, w);
            fold3.transform.position = fold;
        }
    }

    private void OnMouseDown()
    {
        clc = true;
    }
}
