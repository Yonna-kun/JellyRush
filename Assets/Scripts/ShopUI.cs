using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopUI : MonoBehaviour
{
	public storage script;
	
	public TMP_Text dewText;
	
    void Start()
    {
        dewText.text = script.dews.ToString();
	}
	void update()
	{
	}
	
	public void buttonBuy1()
	{
		if (script.dews>=50)
		{
			script.dews-=50;
			script.berry++;
        dewText.text = script.dews.ToString();
		}
	}
	public void buttonBuy2()
	{
		if (script.dews>=30)
		{
			script.dews-=30;
			script.broccoli++;
        dewText.text = script.dews.ToString();
		}
	}
	public void buttonBuy3()
	{
		if (script.dews>=200)
		{
			script.dews-=200;
			script.cake++;
        dewText.text = script.dews.ToString();
		}
	}
	public void buttonBuy4()
	{
		if (script.dews>=150)
		{
			script.dews-=150;
			script.book++;
        dewText.text = script.dews.ToString();
		}
	}
	public void buttonBuy5()
	{
		if (script.dews>=100)
		{
			script.dews-=100;
			script.ball++;
        dewText.text = script.dews.ToString();
		}
	}
	public void buttonBuy6()
	{
		if (script.dews>=200)
		{
			script.dews-=200;
			script.jumprope++;
        dewText.text = script.dews.ToString();
		}
	}
	public void buttonBuy7()
	{
		if (script.dews>=800 && script.eggshell<=0)
		{
			script.dews-=800;
			script.eggshell++;
        dewText.text = script.dews.ToString();
		}
	}
	public void buttonBuy8()
	{
		if (script.dews>=500 && script.blush<=0)
		{
			script.dews-=500;
			script.blush++;
        dewText.text = script.dews.ToString();
		}
	}
	public void buttonBuy9()
	{
		if (script.dews>=1500 && script.Porkchop<=0)
		{
			script.dews-=1500;
			script.Porkchop++;
        dewText.text = script.dews.ToString();
		}
		
	}
}
