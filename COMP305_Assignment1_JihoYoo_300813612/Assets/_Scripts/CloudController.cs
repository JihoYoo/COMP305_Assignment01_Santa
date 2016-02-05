/* Author's name: Jiho Yoo
* Last Modified by: Jiho Yoo
* Date last Modified: Feb 05, 2015
* Description: The santa is getting coins to buy presents for chidren in Christmas eve.
 * Revision History: 
* Feb 01, 2016 - set background and images.
* Feb 02, 2016 - write codes
* Feb 04, 2016 - set audios
* Feb 05, 2016 - found errors
*/
using UnityEngine;
using System.Collections;

public class CloudController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public float minVerticalSpeed = 5f;
	public float maxVerticalSpeed = 10f;
	public float minHorizontalSpeed = -2f;
	public float maxHorizontalSpeed = 2f;

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _verticalSpeed;
	private float _horizontalDrift;

	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform> ();

		// Reset the Coins Sprite to the Top
		this.Reset ();
	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2(this._horizontalDrift, this._verticalSpeed);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.y <= -330) {
			this.Reset ();
		}
	}

	public void Reset() {
		this._verticalSpeed = Random.Range (this.minVerticalSpeed, this.maxVerticalSpeed);
		this._horizontalDrift = Random.Range (this.minHorizontalSpeed, this.maxHorizontalSpeed);
		float xPosition = Random.Range (-206f, 206f);
		this._transform.position = new Vector2 (xPosition, 330f);
	}
}
