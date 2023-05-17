using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//carryover score to next round
public class OverAllscore : MonoBehaviour
{
	public StatusReport script;
	
	public TMP_Text dewText;
	public TMP_Text berryText;
	public TMP_Text itemText;
	public TextMeshProUGUI	rankText;
	
	public static int totalDews;
	public static int totalBerry;
	public static int totalItems;
    // Start is called before the first frame update
    void Start()
    {
		
        dewText.text = script.currentDews.ToString();
        berryText.text = script.currentBerry.ToString();
        itemText.text = script.currentItems.ToString();
        rankText.text = script.placing.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(script.roundsUp==true)
		{
			if (script.placing == 1)
			{
				rankText.text = script.placing + "st";
			}
			else if (script.placing == 2)
			{
				rankText.text = script.placing + "nd";
			}
			else if (script.placing == 3)
			{
				rankText.text = script.placing + "rd";
			}
			else
			{
				rankText.text = script.placing + "th";
			}
			dewText.text = script.currentDews.ToString();
			berryText.text = script.currentBerry.ToString();
			itemText.text = script.currentItems.ToString();
			
			totalDews=totalDews+script.currentDews;
			totalBerry=totalBerry+script.currentBerry;
			totalItems=totalItems+script.currentItems;
			
			
		//Time.timeScale = 0f;
		}
    }
}
