using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class One_money : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject opject;
	public GameObject par;
	private GameObject inst_obj;
	public GameObject fold3;
	public float timespwn;
	private float t;
	public float timeStart = 60;
	public GameObject fold;
	[SerializeField] Text scoret;
	Vector3 fld3;
	public GameObject prnt;
	[SerializeField] Text label;


	private void Start()
	{
		t = timespwn;

	}


	void Update()
	{
		fld3 = fold3.transform.position;
		Vector3 f = fold.transform.position;
		if (Caan())
		{
			if (timespwn <= 0)
			{
				if (timeStart - Time.deltaTime > 0)
				{
					if ((gameObject.name == "zavodm") && (label.text != "Broken"))
                    {
						Vector3 pos = par.transform.position;
						int rand = Random.Range(-10, 24);
						inst_obj = Instantiate(opject, new Vector3(pos[0], pos[1] + 10f, pos[2]), Quaternion.identity) as GameObject;
						inst_obj.transform.localScale = new Vector3(5f, 5f, 5f);
						inst_obj.transform.parent = prnt.transform;
						timespwn = t;
						f[0] += 20;
                    }
					else if ((gameObject.name == "zavodh") && (label.text != "Broken"))
                    {
						Vector3 pos = par.transform.position;
						int rand = Random.Range(-10, 24);
						inst_obj = Instantiate(opject, new Vector3(pos[0], pos[1] + 10f, pos[2]), Quaternion.identity) as GameObject;
						inst_obj.transform.localScale = new Vector3(5f, 5f, 5f);
						inst_obj.transform.parent = prnt.transform;
						timespwn = t;
						f[0] += 40;
                    }
                    else if ((gameObject.name == "zavodw") && (label.text != "Broken"))
                    {
						Vector3 pos = par.transform.position;
						int rand = Random.Range(-10, 24);
						inst_obj = Instantiate(opject, new Vector3(pos[0], pos[1] + 10f, pos[2]), Quaternion.identity) as GameObject;
						inst_obj.transform.localScale = new Vector3(5f, 5f, 5f);
						inst_obj.transform.parent = prnt.transform;
						timespwn = t;
						f[0] += 30;
                    }
					timeStart -= Time.deltaTime;
				}
			}
			else
			{
				timespwn -= Time.deltaTime;
			}
		}
		if (timeStart - Time.deltaTime > 0)
        {
			timeStart -= Time.deltaTime;
        }
			fold.transform.position = f;
		scoret.text = f[0].ToString();
	}

	bool Caan()
	{
		if (gameObject.name == "zavodm")
        {
			if (GameObject.Find("m(Clone)"))
            {	
				//score += 1;
				return false;
            }
            else
            {
				
				return true;
			}
		}
		else if (gameObject.name == "zavodh")
		{
			if (GameObject.Find("h(Clone)"))
			{
				return false;
			}
			else
			{
				//score += 10;
				return true;
			}
		}
		else if (gameObject.name == "zavodw")
		{
			if (GameObject.Find("w(Clone)"))
			{
				return false;
			}
			else
			{
				//score += 5;
				return true;
			}
		}
        else
        {
			return true;
        }
    }
}
