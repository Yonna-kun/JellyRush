using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
	public StatusReport script;
    float currentTime;
	int clock;
	//public int ready=4;
    public float startingTime = 100f;
	public TextMeshProUGUI	countdownText;
	public GameObject ScoreUI;

    void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
			currentTime = currentTime - Time.deltaTime;

			if (currentTime <= 0.00)
			{
				currentTime = 0;
				Time.timeScale = 0f;
				script.roundsUp=true;
				ScoreUI.SetActive(true);
			}
			
			clock=(int)currentTime;
			string formattedValue = currentTime.ToString("F2");
			countdownText.text = formattedValue.ToString();
		
		
    }
}