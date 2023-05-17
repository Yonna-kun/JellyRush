using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
	private SpriteRenderer spriteRenderer;
	public GameObject say1;
	public GameObject say2;
	public GameObject say3;
	
	public float stride = 4f;		//fitness1
	public float jumpheight = 7f;	//fitness2
	public int maxenergy = 20; 	//move trigger
	public int energy = 20; 	//move trigger
	//public int maxmana = 100;
	//public int mana;
	
	//public bool idle;
	public float idleTime = 1f;
	private float idleEndTime;
	
	
	public float restTime = 2f;
	private float restEndTime;
	
	public float cdTime = 2f;
	private float cdEndTime;
	
	
	public int move;
	public int rest;
	

	public float Decision;	//trigger
	public int focus = 80; //
	public int drive = 70; //goal oriented
	public int jumpy = 60; //happy
	
	//private int skill=1;
	
	AudioSource bouncesfx;
	
	public StatusReport script;
	
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		bouncesfx = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 characterScale = transform. localScale;
							//skill
			if (_rb.velocity.x == 0 && _rb.velocity.y == 0)
			{				
				if (Time.time >= idleEndTime + idleTime)
				{
			
					Decision = Random.Range(1,100);
					//strideforward
					if (Decision <= focus)
					{
						move = 1;
						if (Decision <= jumpy)
						{
								
							if (Decision >= drive)
							{
								jellyJumpb();
							}
							else
							{
								jellyJump();
							}
						}
						else
						{
							if (Decision >= drive)
							{
								jellyMoveb();
							}
							else
							{
								jellyMove();
							}
						}
					}
					else
					{
						rest=1;
							if (Decision >= drive)
							{
								jellyWaitb();
							}
							else
							{
								jellyWait();
							}
					}
					say1.SetActive(false);
					say2.SetActive(false);
					say3.SetActive(false);
				idleEndTime = Time.time;
				}
			
			
					if (script.goDash==1)
					{
						JellyDash();
					}
					else if (script.goBoost==1)
					{
						JellyBoost();
					}
					else if (script.goYEET==1)
					{
						JellyYEET();
					}
					script.goDash = 0f;
					script.goBoost = 0f;
					script.goYEET = 0f;
					move=0;
					rest=0;
			}
		
				
				//face move direction
			if (_rb.velocity.x > 0)
			{
				spriteRenderer.flipX = false;
			}
			else if (_rb.velocity.x < 0)
			{
				spriteRenderer.flipX = true;
			}
			
	}
				
	
		
    
	
	public void jellyMove()
	{
		_rb.AddForce(new Vector2(stride, 4), ForceMode2D.Impulse);
		bouncesfx.Play();
	}
	public void jellyMoveb()
	{
		_rb.AddForce(new Vector2(-stride, 4), ForceMode2D.Impulse);
		bouncesfx.Play();
	}
	public void jellyJump()
	{
		_rb.AddForce(new Vector2(2, jumpheight), ForceMode2D.Impulse);
		bouncesfx.Play();
	}
	public void jellyJumpb()
	{
		_rb.AddForce(new Vector2(-2, jumpheight), ForceMode2D.Impulse);
		bouncesfx.Play();
	}
	public void jellyWait()
	{
				if (Time.time >= restEndTime + idleTime)
				{
					rest=1;
					_rb.AddForce(new Vector2(1, 0), ForceMode2D.Impulse);
					restEndTime = Time.time;
				}
					
	}
	public void jellyWaitb()
	{
				if (Time.time >= restEndTime + idleTime)
				{
					rest=1;
					_rb.AddForce(new Vector2(-1, 0), ForceMode2D.Impulse);
					restEndTime = Time.time;
				}
	}
	
	
				//Dash			
				public void JellyDash()
				{
					if (Decision >= drive)
					{
					_rb.AddForce(new Vector2(-12, 4), ForceMode2D.Impulse);
					}
					else
					{
					_rb.AddForce(new Vector2(12, 4), ForceMode2D.Impulse);
					}
					say1.SetActive(true);
				}
				//Boost
				public void JellyBoost()
				{
					if (Decision >= drive)
					{
					_rb.AddForce(new Vector2(-2, 25), ForceMode2D.Impulse);
					}
					else
					{
					_rb.AddForce(new Vector2(2, 25), ForceMode2D.Impulse);
					}
					say2.SetActive(true);
				}
				//YEET
				public void JellyYEET()
				{
					if (Decision >= drive)
					{
					_rb.AddForce(new Vector2(-8, 18), ForceMode2D.Impulse);
					}
					else
					{
					_rb.AddForce(new Vector2(8, 18), ForceMode2D.Impulse);
					}
					say3.SetActive(true);
				}
}