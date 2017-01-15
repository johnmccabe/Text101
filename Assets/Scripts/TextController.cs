using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
		text.text = "Press Space to begin your adventure...";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			text.text = "You awaken groggily in the corner of a dark, dank room. " +
						"As your eyes grow accustomed to the gloom you realise " +
						"that you're in a dungeon cell.\n\n" +
						"Throwing off the filthy sheets you climb out of bed, bolt " +
						"to the cell door finding it unsurprisingly locked, turning " +
						"back you startle at the sight of your blood stained face in " +
						"the odd mirror hanging on the wall.\n\n" +
						"Press S to view Sheets, M to view Mirror, or L for Lock.";
		}
	}
}
