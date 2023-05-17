using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energyBar : MonoBehaviour
{
    public Image EnergyBar;
	
	public PlayerController script;

	public int Max;
	public int energy;
	
	public int mov;
	public int res;
	
	void Start()
	{
	}
	
	
    void Update()
	{
		mov= script.move;
		res= script.rest;
		Max = script.maxenergy;
		energy = script.energy;
		
		if (mov>=1)
		{
			Move(1); 
		}
		if (res>=1)
		{
			rest(1);
		}
	}
	
	public void Move(int work)
	{
		energy -= work;
		EnergyBar.fillAmount = energy / Max;
	}
	
	public void rest(int regen)
	{
		energy += regen;
		energy = Mathf.Clamp(energy, 0, Max);
		EnergyBar.fillAmount = energy / Max;
	}
}
