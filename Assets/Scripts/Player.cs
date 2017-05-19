using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

	public GameObject bullet;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void Shoot()
	{
		GameObject clone = GameObject.Instantiate(bullet, this.transform.position, bullet.transform.rotation) as GameObject;
		clone.AddComponent<Rigidbody2D>();
		clone.GetComponent<Rigidbody2D>().AddForce(new Vector2(900f, 0f));
	}

	public void MoveLeft()
	{
		this.GetComponent<Rigidbody2D>().AddForce(new Vector2(-150f, 0f));
	}

	public void MoveRight()
	{
		this.GetComponent<Rigidbody2D>().AddForce(new Vector2(150f, 0f));
	}

	public void Jump()
	{
		if(this.GetComponent<Rigidbody2D>().velocity.y == 0f)
		{
			this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 500f));
		}
	}
}
