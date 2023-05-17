using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanceCounter2 : MonoBehaviour
{
	
	public StatusReport script;
	
	[SerializeField]
	private Transform finishLine;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		script.raceRank2 = (finishLine.transform.position - transform.position).magnitude;
    }
}
