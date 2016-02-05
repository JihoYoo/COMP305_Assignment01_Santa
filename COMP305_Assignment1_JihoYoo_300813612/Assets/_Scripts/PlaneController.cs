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

public class PlaneController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public float speed = 6f;

	// PRIVATE INSTANCE VARIABLES
	private float _playerInput;
	private Transform _transform;
	private Vector2 _currentPosition;
    private float _playerInput2;

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;

		this._playerInput = Input.GetAxis ("Horizontal");
        this._playerInput2 = Input.GetAxis("Vertical");
		// if player input is positive move right 
		if (this._playerInput > 0) {
			this._currentPosition += new Vector2 (this.speed, 0);
		}

		// if player input is negative move left 
		if (this._playerInput < 0) {
			this._currentPosition -= new Vector2 (this.speed, 0);
		}

        // if player input is positive move up
        if (this._playerInput2 > 0)
        {
            this._currentPosition += new Vector2(0, this.speed);
        }

        // if player input is positive move down
        if (this._playerInput2 < 0)
        {
            this._currentPosition -= new Vector2(0, this.speed);
        }



        this._checkBounds ();

		this._transform.position = this._currentPosition;
	}


	// PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	private void _checkBounds() {
		// check if the plane is going out of bounds and keep it inside window boundary
		if (this._currentPosition.x < -300) {
			this._currentPosition.x = -300;
		}

		if (this._currentPosition.x > 300) {
			this._currentPosition.x = 300;
		}
	}
}
