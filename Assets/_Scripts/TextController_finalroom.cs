using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextController_finalroom : MonoBehaviour
{
	//Controls text element
	public Text text;

	// Every statemachine needs to be mentioned in this enum
	private enum States
	{
		finalroom_0a, finalroom_0b, finalroom_1, finalroom_2, finalroom_3, finalroom_4, finalroom_5, 
		finalroom_6, finalroom_7, finalroom_8, finalroom_9, fr_beast_0, fr_beast_1, fr_beast_2, 
		fr_beast_3, fr_beast_4, fr_beast_5, fr_beast_6, fr_beast_7, fr_beast_8, fr_beast_9, 
		fr_scientists_0, fr_scientists_1, fr_scientists_2, fr_scientists_3, fr_scientists_4, 
		fr_scientists_5, fr_scientists_6, fr_scientists_7, fr_scientists_8, fr_scientists_9, 
		fr_device_0, fr_device_1, fr_device_2, fr_device_3, fr_device_4, fr_device_5, fr_device_6, 
		fr_device_7, fr_device_8, fr_device_9, fr_monitors_0, fr_monitors_1, fr_monitors_2, fr_monitors_3, 
		fr_monitors_4, fr_monitors_5, fr_monitors_6, fr_monitors_7, fr_monitors_8, fr_monitors_9, 
		fr_cabinets_0, fr_cabinets_1, fr_cabinets_2, fr_cabinets_3, fr_cabinets_4, fr_cabinets_5, 
		fr_cabinets_6, fr_cabinets_7, fr_cabinets_8, fr_cabinets_9, fr_mummy_0, fr_mummy_1, fr_mummy_2, 
		fr_mummy_3, fr_mummy_4, fr_mummy_5, fr_mummy_6, fr_mummy_7, fr_mummy_8, fr_mummy_9, fr_trash_0, 
		fr_trash_1, fr_trash_2, fr_trash_3, fr_trash_4, fr_trash_5, fr_trash_6, fr_trash_7, fr_trash_8, 
		fr_trash_9, 

		fr_device_examinea, fr_monitors_examinea, fr_cabinets_examine, fr_trash_examine, fr_mummy_examine,
		fr_device_examineb, fr_monitors_examineb, fr_device_operate, fr_freedom
	};
	//Our statemachine declaration
	private States myState;

	// Use this for initialization
	void Start()
	{
		text = GameObject.FindObjectOfType<Text>();
		//Beginning state
		myState = States.finalroom_0a;
	}

	// Update is called once per frame
	void Update()
	{
		print(myState);

		//We update here the states where the player is currently
		//State 0
		if (myState == States.finalroom_0a) { finalroom_0a(); }
		else if (myState == States.finalroom_0b) { finalroom_0b (); } 
		else if (myState == States.fr_beast_0) { fr_beast_0(); } //---> State 1
		else if (myState == States.fr_scientists_0) { fr_scientists_0(); }
		else if (myState == States.fr_device_0) { fr_device_0(); }
		else if (myState == States.fr_monitors_0) { fr_monitors_0(); }
		else if (myState == States.fr_cabinets_0) { fr_cabinets_0(); }
		else if (myState == States.fr_mummy_0) { fr_mummy_0(); }
		else if (myState == States.fr_trash_0) { fr_trash_0(); }

		//State 1
		else if (myState == States.finalroom_1) { finalroom_1(); }
		else if (myState == States.fr_beast_1) { fr_beast_1(); }
		else if (myState == States.fr_scientists_1) { fr_scientists_1(); }
		else if (myState == States.fr_device_1) { fr_device_1(); }
		else if (myState == States.fr_device_examinea) { fr_device_examinea(); } //---> State 2
		else if (myState == States.fr_monitors_1) { fr_monitors_1(); }
		else if (myState == States.fr_cabinets_1) { fr_cabinets_1(); }
		else if (myState == States.fr_mummy_1) { fr_mummy_1(); }
		else if (myState == States.fr_trash_1) { fr_trash_1(); }

		//State 2
		else if (myState == States.finalroom_2) { finalroom_2(); }
		else if (myState == States.fr_beast_2) { fr_beast_2(); }
		else if (myState == States.fr_scientists_2) { fr_scientists_2(); }
		else if (myState == States.fr_device_2) { fr_device_2(); }
		else if (myState == States.fr_monitors_examinea) { fr_monitors_examinea(); } //---> State 3
		else if (myState == States.fr_monitors_2) { fr_monitors_2(); }
		else if (myState == States.fr_cabinets_2) { fr_cabinets_2(); }
		else if (myState == States.fr_mummy_2) { fr_mummy_2(); }
		else if (myState == States.fr_trash_2) { fr_trash_2(); }

		//State 3
		else if (myState == States.finalroom_3) { finalroom_3(); }
		else if (myState == States.fr_beast_3) { fr_beast_3(); }
		else if (myState == States.fr_scientists_3) { fr_scientists_3(); }
		else if (myState == States.fr_device_3) { fr_device_3(); }
		else if (myState == States.fr_cabinets_examine) { fr_cabinets_examine(); } //---> State 4
		else if (myState == States.fr_monitors_3) { fr_monitors_3(); }
		else if (myState == States.fr_cabinets_3) { fr_cabinets_3(); }
		else if (myState == States.fr_mummy_3) { fr_mummy_3(); }
		else if (myState == States.fr_trash_3) { fr_trash_3(); }

		//State 4
		else if (myState == States.finalroom_4) { finalroom_4(); }
		else if (myState == States.fr_beast_4) { fr_beast_4(); }
		else if (myState == States.fr_scientists_4) { fr_scientists_4(); }
		else if (myState == States.fr_device_4) { fr_device_4(); }
		else if (myState == States.fr_trash_examine) { fr_trash_examine(); } //---> State 5
		else if (myState == States.fr_monitors_4) { fr_monitors_4(); }
		else if (myState == States.fr_cabinets_4) { fr_cabinets_4(); }
		else if (myState == States.fr_mummy_4) { fr_mummy_4(); }
		else if (myState == States.fr_trash_4) { fr_trash_4(); }

		//State 5
		else if (myState == States.finalroom_5) { finalroom_5(); }
		else if (myState == States.fr_beast_5) { fr_beast_5(); }
		else if (myState == States.fr_scientists_5) { fr_scientists_5(); }
		else if (myState == States.fr_device_5) { fr_device_5(); }
		else if (myState == States.fr_mummy_examine) { fr_mummy_examine(); } //---> State 6
		else if (myState == States.fr_monitors_5) { fr_monitors_5(); }
		else if (myState == States.fr_cabinets_5) { fr_cabinets_5(); }
		else if (myState == States.fr_mummy_5) { fr_mummy_5(); }
		else if (myState == States.fr_trash_5) { fr_trash_5(); }

		//State 6
		else if (myState == States.finalroom_6) { finalroom_6(); }
		else if (myState == States.fr_beast_6) { fr_beast_6(); }
		else if (myState == States.fr_scientists_6) { fr_scientists_6(); }
		else if (myState == States.fr_device_6) { fr_device_6(); }
		else if (myState == States.fr_device_examineb) { fr_device_examineb(); } //---> State 7
		else if (myState == States.fr_monitors_6) { fr_monitors_6(); }
		else if (myState == States.fr_cabinets_6) { fr_cabinets_6(); }
		else if (myState == States.fr_mummy_6) { fr_mummy_6(); }
		else if (myState == States.fr_trash_6) { fr_trash_6(); }

		//State 7
		else if (myState == States.finalroom_7) { finalroom_7(); }
		else if (myState == States.fr_beast_7) { fr_beast_7(); }
		else if (myState == States.fr_scientists_7) { fr_scientists_7(); }
		else if (myState == States.fr_device_7) { fr_device_7(); }
		else if (myState == States.fr_monitors_examineb) { fr_monitors_examineb(); } //---> State 8
		else if (myState == States.fr_monitors_7) { fr_monitors_7(); }
		else if (myState == States.fr_cabinets_7) { fr_cabinets_7(); }
		else if (myState == States.fr_mummy_7) { fr_mummy_7(); }
		else if (myState == States.fr_trash_7) { fr_trash_7(); }

		//State 8
		else if (myState == States.finalroom_8) { finalroom_8(); }
		else if (myState == States.fr_beast_8) { fr_beast_8(); }
		else if (myState == States.fr_scientists_8) { fr_scientists_8(); }
		else if (myState == States.fr_device_8) { fr_device_8(); }
		else if (myState == States.fr_device_operate) { fr_device_operate(); } //---> State 9
		else if (myState == States.fr_monitors_8) { fr_monitors_8(); }
		else if (myState == States.fr_cabinets_8) { fr_cabinets_8(); }
		else if (myState == States.fr_mummy_8) { fr_mummy_8(); }
		else if (myState == States.fr_trash_8) { fr_trash_8(); }

		//State 9
		else if (myState == States.finalroom_9) { finalroom_9(); }
		else if (myState == States.fr_beast_9) { fr_beast_9(); }
		else if (myState == States.fr_scientists_9) { fr_scientists_9(); }
		else if (myState == States.fr_device_9) { fr_device_9(); }
		else if (myState == States.fr_freedom) { fr_freedom(); } //---> State 10
		else if (myState == States.fr_monitors_9) { fr_monitors_9(); }
		else if (myState == States.fr_cabinets_9) { fr_cabinets_9(); }
		else if (myState == States.fr_mummy_9) { fr_mummy_9(); }
		else if (myState == States.fr_trash_9) { fr_trash_9(); }

	}


	//___________________________________________STATE_0____________________________________________________________________


	//Every state is a separate void
	void finalroom_0a()
	{
		text.text = "As you enter the room, you are immediately assaulted by the incredibly stuffy " +
			"air inside.  the door behind you slowly closes and you can hear a " +
			"faint clicking noise as it locks up completely. " +
			"There seems to be a hulking mass of partially-transparent goo in the very back of " +
			"the room. Due to the murky air, you can hardly make it out but it's there. Judging " +
			"by the several corpses it’s… Consuming, it can’t have been here for " +
			"long. Lucky for you, it hasn’t noticed you enter and the several sounds don’t seem to " +
			"faze it." +
			"\n\n" +
			"In the middle of the room you see a large device mounted on a supporting platform. In " +
			"the far end of the room you see the massive pile of odd biomass alongside several bodies " +
			"of former scientists. On your left, you can see a couple computer monitors wired to the " +
			"platform in the middle of the room and some cabinets. On your right, there is yet another " +
			"mummified scientist. You can’t figure out why the beast hadn’t finished them off. There " +
			"are also several piles of laboratory equipment spewed around."
			+ "\n\n"
			+ "Press [1] to examine the beast."
			+ "\n"
			+ "Press [2] to examine the corpses."
			+ "\n"
			+ "Press [3] to examine the device."
			+ "\n"
			+ "Press [4] to examine the monitors."
			+ "\n"
			+ "Press [5] to examine the cabinets."
			+ "\n"
			+ "Press [6] to examine the mummy."
			+ "\n"
			+ "Press [7] to examine the piles of trash.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_beast_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.fr_scientists_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.fr_device_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.fr_monitors_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.fr_cabinets_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.fr_mummy_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) { myState = States.fr_trash_0; }
	}

	void fr_beast_0()
	{
		text.text = "Upon closer inspection, you can see some parts of flesh and bone ‘swimming’ " +
			"around inside the massive being’s body. Resisting the urge to vomit, you focus your " +
			"mind elsewhere. Looks like you’re going to have to get past it somehow."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_1; };
	}

	void fr_scientists_0()
	{
		text.text = "None of them are alive anymore and the beast is going to town consuming the " +
			"remaining bodies. You’re going to have to hurry before it notices you and continues " +
			"its feast."
			+"\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_0b; }
	}

	void fr_device_0()
	{
		text.text = "You have no idea what the device is meant for. It’s way too heavy to lug " +
			"around, so it must be an experiment the researchers here were tending to before all " +
			"this."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_0b; }
	}

	void fr_monitors_0()
	{
		text.text = "The computer monitor is completely black although it seems to be on. One " +
			"could assume it would be pretty unlikely that this kind of equipment would last " +
			"ordeals like the rampaging biomass traversing through the facility, wrecking the " +
			"place in the process."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_0b; }
	}

	void fr_cabinets_0()
	{
		text.text = "You open up each of the cabinets in hopes of finding something to get rid of " +
			"the biomass covering your escape. Fat chance. Everything inside is just some scientific " +
			"junk."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_0b; }
	}

	void fr_mummy_0()
	{
		text.text = "Yet another unfortunate victim. Poor fellow couldn’t stand a chance, and " +
			"neither will you unless you get rid of the beast and quick. This scientist doesn’t " +
			"even seem to be fully covered in the substance, but just enough to prevent movement."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_0b; }
	}

	void fr_trash_0()
	{
		text.text = "There is some scientific equipment strewn across the room. Looks like the " +
			"people here just dropped whatever they were holding when the shit hit the fan."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_0b; }
	}

	void finalroom_0b()
	{
		text.text = "You are in a room the purpose of which seems to be testing some odd devices. " +
			"For now, however, it’s practically halfway-filled with a pile of biomass busy ingesting " +
			"some poor researchers." +
			"\n\n" +
			"In the middle of the room you see a large device mounted on a supporting platform. In " +
			"the far end of the room you see the massive pile of odd biomass alongside several bodies " +
			"of former scientists. On your left, you can see a couple computer monitors wired to the " +
			"platform in the middle of the room and some cabinets. On your right, there is yet another " +
			"mummified scientist. You can’t figure out why the beast hadn’t finished them off. There " +
			"are also several piles of laboratory equipment spewed around."
			+ "\n\n"
			+ "Press [1] to examine the beast."
			+ "\n"
			+ "Press [2] to examine the corpses."
			+ "\n"
			+ "Press [3] to examine the device."
			+ "\n"
			+ "Press [4] to examine the monitors."
			+ "\n"
			+ "Press [5] to examine the cabinets."
			+ "\n"
			+ "Press [6] to examine the mummy."
			+ "\n"
			+ "Press [7] to examine the piles of trash.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_beast_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.fr_scientists_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.fr_device_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.fr_monitors_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.fr_cabinets_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.fr_mummy_0; }
		else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) { myState = States.fr_trash_0; }
	}

	//___________________________________________STATE_1____________________________________________________________________


	void finalroom_1()
	{
		text.text = "You are in a room the purpose of which seems to be testing some odd devices. " +
			"For now, however, it’s practically halfway-filled with a pile of biomass busy ingesting " +
			"some poor researchers." +
			"\n\n" +
			"In the middle of the room you see a large device mounted on a supporting platform. In " +
			"the far end of the room you see the massive pile of odd biomass alongside several bodies " +
			"of former scientists. On your left, you can see a couple computer monitors wired to the " +
			"platform in the middle of the room and some cabinets. On your right, there is yet another " +
			"mummified scientist. You can’t figure out why the beast hadn’t finished them off. There " +
			"are also several piles of laboratory equipment spewed around."
			+ "\n\n"
			+ "Press [1] to examine the beast."
			+ "\n"
			+ "Press [2] to examine the corpses."
			+ "\n"
			+ "Press [3] to examine the device."
			+ "\n"
			+ "Press [4] to examine the monitors."
			+ "\n"
			+ "Press [5] to examine the cabinets."
			+ "\n"
			+ "Press [6] to examine the mummy."
			+ "\n"
			+ "Press [7] to examine the piles of trash.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_beast_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.fr_scientists_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.fr_device_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.fr_monitors_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.fr_cabinets_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.fr_mummy_1; }
		else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) { myState = States.fr_trash_1; }
	}

	void fr_beast_1()
	{
		text.text = "Upon closer inspection, you can see some parts of flesh and bone ‘swimming’ " +
			"around inside the massive being’s body. Resisting the urge to vomit, you focus your " +
			"mind elsewhere. Looks like you’re going to have to get past it somehow."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_1; };
	}

	void fr_scientists_1()
	{
		text.text = "None of them are alive anymore and the beast is going to town consuming the " +
			"remaining bodies. You’re going to have to hurry before it notices you and continues " +
			"its feast."
			+"\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_1; }
	}

	void fr_device_1()
	{
		text.text = "You have no idea what the device is meant for. It’s way too heavy to lug " +
			"around, so it must be an experiment the researchers here were tending to before all " +
			"this."
			+ "\n\n"
			+ "Press [1] to examine the device further."
			+ "\n"
			+ "Press [2] to go back.";
			if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_device_examinea; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.finalroom_1; }
	}

	void fr_device_examinea()
	{
			text.text = "There is some wiring going in and out of the platform the device is on. " +
				"Looks like it’s leading towards the computers and their monitors. Maybe they " +
				"have some more information about this?"
				+ "\n\n"
				+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_2; }
	}

	void fr_monitors_1()
	{
		text.text = "The computer monitor is completely black although it seems to be on. One " +
			"could assume it would be pretty unlikely that this kind of equipment would last " +
			"ordeals like the rampaging biomass traversing through the facility, wrecking the " +
			"place in the process."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_1; }
	}

	void fr_cabinets_1()
	{
		text.text = "You open up each of the cabinets in hopes of finding something to get rid of " +
			"the biomass covering your escape. Fat chance. Everything inside is just some scientific " +
			"junk."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_1; }
	}

	void fr_mummy_1()
	{
		text.text = "Yet another unfortunate victim. Poor fellow couldn’t stand a chance, and " +
			"neither will you unless you get rid of the beast and quick. This scientist doesn’t " +
			"even seem to be fully covered in the substance, but just enough to prevent movement."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_1; }
	}

	void fr_trash_1()
	{
		text.text = "There is some scientific equipment strewn across the room. Looks like the " +
			"people here just dropped whatever they were holding when the shit hit the fan."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_1; }
	}

	//___________________________________________STATE_2____________________________________________________________________


	void finalroom_2()
	{
		text.text = "You are in a room the purpose of which seems to be testing some odd devices. " +
			"For now, however, it’s practically halfway-filled with a pile of biomass busy ingesting " +
			"some poor researchers." +
			"\n\n" +
			"In the middle of the room you see a large device mounted on a supporting platform. In " +
			"the far end of the room you see the massive pile of odd biomass alongside several bodies " +
			"of former scientists. On your left, you can see a couple computer monitors wired to the " +
			"platform in the middle of the room and some cabinets. On your right, there is yet another " +
			"mummified scientist. You can’t figure out why the beast hadn’t finished them off. There " +
			"are also several piles of laboratory equipment spewed around."
			+ "\n\n"
			+ "Press [1] to examine the beast."
			+ "\n"
			+ "Press [2] to examine the corpses."
			+ "\n"
			+ "Press [3] to examine the device."
			+ "\n"
			+ "Press [4] to examine the monitors."
			+ "\n"
			+ "Press [5] to examine the cabinets."
			+ "\n"
			+ "Press [6] to examine the mummy."
			+ "\n"
			+ "Press [7] to examine the piles of trash.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_beast_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.fr_scientists_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.fr_device_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.fr_monitors_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.fr_cabinets_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.fr_mummy_2; }
		else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) { myState = States.fr_trash_2; }
	}

	void fr_beast_2()
	{
		text.text = "Upon closer inspection, you can see some parts of flesh and bone ‘swimming’ " +
			"around inside the massive being’s body. Resisting the urge to vomit, you focus your " +
			"mind elsewhere. Looks like you’re going to have to get past it somehow."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_2; };
	}

	void fr_scientists_2()
	{
		text.text = "None of them are alive anymore and the beast is going to town consuming the " +
			"remaining bodies. You’re going to have to hurry before it notices you and continues " +
			"its feast."
			+"\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_2; }
	}

	void fr_device_2()
	{
		text.text = "You have no idea what the device is meant for. It’s way too heavy to lug " +
			"around, so it must be an experiment the researchers here were tending to before all " +
			"this."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_2; }
	}

	void fr_monitors_examinea()
	{
		text.text = "Examining more closely, you notice a computer mouse stuck upside down " +
			"behind the computer monitor. After turning it around and giving it a flick, the " +
			"monitor in front of you lights up. Who would have known it was just in sleep " +
			"mode? Nonetheless, the computer explains the device is an experimental weapon. " +
			"To put it simply, it’s definitely going to be more than enough fire power to " +
			"get rid of the biomass. The only problem is, the device wasn’t finished and " +
			"you can’t even be sure whether it works or not. Still, better than nothing. " +
			"The monitor is showing you need a couple missing gears. Your best bet is to " +
			"look around the room."
		+ "\n\n"
		+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_3; }
	}

	void fr_monitors_2()
	{
		text.text = "The computer monitor is completely black although it seems to be on. One " +
			"could assume it would be pretty unlikely that this kind of equipment would last " +
			"ordeals like the rampaging biomass traversing through the facility, wrecking the " +
			"place in the process."
			+ "\n\n"
			+ "Press [1] to examine the table the monitors are on."
			+ "\n"
			+ "Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_monitors_examinea; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.finalroom_2; }
	}

	void fr_cabinets_2()
	{
		text.text = "You open up each of the cabinets in hopes of finding something to get rid of " +
			"the biomass covering your escape. Fat chance. Everything inside is just some scientific " +
			"junk."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_2; }
	}

	void fr_mummy_2()
	{
		text.text = "Yet another unfortunate victim. Poor fellow couldn’t stand a chance, and " +
			"neither will you unless you get rid of the beast and quick. This scientist doesn’t " +
			"even seem to be fully covered in the substance, but just enough to prevent movement."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_2; }
	}

	void fr_trash_2()
	{
		text.text = "There is some scientific equipment strewn across the room. Looks like the " +
			"people here just dropped whatever they were holding when the shit hit the fan."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_2; }
	}


	//___________________________________________STATE_3____________________________________________________________________


		void finalroom_3()
		{
			text.text = "You are in a room the purpose of which seems to be testing some odd devices. " +
				"For now, however, it’s practically halfway-filled with a pile of biomass busy ingesting " +
				"some poor researchers." +
				"\n\n" +
				"In the middle of the room you see a large device mounted on a supporting platform. In " +
				"the far end of the room you see the massive pile of odd biomass alongside several bodies " +
				"of former scientists. On your left, you can see a couple computer monitors wired to the " +
				"platform in the middle of the room and some cabinets. On your right, there is yet another " +
				"mummified scientist. You can’t figure out why the beast hadn’t finished them off. There " +
				"are also several piles of laboratory equipment spewed around."
				+ "\n\n"
				+ "Press [1] to examine the beast."
				+ "\n"
				+ "Press [2] to examine the corpses."
				+ "\n"
				+ "Press [3] to examine the device."
				+ "\n"
				+ "Press [4] to examine the monitors."
				+ "\n"
				+ "Press [5] to examine the cabinets."
				+ "\n"
				+ "Press [6] to examine the mummy."
				+ "\n"
				+ "Press [7] to examine the piles of trash.";
			if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_beast_3; }
			else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.fr_scientists_3; }
			else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.fr_device_3; }
			else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.fr_monitors_3; }
			else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.fr_cabinets_3; }
			else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.fr_mummy_3; }
			else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) { myState = States.fr_trash_3; }
		}

		void fr_beast_3()
		{
			text.text = "Upon closer inspection, you can see some parts of flesh and bone ‘swimming’ " +
				"around inside the massive being’s body. Resisting the urge to vomit, you focus your " +
				"mind elsewhere. Looks like you’re going to have to get past it somehow."
				+ "\n\n"
				+ "Press [1] to go back.";
			if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_3; };
		}

		void fr_scientists_3()
		{
			text.text = "None of them are alive anymore and the beast is going to town consuming the " +
				"remaining bodies. You’re going to have to hurry before it notices you and continues " +
				"its feast."
				+"\n\n"
				+ "Press [1] to go back.";
			if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_3; }
		}

		void fr_device_3()
		{
			text.text = "According to the files on the computer, this device is a weapon of some kind. Judging " +
				"by the size of it, it must pack some serious firepower. You almost can’t wait to " +
				"blast the biomass with it."
				+ "\n\n"
				+ "Press [1] to go back.";
			if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_3; }
		}

		void fr_cabinets_examine()
		{
			text.text = "You examine the contents of the cabinet more closely and manage to notice " +
				"some small gears lying underneath a metal sheet. You quickly take the gears and " +
				"shuffle back to the device to insert them into their respective sockets. Luckily " +
				"the researchers made the proper sockets obvious enough for you. As soon as the " +
				"last gear was set in its place, the computer monitor makes a faint beeping noise. " +
				"Now it’s saying it needs a large chain. Better get to work."
				+ "\n\n"
				+ "Press [1] to go back.";
			if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_4; }
		}

		void fr_monitors_3()
		{
			text.text = "After you skilfully managed to bring the monitor back alive, it’s showing " +
				"some odd blueprints of the device and a small flashing text. The text reads that " +
				"in order to repair the device you need some gears."
				+ "\n\n"
				+ "Press [1] to go back.";
			if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_3; }
		}

		void fr_cabinets_3()
		{
			text.text = "You open up each of the cabinets in hopes of finding something to get rid of " +
				"the biomass covering your escape. Fat chance. Everything inside is just some scientific " +
				"junk."
				+ "\n\n"
				+ "Press [1] to search them more thoroughly."
				+ "\n"
				+ "Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_cabinets_examine; }
			else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.finalroom_3; }
		}

		void fr_mummy_3()
		{
			text.text = "Yet another unfortunate victim. Poor fellow couldn’t stand a chance, and " +
				"neither will you unless you get rid of the beast and quick. This scientist doesn’t " +
				"even seem to be fully covered in the substance, but just enough to prevent movement."
				+ "\n\n"
				+ "Press [1] to go back.";
			if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_3; }
		}

		void fr_trash_3()
		{
			text.text = "There is some scientific equipment strewn across the room. Looks like the " +
				"people here just dropped whatever they were holding when the shit hit the fan."
				+ "\n\n"
				+ "Press [1] to go back.";
			if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_3; }
		}


	//___________________________________________STATE_4____________________________________________________________________


		void finalroom_4()
		{
			text.text = "You are in a room the purpose of which seems to be testing some odd devices. " +
				"For now, however, it’s practically halfway-filled with a pile of biomass busy ingesting " +
				"some poor researchers." +
				"\n\n" +
				"In the middle of the room you see a large device mounted on a supporting platform. In " +
				"the far end of the room you see the massive pile of odd biomass alongside several bodies " +
				"of former scientists. On your left, you can see a couple computer monitors wired to the " +
				"platform in the middle of the room and some cabinets. On your right, there is yet another " +
				"mummified scientist. You can’t figure out why the beast hadn’t finished them off. There " +
				"are also several piles of laboratory equipment spewed around."
				+ "\n\n"
				+ "Press [1] to examine the beast."
				+ "\n"
				+ "Press [2] to examine the corpses."
				+ "\n"
				+ "Press [3] to examine the device."
				+ "\n"
				+ "Press [4] to examine the monitors."
				+ "\n"
				+ "Press [5] to examine the cabinets."
				+ "\n"
				+ "Press [6] to examine the mummy."
				+ "\n"
				+ "Press [7] to examine the piles of trash.";
			if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_beast_4; }
			else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.fr_scientists_4; }
			else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.fr_device_4; }
			else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.fr_monitors_4; }
			else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.fr_cabinets_4; }
			else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.fr_mummy_4; }
			else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) { myState = States.fr_trash_4; }
		}

		void fr_beast_4()
		{
			text.text = "Upon closer inspection, you can see some parts of flesh and bone ‘swimming’ " +
				"around inside the massive being’s body. Resisting the urge to vomit, you focus your " +
				"mind elsewhere. Looks like you’re going to have to get past it somehow."
				+ "\n\n"
				+ "Press [1] to go back.";
			if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_4; };
		}

		void fr_scientists_4()
		{
			text.text = "None of them are alive anymore and the beast is going to town consuming the " +
				"remaining bodies. You’re going to have to hurry before it notices you and continues " +
				"its feast."
				+"\n\n"
				+ "Press [1] to go back.";
			if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_4; }
		}

		void fr_device_4()
		{
			text.text = "According to the files on the computer, this device is a weapon of some kind. Judging " +
				"by the size of it, it must pack some serious firepower. You almost can’t wait to " +
				"blast the biomass with it."
				+ "\n\n"
				+ "Press [1] to go back.";
			if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_4; }
		}

		void fr_trash_examine()
		{
			text.text = "You shuffle through the garbage but don’t find a chain of any kind. As you’re " +
				"about to lose hope, an idea pops into your head. Combining some of the rags, which " +
				"presumably came from the beast’s victims’ clothes you effectively craft a makeshift " +
				"‘chain’. You slip the rags on some wheels on the device and the computer beeps once " +
				"again. This time it isn’t asking for any more parts, but rather a key card. Lucky for " +
				"you, there’s a good chance you already know where to obtain one."
				+ "\n\n"
				+ "Press [1] to go back.";
			if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_5; }
		}

		void fr_monitors_4()
		{
			text.text = "After you skilfully managed to bring the monitor back alive, it’s showing some " +
				"odd blueprints of the device and a small flashing text. The text reads that in order to " +
				"repair the device you need a large chain."
				+ "\n\n"
				+ "Press [1] to go back.";
			if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_4; }
		}

		void fr_cabinets_4()
		{
			text.text = "You open up the cabinets and rummage through them once more. There’s not " +
				"really anything of interest here anymore, however."
				+ "\n\n"
				+ "Press [1] to go back.";
			if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_4; }
		}

		void fr_mummy_4()
		{
			text.text = "Yet another unfortunate victim. Poor fellow couldn’t stand a chance, and " +
				"neither will you unless you get rid of the beast and quick. This scientist doesn’t " +
				"even seem to be fully covered in the substance, but just enough to prevent movement."
				+ "\n\n"
				+ "Press [1] to go back.";
			if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_4; }
		}

		void fr_trash_4()
		{
			text.text = "There is some scientific equipment strewn across the room. Looks like the " +
				"people here just dropped whatever they were holding when the shit hit the fan."
				+ "\n\n"
				+ "Press [1] to search more thoroughly."
				+ "\n"
				+ "Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_trash_examine; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.finalroom_4; }
		}


	//___________________________________________STATE_5____________________________________________________________________


	void finalroom_5()
	{
		text.text = "You are in a room the purpose of which seems to be testing some odd devices. " +
			"For now, however, it’s practically halfway-filled with a pile of biomass busy ingesting " +
			"some poor researchers." +
			"\n\n" +
			"In the middle of the room you see a large device mounted on a supporting platform. In " +
			"the far end of the room you see the massive pile of odd biomass alongside several bodies " +
			"of former scientists. On your left, you can see a couple computer monitors wired to the " +
			"platform in the middle of the room and some cabinets. On your right, there is yet another " +
			"mummified scientist. You can’t figure out why the beast hadn’t finished them off. There " +
			"are also several piles of laboratory equipment spewed around."
			+ "\n\n"
			+ "Press [1] to examine the beast."
			+ "\n"
			+ "Press [2] to examine the corpses."
			+ "\n"
			+ "Press [3] to examine the device."
			+ "\n"
			+ "Press [4] to examine the monitors."
			+ "\n"
			+ "Press [5] to examine the cabinets."
			+ "\n"
			+ "Press [6] to examine the mummy."
			+ "\n"
			+ "Press [7] to examine the piles of trash.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_beast_5; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.fr_scientists_5; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.fr_device_5; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.fr_monitors_5; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.fr_cabinets_5; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.fr_mummy_5; }
		else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) { myState = States.fr_trash_5; }
	}

	void fr_beast_5()
	{
		text.text = "Upon closer inspection, you can see some parts of flesh and bone ‘swimming’ " +
			"around inside the massive being’s body. Resisting the urge to vomit, you focus your " +
			"mind elsewhere. Looks like you’re going to have to get past it somehow."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_5; };
	}

	void fr_scientists_5()
	{
		text.text = "None of them are alive anymore and the beast is going to town consuming the " +
			"remaining bodies. You’re going to have to hurry before it notices you and continues " +
			"its feast."
			+"\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_5; }
	}

	void fr_device_5()
	{
		text.text = "According to the files on the computer, this device is a weapon of some kind. Judging " +
			"by the size of it, it must pack some serious firepower. You almost can’t wait to " +
			"blast the biomass with it."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_5; }
	}

	void fr_mummy_examine()
	{
		text.text = "Sure enough, after examining the corpse more closely, you find another red key " +
			"card, similar to the one you found in the very first room you woke up in. You manage to " +
			"rip the key card off the body despite the substance partially covering the guy. You go " +
			"back to the device and slip it into a small reader on the back of it. The device comes " +
			"alive and is now quietly whirring."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_6; }
	}

	void fr_monitors_5()
	{
		text.text = "After you skilfully managed to bring the monitor back alive, it’s showing some odd " +
			"blueprints of the device and a small flashing text. The text reads that in order to operate " +
			"the device you need a key card."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_5; }
	}

	void fr_cabinets_5()
	{
		text.text = "You open up the cabinets and rummage through them once more. There’s not " +
			"really anything of interest here anymore, however."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_5; }
	}

	void fr_mummy_5()
	{
		text.text = "Yet another unfortunate victim. Poor fellow couldn’t stand a chance, and " +
			"neither will you unless you get rid of the beast and quick. This scientist doesn’t " +
			"even seem to be fully covered in the substance, but just enough to prevent movement."
			+ "\n\n"
			+ "Press [1] to examine further."
			+ "\n"
			+ "Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_mummy_examine; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.finalroom_5; }
	}

	void fr_trash_5()
	{
		text.text = "There is some scientific equipment strewn across the room. Looks like the " +
			"people here just dropped whatever they were holding when the shit hit the fan."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_5; }
	}


	//___________________________________________STATE_6____________________________________________________________________


	void finalroom_6()
	{
		text.text = "You are in a room the purpose of which seems to be testing some odd devices. " +
			"For now, however, it’s practically halfway-filled with a pile of biomass busy ingesting " +
			"some poor researchers." +
			"\n\n" +
			"In the middle of the room you see a large device mounted on a supporting platform. In " +
			"the far end of the room you see the massive pile of odd biomass alongside several bodies " +
			"of former scientists. On your left, you can see a couple computer monitors wired to the " +
			"platform in the middle of the room and some cabinets. On your right, there is yet another " +
			"mummified scientist. You can’t figure out why the beast hadn’t finished them off. There " +
			"are also several piles of laboratory equipment spewed around."
			+ "\n\n"
			+ "Press [1] to examine the beast."
			+ "\n"
			+ "Press [2] to examine the corpses."
			+ "\n"
			+ "Press [3] to examine the device."
			+ "\n"
			+ "Press [4] to examine the monitors."
			+ "\n"
			+ "Press [5] to examine the cabinets."
			+ "\n"
			+ "Press [6] to examine the mummy."
			+ "\n"
			+ "Press [7] to examine the piles of trash.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_beast_6; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.fr_scientists_6; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.fr_device_6; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.fr_monitors_6; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.fr_cabinets_6; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.fr_mummy_6; }
		else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) { myState = States.fr_trash_6; }
	}

	void fr_beast_6()
	{
		text.text = "Upon closer inspection, you can see some parts of flesh and bone ‘swimming’ " +
			"around inside the massive being’s body. Resisting the urge to vomit, you focus your " +
			"mind elsewhere. Looks like you’re going to have to get past it somehow."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_6; };
	}

	void fr_scientists_6()
	{
		text.text = "None of them are alive anymore and the beast is going to town consuming the " +
			"remaining bodies. You’re going to have to hurry before it notices you and continues " +
			"its feast."
			+"\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_6; }
	}

	void fr_device_6()
	{
		text.text = "According to the files on the computer, this device is a weapon of some kind. Judging " +
			"by the size of it, it must pack some serious firepower. You almost can’t wait to " +
			"blast the biomass with it."
			+ "\n\n"
			+ "Press [1] to use the device."
			+ "\n"
			+ "Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_device_examineb; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.finalroom_6; }
	}

	void fr_device_examineb()
	{
		text.text = "As much as you’d like to rip the hulking mass a new one, you can’t. The device is " +
			"pointed the wrong way and you stand no chance turning it around with your bare hands."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_7; }
	}

	void fr_monitors_6()
	{
		text.text = "After you skilfully managed to bring the monitor back alive, it’s showing some odd " +
			"blueprints of the device and a small flashing text. The text reads that the device is now " +
			"operable."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_6; }
	}

	void fr_cabinets_6()
	{
		text.text = "You open up the cabinets and rummage through them once more. There’s not " +
			"really anything of interest here anymore, however."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_6; }
	}

	void fr_mummy_6()
	{
		text.text = "Yet another unfortunate victim. Poor fellow couldn’t stand a chance, and " +
			"neither will you unless you get rid of the beast and quick. This scientist doesn’t " +
			"even seem to be fully covered in the substance, but just enough to prevent movement."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_6; }
	}

	void fr_trash_6()
	{
		text.text = "There is some scientific equipment strewn across the room. Looks like the " +
			"people here just dropped whatever they were holding when the shit hit the fan."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_6; }
	}


	//___________________________________________STATE_7____________________________________________________________________


	void finalroom_7()
	{
		text.text = "You are in a room the purpose of which seems to be testing some odd devices. " +
			"For now, however, it’s practically halfway-filled with a pile of biomass busy ingesting " +
			"some poor researchers." +
			"\n\n" +
			"In the middle of the room you see a large device mounted on a supporting platform. In " +
			"the far end of the room you see the massive pile of odd biomass alongside several bodies " +
			"of former scientists. On your left, you can see a couple computer monitors wired to the " +
			"platform in the middle of the room and some cabinets. On your right, there is yet another " +
			"mummified scientist. You can’t figure out why the beast hadn’t finished them off. There " +
			"are also several piles of laboratory equipment spewed around."
			+ "\n\n"
			+ "Press [1] to examine the beast."
			+ "\n"
			+ "Press [2] to examine the corpses."
			+ "\n"
			+ "Press [3] to examine the device."
			+ "\n"
			+ "Press [4] to examine the monitors."
			+ "\n"
			+ "Press [5] to examine the cabinets."
			+ "\n"
			+ "Press [6] to examine the mummy."
			+ "\n"
			+ "Press [7] to examine the piles of trash.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_beast_7; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.fr_scientists_7; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.fr_device_7; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.fr_monitors_7; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.fr_cabinets_7; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.fr_mummy_7; }
		else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) { myState = States.fr_trash_7; }
	}

	void fr_beast_7()
	{
		text.text = "Upon closer inspection, you can see some parts of flesh and bone ‘swimming’ " +
			"around inside the massive being’s body. Resisting the urge to vomit, you focus your " +
			"mind elsewhere. Looks like you’re going to have to get past it somehow."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_7; };
	}

	void fr_scientists_7()
	{
		text.text = "None of them are alive anymore and the beast is going to town consuming the " +
			"remaining bodies. You’re going to have to hurry before it notices you and continues " +
			"its feast."
			+"\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_7; }
	}

	void fr_device_7()
	{
		text.text = "According to the files on the computer, this device is a weapon of some kind. Judging " +
			"by the size of it, it must pack some serious firepower. You almost can’t wait to " +
			"blast the biomass with it."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_7; }
	}

	void fr_monitors_examineb()
	{
		text.text = "In the corner of the screen, you see two arrows indicating the directions you can turn " +
			"the device towards. After clicking the right arrow the device slowly and surprisingly silently " +
			"turns towards the biomass. Next is the fun part."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_8; }
	}

	void fr_monitors_7()
	{
		text.text = "After you skilfully managed to bring the monitor back alive, it’s showing some odd " +
			"blueprints of the device and a small flashing text. The text reads that the device is now " +
			"operable."
			+ "\n\n"
			+ "Press [1] to examine the monitors further."
			+ "\n"
			+ "Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_monitors_examineb; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.finalroom_7; }
	}

	void fr_cabinets_7()
	{
		text.text = "You open up the cabinets and rummage through them once more. There’s not " +
			"really anything of interest here anymore, however."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_7; }
	}

	void fr_mummy_7()
	{
		text.text = "Yet another unfortunate victim. Poor fellow couldn’t stand a chance, and " +
			"neither will you unless you get rid of the beast and quick. This scientist doesn’t " +
			"even seem to be fully covered in the substance, but just enough to prevent movement."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_7; }
	}

	void fr_trash_7()
	{
		text.text = "There is some scientific equipment strewn across the room. Looks like the " +
			"people here just dropped whatever they were holding when the shit hit the fan."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_7; }
	}


	//___________________________________________STATE_8____________________________________________________________________


	void finalroom_8()
	{
		text.text = "You are in a room the purpose of which seems to be testing some odd devices. " +
			"For now, however, it’s practically halfway-filled with a pile of biomass busy ingesting " +
			"some poor researchers." +
			"\n\n" +
			"In the middle of the room you see a large device mounted on a supporting platform. In " +
			"the far end of the room you see the massive pile of odd biomass alongside several bodies " +
			"of former scientists. On your left, you can see a couple computer monitors wired to the " +
			"platform in the middle of the room and some cabinets. On your right, there is yet another " +
			"mummified scientist. You can’t figure out why the beast hadn’t finished them off. There " +
			"are also several piles of laboratory equipment spewed around."
			+ "\n\n"
			+ "Press [1] to examine the beast."
			+ "\n"
			+ "Press [2] to examine the corpses."
			+ "\n"
			+ "Press [3] to examine the device."
			+ "\n"
			+ "Press [4] to examine the monitors."
			+ "\n"
			+ "Press [5] to examine the cabinets."
			+ "\n"
			+ "Press [6] to examine the mummy."
			+ "\n"
			+ "Press [7] to examine the piles of trash.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_beast_8; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.fr_scientists_8; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.fr_device_8; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.fr_monitors_8; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.fr_cabinets_8; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.fr_mummy_8; }
		else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) { myState = States.fr_trash_8; }
	}

	void fr_beast_8()
	{
		text.text = "Upon closer inspection, you can see some parts of flesh and bone ‘swimming’ " +
			"around inside the massive being’s body. Resisting the urge to vomit, you focus your " +
			"mind elsewhere. Looks like you’re going to have to get past it somehow."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_8; };
	}

	void fr_scientists_8()
	{
		text.text = "None of them are alive anymore and the beast is going to town consuming the " +
			"remaining bodies. You’re going to have to hurry before it notices you and continues " +
			"its feast."
			+"\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_8; }
	}

	void fr_device_8()
	{
		text.text = "According to the files on the computer, this device is a weapon of some kind. Judging " +
			"by the size of it, it must pack some serious firepower. You almost can’t wait to " +
			"blast the biomass with it."
			+ "\n\n"
			+ "Press [1] to use the device."
			+ "\n"
			+ "Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_device_operate; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.finalroom_8; }
	}

	void fr_device_operate()
	{
		text.text = "You almost gleefully press the green button next to the card reader on the back of the " +
			"device and immediately take cover behind the cabinets and close your eyes and plug " +
			"your ears. The device bursts into life and a large ball of light can be seen forming in front " +
			"of the nozzle. What comes after is a roaring sound of what could only be described as lightning " +
			"as a massive ray of light erupts and pierces the biomass which in turn screeches in pain. After " +
			"a short while, the support of the device gives in and the whole shebang flies back into – and " +
			"through – the back wall, all while the beam of light continues to pierce the walls and roof " +
			"while at it." +
			"\n\n" +
			"Eventually, the wiring runs out and snaps, effectively stopping the ungodly noise. You open " +
			"your eyes and rise up only to see there’s merely a wet stain and smoke remaining of the biomass. " +
			"Looking around the room, you see practically everything is wrecked and the room was basically " +
			"cut in half by the powerful laser as it flipped and flew through the whole facility. On the plus " +
			"side, you’re alive and the way out is now pretty much open."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_9; }
	}

	void fr_monitors_8()
	{
		text.text = "After you skilfully managed to bring the monitor back alive, it’s showing some odd " +
			"blueprints of the device and a small flashing text. The text reads that the device is now " +
			"operable."
			+ "\n\n"
			+ "Press [1] to examine the monitors further."
			+ "\n"
			+ "Press [2] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_monitors_examineb; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.finalroom_8; }
	}

	void fr_cabinets_8()
	{
		text.text = "You open up the cabinets and rummage through them once more. There’s not " +
			"really anything of interest here anymore, however."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_8; }
	}

	void fr_mummy_8()
	{
		text.text = "Yet another unfortunate victim. Poor fellow couldn’t stand a chance, and " +
			"neither will you unless you get rid of the beast and quick. This scientist doesn’t " +
			"even seem to be fully covered in the substance, but just enough to prevent movement."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_8; }
	}

	void fr_trash_8()
	{
		text.text = "There is some scientific equipment strewn across the room. Looks like the " +
			"people here just dropped whatever they were holding when the shit hit the fan."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_8; }
	}


	//___________________________________________STATE_9____________________________________________________________________


	void finalroom_9()
	{
		text.text = "You are standing in a room formerly designed for testing purposes of a very powerful weapon. " +
			"Thing is, after you so excitedly decided to fix the device and eventually wreak havoc, the place " +
			"seems almost leveled now."
			+ "\n\n"
			+ "Looking around, you can see whatever remains of the beast. A smoking stain more or less. Some of " +
				"the former researchers are still in pieces, probably a bit more after what happened. What's left " +
				"of the device isn't much. There are only a couple girders sticking out of the floor where it used " +
				"to be. The device itself probably flew right through the entire facility while it was still on " +
				"and just about cut everything in its path. The monitors are in horrible shape, as expected. The " +
				"cabinets as well. The mummy is still there, completely untouched as it so happens, which is a bit " +
				"weird. As for all of the scientific equipment laying about... Well there's now way more of it alongside " +
				"several pieces of the facility's structural parts."
			+ "\n\n"
			+ "Press [1] to examine the beast."
			+ "\n"
			+ "Press [2] to examine the corpses."
			+ "\n"
			+ "Press [3] to examine the device."
			+ "\n"
			+ "Press [4] to examine the monitors."
			+ "\n"
			+ "Press [5] to examine the cabinets."
			+ "\n"
			+ "Press [6] to examine the mummy."
			+ "\n"
			+ "Press [7] to examine the piles of trash."
			+ "\n"
			+ "Press [8] to step through the gaping hole in the wall.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.fr_beast_9; }
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.fr_scientists_9; }
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.fr_device_9; }
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.fr_monitors_9; }
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) { myState = States.fr_cabinets_9; }
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) { myState = States.fr_mummy_9; }
		else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) { myState = States.fr_trash_9; }
		else if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)) { myState = States.fr_freedom; }
	}

	void fr_beast_9()
	{
		text.text = "There’s nothing left of it. Nothing to see here anymore."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_9; };
	}

	void fr_scientists_9()
	{
		text.text = "Some odd bits of the corpses of researchers are still around, but there’s not exactly " +
			"anything you’d want to do with those."
			+"\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_9; }
	}

	void fr_device_9()
	{
		text.text = "What device? The fucking thing probably flew a mile backwards while it was still on, " +
			"piercing basically anything in front of it."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_9; }
	}

	void fr_freedom()
	{
		text.text = "You step through the hole and you find yourself in another hallway. Judging by the opposite " +
		"wall and the dark bedrock behind it you find that the facility seems to be located underground for some " +
		"reason. As you look to your right and left, you see an elevator and after stepping in, you immediately " +
		"press the topmost button. The elevator makes a slightly pained sound as the bent metal parts of itself and " +
		"presumably even the elevator shaft grind against each other. Still, the power is still on and the thing " +
		"slowly makes its way upwards." +
		"\n\n" +
		"As the elevator opens, you find yourself in a small shack, with walls made out of rotten wood and the " +
		"roof seeming built hastily from rusty corrugated metal. The front door is some more sheet metal, which " +
		"immediately gives in and falls forward as you touch it, revealing the view behind it." +
		"\n\n" +
		"Miles and miles of barren wasteland stretches before you. There is no vegetation apart from the odd dead " +
		"tree and the ground is gray like ash. Stunned, you take a few steps forward and fall to your knees as tears " +
		"start to well up under your eyes. You dig your fingers in the ashy soil and watch as it escapes your " +
		"grasp when you raise your hands back up. As the sun begins to set, your vision also starts to get blurry " +
		"and rather fast at that. You collapse face first into the ash." +
		"\n\n" +
		"Press [1] to start over.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { Application.LoadLevel(0); }
        
    }

	void fr_monitors_9()
	{
		text.text = "The monitors are no longer displaying anything. Looks like the computers broke while the " +
			"climax was happening."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_9; }
	}

	void fr_cabinets_9()
	{
		text.text = "There’s nothing else in the cabinets beside the junk that was there to begin with. Nothing " +
			"to see here."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_9; }
	}

	void fr_mummy_9()
	{
		text.text = "You probably went partially blind after seeing the laser whizz by, but you could swear that " +
			"this mummy is sort of smiling now."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_9; }
	}

	void fr_trash_9()
	{
		text.text = "The cleaners are not going to be happy. The place is in at least a hundred times worse mess " +
			"now. There’s all sorts of garbage everywhere."
			+ "\n\n"
			+ "Press [1] to go back.";
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.finalroom_9; }
	}

}