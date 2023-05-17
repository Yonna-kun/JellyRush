using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCountUI : MonoBehaviour
{
	public static ItemCountUI instance;
	
	public TMP_Text itemText;
	public StatusReport script;
	
	AudioSource lootsfx;

	void Awake()
	{
		instance = this;
	}
    // Start is called before the first frame update
    void Start()
    {
        itemText.text = script.currentItems.ToString();
		lootsfx = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	//Items
	public void IncreaseItems(int v)
	{
		script.currentItems += v;
		itemText.text = script.currentItems.ToString();
			lootsfx.Play();
	}
	public void plusF1Items(int v)
	{
		script.friend1Items += v;
	}
	public void plusF2Items(int v)
	{
		script.friend2Items += v;
	}
	public void plusF3Items(int v)
	{
		script.friend3Items += v;
	}
}
