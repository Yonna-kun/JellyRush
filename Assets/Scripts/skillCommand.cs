using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillCommand : MonoBehaviour
{
	//public CheerButton button;
	
	public StatusReport script;
	
	[Header("Ability 1")]
	public Image abilityImage1;
	public float cooldown1 = 5;
	
	[Header("Ability 2")]
	public Image abilityImage2;
	public float cooldown2 = 5;
	
	[Header("Ability 3")]
	public Image abilityImage3;
	public float cooldown3 = 5;
	
	
	bool isCooldown1 = false;
	bool isCooldown2 = false;
	bool isCooldown3 = false;
	
	
    // Start is called before the first frame update
	
    void Start()
    {
		abilityImage1.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
		
		if (Input.GetKey("z"))
		{
			script.goDash=1;
			buttonDash();
		}
		if (Input.GetKey("z"))
		{
			script.goBoost=1;
			buttonDash();
		}
		if (Input.GetKey("z"))
		{
			script.goYEET=1;
			buttonDash();
		}
		
		Ability1();
		Ability2();
		Ability3();
    }
	//skill cd
	public void Ability1()
	{
		if(script.goDash==1 && isCooldown1 == false);
		{
			isCooldown1 = true;
			abilityImage1.fillAmount = 1;
		}
		if (isCooldown1)
		{
			abilityImage1.fillAmount -=1 / cooldown1 *Time.deltaTime;
			
			if(abilityImage1.fillAmount<=0)
			{
				if (abilityImage1.fillAmount<=0)
				{
					abilityImage1.fillAmount=0;
					isCooldown1 = false;
					script.goDash=0;
				}
			}
		}
	}
	public void Ability2()
	{
		if(script.goBoost==1 && isCooldown2 == false);
		{
			isCooldown2 = true;
			abilityImage2.fillAmount = 1;
		}
		if (isCooldown2)
		{
			abilityImage2.fillAmount -=1 / cooldown2 *Time.deltaTime;
			
			if(abilityImage2.fillAmount<=0)
			{
				if (abilityImage2.fillAmount<=0)
				{
					abilityImage2.fillAmount=0;
					isCooldown2 = false;
					script.goDash=0;
				}
			}
		}
	}
		public void Ability3()
	{
		if(script.goYEET==1 && isCooldown3 == false);
		{
			isCooldown3 = true;
			abilityImage3.fillAmount = 1;
		}
		if (isCooldown3)
		{
			abilityImage3.fillAmount -=1 / cooldown3 *Time.deltaTime;
			
			if(abilityImage3.fillAmount<=0)
			{
				if (abilityImage3.fillAmount<=0)
				{
					abilityImage3.fillAmount=0;
					isCooldown3 = false;
					script.goYEET=0;
				}
			}
		}
	}
	
	//activate skill
	public void buttonDash()
	{
			script.goDash = 1f;
		
	}
	
	public void buttonBoost()
	{
			script.goBoost = 1f;
		
	}
	
	public void buttonYEET()
	{
			script.goYEET = 1f;
		
	}
}
