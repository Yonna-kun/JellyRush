using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ranking : MonoBehaviour
{
	
	public StatusReport script;
	public int placing;
	private int flag1 = 0;
	private int flag2 = 0;
	private int flag3 = 0;
	
	public TextMeshProUGUI	numberText;
	
    // Start is called before the first frame update
    void Start()
    {
        script.placing = Mathf.Clamp(placing, 1, 4);
    }

    // Update is called once per frame
    void Update()
    {
		for (int i = 0; i < 3; i++)
		{
			if(script.raceRank>script.raceRank1)
			{
				flag1=1;
			}
			else
			{
				flag1=0;
			}
			if(script.raceRank>script.raceRank2)
			{
				flag2=1;
			}
			else
			{
				flag2=0;
			}
			if(script.raceRank>script.raceRank3)
			{
				flag3=1;
			}
			else
			{
				flag3=0;
			}
			script.placing = 1+flag1+flag2+flag3;
		}
		
		if (script.placing == 1)
		{
			numberText.text = placing + "st";
		}
		else if (script.placing == 2)
		{
			numberText.text = placing + "nd";
		}
		else if (script.placing == 3)
		{
			numberText.text = script.placing + "rd";
		}
		else if (script.placing == 4)
		{
			numberText.text = script.placing + "th";
		}
		
		if (script.raceRank <= 0)
		{
			script.roundsUp=true;
		}
    }
}
