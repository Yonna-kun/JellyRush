using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloudy : MonoBehaviour
{
	 private Rigidbody2D _rb;
	private SpriteRenderer spriteRenderer;
	
	public float SPEED = 0.001f;		//fitness1
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 characterScale = transform. localScale;
			_rb.AddForce(new Vector2(SPEED, 0), ForceMode2D.Impulse);
			transform.Translate(Vector3.right * SPEED * Time.deltaTime);
		
			if (_rb.velocity.x > 0)
			{
				spriteRenderer.flipX = false;
			}
			else if (_rb.velocity.x < 0)
			{
				spriteRenderer.flipX = true;
			}
		
    }
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("wall"))
		{
			SPEED = -SPEED;
		}
	}
}
