using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dewdrops : MonoBehaviour
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
			DewCountUI.instance.IncreaseDews(value);
			Destroy(gameObject);

		}
		if (other.CompareTag("friend1"))
		{
			DewCountUI.instance.plusF1Dews(value);
			Destroy(gameObject);
		}if (other.CompareTag("friend2"))
		{
			DewCountUI.instance.plusF2Dews(value);
			Destroy(gameObject);
		}if (other.CompareTag("friend3"))
		{
			DewCountUI.instance.plusF3Dews(value);
			Destroy(gameObject);
		}
	}
}
