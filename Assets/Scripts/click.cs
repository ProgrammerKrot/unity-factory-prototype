using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class click : MonoBehaviour
{

	public int score;
	//[SerializeField] Text scoreText;
	void OnMouseDown()
	{
		Destroy(gameObject);
		score += 1;
	}

    //private void Update()
    //{
	//	scoreText.text = score.ToString();
    //}
}
