using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLooting : MonoBehaviour
{
	public int value = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			ItemCountUI.instance.IncreaseItems(value);
			Destroy(gameObject);
		}
		else if (other.CompareTag("friend1"))
		{
			ItemCountUI.instance.plusF1Items(value);
			Destroy(gameObject);
		}
		else if (other.CompareTag("friend2"))
		{
			ItemCountUI.instance.plusF2Items(value);
			Destroy(gameObject);
		}
		else if (other.CompareTag("friend3"))
		{
			ItemCountUI.instance.plusF3Items(value);
			Destroy(gameObject);
		}
	}
}
