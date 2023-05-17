using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BerryCountUI : MonoBehaviour
{
	public static BerryCountUI instance;
	
	public TMP_Text berryText;
	public StatusReport script;
	
	AudioSource picksfx;

	void Awake()
	{
		instance = this;
	}
    // Start is called before the first frame update
    void Start()
    {
        berryText.text = script.currentBerry.ToString();
		picksfx = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	//Berries
	public void IncreaseBerry(int v)
	{
		script.currentBerry += v;
		berryText.text = script.currentBerry.ToString();
			picksfx.Play();
	}
	public void plusF1Berry(int v)
	{
		script.friend1Berry += v;
	}
	public void plusF2Berry(int v)
	{
		script.friend2Berry += v;
	}
	public void plusF3Berry(int v)
	{
		script.friend3Berry += v;
	}
	
}
