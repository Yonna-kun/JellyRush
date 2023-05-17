using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendsController : MonoBehaviour
{
    private Rigidbody2D _rb;
	private SpriteRenderer spriteRenderer;
	
	public float stride = 4f;		//fitness1
	public float jumpheight = 7f;	//fitness2
	//public float stamina = 10f; 	//move trigger

	public int Decision;	//trigger
	public int focus = 90; //
	public int drive = 80; //goal oriented
	public int jumpy = 70; //happy
	public int yeet;
	
	public float idleTime = 2f;
	private float idleEndTime;
	
	public float restTime = 2f;
	private float restEndTime;
	
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
		
		if (Time.time >= idleEndTime + idleTime)
		{
			
			Decision = Random.Range(1,100);
			

			if (_rb.velocity.x == 0 && _rb.velocity.y == 0)
			{
				
				//Auto bounce
				
				//strideforward
				if (Decision <= focus)
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
								jellyWaitb();
							}
							else
							{
								jellyWait();
							}
					}
					
				yeet = Random.Range(1,10);
				if (yeet==10)
				{
					JellyYEET();
				}
				else if (yeet==9)
				{
					JellyBoost();
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
					_rb.AddForce(new Vector2(1, 0), ForceMode2D.Impulse);
					restEndTime = Time.time;
				}
	}
	public void jellyWaitb()
	{
		if (Time.time >= restEndTime + idleTime)
				{
					_rb.AddForce(new Vector2(-1, 0), ForceMode2D.Impulse);
					restEndTime = Time.time;
				}
	}
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
					yeet=0;
				}
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
					yeet=0;
				}
	
}