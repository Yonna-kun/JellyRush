using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DewCountUI : MonoBehaviour
{
	public static DewCountUI instance;
	
	public TMP_Text dewText;
	public StatusReport script;
	
	public AudioSource collectsfx;

	void Awake()
	{
		instance = this;
	}
    // Start is called before the first frame update
    void Start()
    {
        dewText.text = script.currentDews.ToString();
		collectsfx = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	//Dews
	public void IncreaseDews(int v)
	{
		script.currentDews += v;
		dewText.text = script.currentDews.ToString();
		collectsfx.Play();
	}
	public void plusF1Dews(int v)
	{
		script.friend1Dews += v;
	}
	public void plusF2Dews(int v)
	{
		script.friend2Dews += v;
	}
	public void plusF3Dews(int v)
	{
		script.friend3Dews += v;
	}
}
