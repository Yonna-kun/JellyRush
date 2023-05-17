using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class friendPetra : MonoBehaviour
{
    private Rigidbody2D _rb;
	private SpriteRenderer spriteRenderer;
	
	public float stride = 4.3f;		//fitness1
	public float jumpheight = 7f;	//fitness2
	//public float stamina = 10f; 	//move trigger

	public int Decision;	//trigger
	public int focus = 70; //
	public int drive = 60; //goal oriented
	public int jumpy = 60; //happy
	public int skill = 10;
	
	public float idleTime = 2.7f;
	private float idleEndTime;
	
	
	AudioSource bouncesfx;
    
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
		//Manual Bounce
		
			Decision = Random.Range(1,100);
		if (Time.time >= idleEndTime + idleTime)
		{
			
			Decision = Random.Range(1,100);
			
				//Auto bounce
				
				//strideforward
				if (Decision <= focus)
					{
						if (Decision > skill)
						{
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
							if (Decision >= drive)
								{
									_rb.AddForce(new Vector2(-8, 4), ForceMode2D.Impulse);
									_rb.AddForce(new Vector2(-8, 4), ForceMode2D.Impulse);
									_rb.AddForce(new Vector2(-8, 4), ForceMode2D.Impulse);
								}
								else
								{
									_rb.AddForce(new Vector2(8, 4), ForceMode2D.Impulse);
									_rb.AddForce(new Vector2(8, 4), ForceMode2D.Impulse);
									_rb.AddForce(new Vector2(8, 4), ForceMode2D.Impulse);
								}
						}
							
					}
					else
					{					
							if (Decision >= drive)
							{
								jellyWaitb();
							}
							else
							{
								jellyWait();
							}
					
					}
				
			}

			
			if (_rb.velocity.x > 0)
			{
				spriteRenderer.flipX = false;
			}
			else if (_rb.velocity.x < 0)
			{
				spriteRenderer.flipX = true;
			}
			
		
			idleEndTime = Time.time;
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
		_rb.AddForce(new Vector2(1, 0), ForceMode2D.Impulse);
	}
	public void jellyWaitb()
	{
		_rb.AddForce(new Vector2(-1, 0), ForceMode2D.Impulse);
	}
	
}
