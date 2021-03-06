﻿/* Author's name: Jiho Yoo
* Last Modified by: Jiho Yoo
* Date last Modified: Feb 05, 2015
* Description: The ship is getting coins to buy presents for chidren in Christmas eve.
 * Revision History: 
* Feb 01, 2016 - set background and images.
* Feb 02, 2016 - write codes
* Feb 04, 2016 - set audios
* Feb 05, 2016 - found errors
*/
using UnityEngine;
using System.Collections;

public class PlaneCollider : MonoBehaviour {
	// PRIVATE INSTANCE VARIABLES
	private AudioSource[] _audioSources;
	private AudioSource _islandSound;
	private AudioSource _cloudSound;

	// PUBLIC INSTANCE VARIABLES
	public GameController gameController;

	// Use this for initialization
	void Start () {
		// Initialize the audioSources array
		this._audioSources = gameObject.GetComponents<AudioSource> ();
		this._cloudSound = this._audioSources [1];
		this._islandSound = this._audioSources [2];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Island")) {
			this._islandSound.Play ();
			this.gameController.ScoreValue += 100;
		}
		if (other.gameObject.CompareTag ("Cloud")) {
			this._cloudSound.Play ();
			this.gameController.LivesValue -= 1;
		}
  	}

}