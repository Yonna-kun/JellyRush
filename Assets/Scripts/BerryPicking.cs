using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerryPicking : MonoBehaviour
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
			BerryCountUI.instance.IncreaseBerry(value);
			Destroy(gameObject);
		}
		else if (other.CompareTag("friend1"))
		{
			BerryCountUI.instance.plusF1Berry(value);
			Destroy(gameObject);
		}
		else if (other.CompareTag("friend2"))
		{
			BerryCountUI.instance.plusF2Berry(value);
			Destroy(gameObject);
		}
		else if (other.CompareTag("friend3"))
		{
			BerryCountUI.instance.plusF3Berry(value);
			Destroy(gameObject);
		}
	}
}
