using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storage : MonoBehaviour
{
	
	
	public int dews=2000;
	public int berry;
	public int ball;

	public int broccoli;
	public int cake;
	public int book;
	public int jumprope;
	public int eggshell;
	public int blush;
	public int Porkchop;
	
    // Start is called before the first frame update
    void Start()
    {
        dews=OverAllscore.totalDews;
		berry=OverAllscore.totalBerry;
		ball=OverAllscore.totalItems;

	
    }

    // Update is called once per frame
    void Update()
    {
        OverAllscore.totalDews=dews;
		OverAllscore.totalBerry=berry;
		OverAllscore.totalItems=ball;
    }
}
