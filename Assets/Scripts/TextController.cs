﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {
		cell_0, cell_1, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, corridor_0,
		stairs_0, closet_door, floor, stairs_1, corridor_1, in_closet, stairs_2, corridor_2,
		corridor_3, courtyard
	};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell_0;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);

		if 		(myState == States.cell_0) 		{cell_0 ();}
		else if (myState == States.cell_1) 		{cell_1 ();}
		else if (myState == States.sheets_0)	{sheets_0 ();}
		else if (myState == States.lock_0) 		{lock_0 ();}
		else if (myState == States.mirror) 		{mirror ();}
		else if (myState == States.cell_mirror) {cell_mirror ();}
		else if (myState == States.sheets_1)	{sheets_1 ();}
		else if (myState == States.lock_1) 		{lock_1 ();}
		else if (myState == States.corridor_0)	{corridor_0 ();}
		else if (myState == States.stairs_0)	{stairs_0 ();}
		else if (myState == States.closet_door)	{closet_door ();}
		else if (myState == States.floor)		{floor ();}
		else if (myState == States.stairs_1)	{stairs_1 ();}
		else if (myState == States.corridor_1)	{corridor_1 ();}
		else if (myState == States.in_closet)	{in_closet ();}
		else if (myState == States.stairs_2)	{stairs_2 ();}
		else if (myState == States.corridor_2)	{corridor_2 ();}
		else if (myState == States.corridor_3)	{corridor_3 ();}
		else if (myState == States.courtyard)	{courtyard ();}
	}

	#region State handler methods
	void cell_0() {
		text.text = "You awaken groggily in the corner of a dark, dank room. " +
			"As your eyes grow accustomed to the gloom you realise " +
			"that you're in a dungeon cell.\n\n" +
			"Throwing off the filthy sheets you climb out of bed, bolt " +
			"to the cell door finding it unsurprisingly locked, turning " +
			"back you startle at the sight of your blood stained face in " +
			"the odd mirror hanging on the wall.\n\n" +
			"Press S to view Sheets, M to view Mirror, or L for Lock.";

		if 		(Input.GetKeyDown (KeyCode.S)) 	{myState = States.sheets_0;}
		else if (Input.GetKeyDown (KeyCode.M))  {myState = States.mirror;}
		else if (Input.GetKeyDown (KeyCode.L))  {myState = States.lock_0;}
	}

	void cell_1() {
		text.text = "Your eyes search the cell for any sign of escape but " +
			"all you find are the sheets you awoke under, an ornate hanging " +
			"mirror and the lock keeping you from freedom.\n\n" +
			"Press S to view Sheets, M to view Mirror, or L for Lock.";

		if 	(Input.GetKeyDown (KeyCode.S))     	{myState = States.sheets_0;}
		else if (Input.GetKeyDown (KeyCode.M))	{myState = States.mirror;}
		else if (Input.GetKeyDown (KeyCode.L)) 	{myState = States.lock_0;}
	}

	void sheets_0() {
		text.text = "The blood and sweat soiled sheets now lie in a heap on the " +
			"floor, they've seen better times.\n\n" +
			"Press R to continue searching the cell.";

		if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell_1;}
	}

	void mirror() {
		text.text = "You can barely bring yourself to gaze upon your almost " +
			"unrecognizable face, but in doing to you notice a small string " +
			"dangling from the bottom of the mirror frame.\n\n" +
			"With a gentle tug the string comes loose, at the end of which " +
			"hangs a small ornate key.\n\n" +
			"Press T to take the key, or R to continue searching the cell.";

		if 		(Input.GetKeyDown (KeyCode.R))	{myState = States.cell_1;}
		else if (Input.GetKeyDown (KeyCode.T)) 	{myState = States.cell_mirror;}
	}

	void lock_0() {
		text.text = "The lock consists of a large iron handle and a small ornate " +
			"keyhole, almost too delicate for such a crewd door.\n\n" +
			"No amount of pushing, pulling or screaming at the door has any effect.\n\n" +
			"Press R to continue searching the cell.";

		if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell_1;}
	}

	void cell_mirror() {
		text.text = "Key in hand you return your gaze to the filthy cell.\n\n" +
			"Press S to view Sheets, or L for Lock.";

		if 		(Input.GetKeyDown (KeyCode.S))	{myState = States.sheets_1;}
		else if (Input.GetKeyDown (KeyCode.L)) 	{myState = States.lock_1;}
	}

	void sheets_1() {
		text.text = "The filthy sheets remain where you'd discarded them a " +
			"few moments ago.\n\n" +
			"Press R to continue searching the cell.";

		if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell_mirror;}
	}

	void lock_1() {
		text.text = "Looking closely at the keyhole you realise that it matches " +
			"the ornate markings on the key found behind the mirror.\n\n" +
			"Press U to unlock the door, or R to continue searching the cell.";

		if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell_mirror;}
		else if (Input.GetKeyDown (KeyCode.U)) 	{myState = States.corridor_0;}
	}

	void corridor_0() {
		text.text = "With a satisfying click the lock opens, and swinging the " +
			"door wider cautiously you step into the corridor beyond.\n\n" +
			"You are alone in the corridor, stairs lead up on the right, to your " +
			"left you see a dusty closet and something glistens in the dirt of the floor.\n\n" +
			"Press S to climb the stairs, C to examine the closet, or F to search the floor.";

		if 		(Input.GetKeyDown (KeyCode.S)) 	{myState = States.stairs_0;}
		else if (Input.GetKeyDown (KeyCode.C)) 	{myState = States.closet_door;}
		else if (Input.GetKeyDown (KeyCode.F)) 	{myState = States.floor;}
	}

	void stairs_0() {
		text.text = "As you get close to the top of the stairs the sound of " +
			"movement and voices freezes you in your tracks.\n\n" +
			"Press R to return to the corridor.";

		if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.corridor_0;}
	}

	void closet_door() {
		text.text = "The closet looks recently used, but is firmly locked and no key in sight.\n\n" +
			"Press R to return to the corridor.";

		if (Input.GetKeyDown (KeyCode.R)) {myState = States.corridor_0;}
	}
		
	void floor() {
		text.text = "Kneeling down to examine the glinting object on the floor you find a " +
			"small brass hairpin.\n\n" +
			"Press R to return to the corridor.";

		if (Input.GetKeyDown (KeyCode.R)) {myState = States.corridor_1;}
	}

	void corridor_1() {
		text.text = "Hairpin in hand you peer around the corridor once more, you thieving instincts " +
			"immediately kick into overdrive and your attention switches from the stairs to the " +
			"locked closet.\n\n" +
			"Press P to pick the closet lock, or S to climb the stairs.";
		
		if 		(Input.GetKeyDown (KeyCode.P)) 	{myState = States.in_closet;}
		else if (Input.GetKeyDown (KeyCode.S)) 	{myState = States.stairs_1;}
	}

	void stairs_1() {
		text.text = "You barely make it 5 steps before the sound of raised voices make you freeze. " +
			"An unseen woman screams 'The masters carriage is filthy, I want it cleaned NOW'.\n\n" +
			"Press R to return to the corridor.";

		if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.corridor_1;}
	}

	void in_closet() {
		text.text = "The closet lock opens easily and inside you find the uniform of a royal " +
			"cleaner, it looks to be just about your size.\n\n" +
			"Press D to disguise as a cleaner, or R to return to the corridor.";

		if 		(Input.GetKeyDown (KeyCode.R)) 	{myState = States.corridor_2;}
		else if (Input.GetKeyDown (KeyCode.D)) 	{myState = States.corridor_3;}
	}

	void corridor_2() {
		text.text = "Closing the closet door you hear footsteps coming from the direction of the" +
			"stairs.\n\n" +
			"Press D to disguise as a cleaner, or S to approach the stairs.";

		if 		(Input.GetKeyDown (KeyCode.S)) 	{myState = States.stairs_2;}
		else if (Input.GetKeyDown (KeyCode.D)) 	{myState = States.corridor_3;}
	}

	void stairs_2() {
		text.text = "The distant footsteps turn into a thunder of shouting and metallic clanking " +
			"as pouring from the stairs come five heavily armed guards, each sword at the ready " +
			"with eyes locked on your fear frozen frame.\n\n" +
			"You do not feel the first blow only the rush of breath in your throat and the sound " +
			"of your own bubbling screams as the life sprays forth from the gaping wound in your neck.\n\n" +
			"You die, cold and alone. Press P to play again.";

		if (Input.GetKeyDown (KeyCode.P)) 		{myState = States.cell_0;}
	}

	void corridor_3() {
		text.text = "You slip on the final piece of the cleaners outfit and freeze in panic on feeling " +
			"a sharp tap on your shoulder.\n\n" +
			"Turning slowly you come face to face with a red faced guard who spits at you 'Did you not " +
			"hear the housekeeper!! Get going and clean the carriage, NOW, lest I crack your head'.\n\n" +
			"Press S to climb the stairs.";

		if (Input.GetKeyDown (KeyCode.S)) 		{myState = States.courtyard;}
	}

	void courtyard() {
		text.text = "As you emerge at the top of the stairs a tall stern woman appears to your left and " +
			"proceeds to painfully dragging you towards the front door.\n\n" +
			"'Get cleaning wretch' is the last thing you hear as the door slams shut and you emerge " +
			"blinking on the streets of Ankh Morpok.\n\n" +
			"Your legs immediately start running towards the Mages tower and home, you don't once look back.\n\n" +
			"You are FREE !!!. Press P to play again.";

		if (Input.GetKeyDown (KeyCode.P)) 		{myState = States.cell_0;}
	}
	#endregion

}
