using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {cell_0, cell_1, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell_0;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);

		if (myState == States.cell_0) 			{state_cell_0 ();}
		else if (myState == States.cell_1) 		{state_cell_1 ();}
		else if (myState == States.sheets_0)	{state_sheets_0 ();}
		else if (myState == States.lock_0) 		{state_lock_0 ();}
		else if (myState == States.mirror) 		{state_mirror ();}
		else if (myState == States.cell_mirror) {state_cell_mirror ();}
		else if (myState == States.sheets_1)	{state_sheets_1 ();}
		else if (myState == States.lock_1) 		{state_lock_1 ();}
		else if (myState == States.freedom)		{state_freedom ();}
	}

	void state_cell_0() {
		text.text = "You awaken groggily in the corner of a dark, dank room. " +
			"As your eyes grow accustomed to the gloom you realise " +
			"that you're in a dungeon cell.\n\n" +
			"Throwing off the filthy sheets you climb out of bed, bolt " +
			"to the cell door finding it unsurprisingly locked, turning " +
			"back you startle at the sight of your blood stained face in " +
			"the odd mirror hanging on the wall.\n\n" +
			"Press S to view Sheets, M to view Mirror, or L for Lock.";

		if (Input.GetKeyDown (KeyCode.S)) 		{myState = States.sheets_0;}
		else if (Input.GetKeyDown (KeyCode.M))  {myState = States.mirror;}
		else if (Input.GetKeyDown (KeyCode.L))  {myState = States.lock_0;}
	}

	void state_cell_1() {
		text.text = "Your eyes search the cell for any sign of escape but " +
			"all you find are the sheets you awoke under, an ornate hanging " +
			"mirror and the lock keeping you from freedom.\n\n" +
			"Press S to view Sheets, M to view Mirror, or L for Lock.";

		if (Input.GetKeyDown (KeyCode.S))      	{myState = States.sheets_0;}
		else if (Input.GetKeyDown (KeyCode.M))	{myState = States.mirror;}
		else if (Input.GetKeyDown (KeyCode.L)) 	{myState = States.lock_0;}
	}

	void state_sheets_0() {
		text.text = "The blood and sweat soiled sheets now lie in a heap on the " +
			"floor, they've seen better times.\n\n" +
			"Press R to continue searching the cell.";

		if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell_1;}
	}

	void state_mirror() {
		text.text = "You can barely bring yourself to gaze upon your almost " +
			"unrecognizable face, but in doing to you notice a small string " +
			"dangling from the bottom of the mirror frame.\n\n" +
			"With a gentle tug the string comes loose, at the end of which " +
			"hangs a small ornate key.\n\n" +
			"Press T to take the key, or R to continue searching the cell.";

		if (Input.GetKeyDown (KeyCode.R)) 	   	{myState = States.cell_1;}
		else if (Input.GetKeyDown (KeyCode.T)) 	{myState = States.cell_mirror;}
	}

	void state_lock_0() {
		text.text = "The lock consists of a large iron handle and a small ornate " +
			"keyhole, almost too delicate for such a crewd door.\n\n" +
			"No amount of pushing, pulling or screaming at the door has any effect.\n\n" +
			"Press R to continue searching the cell.";

		if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell_1;}
	}

	void state_cell_mirror() {
		text.text = "Key in hand you return your gaze to the filthy cell.\n\n" +
			"Press S to view Sheets, or L for Lock.";

		if (Input.GetKeyDown (KeyCode.S))		{myState = States.sheets_1;}
		else if (Input.GetKeyDown (KeyCode.L)) 	{myState = States.lock_1;}
	}

	void state_sheets_1() {
		text.text = "The filthy sheets remain where you'd discarded them a " +
			"few moments ago.\n\n" +
			"Press R to continue searching the cell.";

		if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell_mirror;}
	}

	void state_lock_1() {
		text.text = "Looking closely at the keyhole you realise that it matches " +
			"the ornate markings on the key found behind the mirror.\n\n" +
			"Press U to unlock the door, or R to continue searching the cell.";

		if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell_mirror;}
		else if (Input.GetKeyDown (KeyCode.U)) 	{myState = States.freedom;}
	}

	void state_freedom() {
		text.text = "Following a satisfying click the lock opens, and swinging the " +
			"door wider cautiously your peer into the corridor beyond.\n\n" +
			"With no sign of guards you breathe a sigh of relief and exit the " +
			"cell for what you hope will the the last time.\n\n" +
			"You have escaped!!! Press Return to restart.";

		if (Input.GetKeyDown (KeyCode.Return)) 	{myState = States.cell_0;}
	}

}
