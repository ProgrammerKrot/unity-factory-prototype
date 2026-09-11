using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeStart = 60;
    public GameObject flat;
    public GameObject Flat2;
    float score;
    Vector3 fod;
    Vector3 tor;
    [SerializeField] Text timerText;
    void Start()
    {
        timerText.text = timeStart.ToString();
        tor = flat.transform.position;
        score = tor[0];
        Flat2.transform.position = fod;

    }

    // Update is called once per frame
    void Update()
    {
        if (timeStart - Time.deltaTime > 0)
        {
            timeStart -= Time.deltaTime;
            tor[2] = timeStart;
            timerText.text = Mathf.Round(timeStart).ToString();
            score = tor[0];

            fod[0] = timeStart;
            Flat2.transform.position = fod;
        }
        else
        {
            timerText.text = "Time's Up!".ToString();
        }
    }
}
