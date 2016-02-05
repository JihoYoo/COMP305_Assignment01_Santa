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

public class OceanController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public float speed = 5f;

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform> ();

		// Reset the Ocean Sprite to the Top
		this.Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2(0, this.speed);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.y <= -480) {
			this.Reset ();
		}
	}

	public void Reset() {
		this._transform.position = new Vector2 (0, 480f);
	}
}
