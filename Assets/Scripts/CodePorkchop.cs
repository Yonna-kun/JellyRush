using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodePorkchop : MonoBehaviour
{
	public static CodePorkchop instance;
	public AudioSource oinksfx;
    // Start is called before the first frame update
    void Start()
    {
        
		oinksfx = GetComponent<AudioSource>();
    }

    // Update is called once per frame
   public void oink()
	{
		oinksfx.Play();
	}
}
