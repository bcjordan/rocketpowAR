﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLibrary : Singleton<AudioLibrary>
{
	[Header("Narrative Clips")]
	public AudioClip NarrativePlaceElevator;
	public AudioClip NarrativeWelcomeGreeting;
	public AudioClip NarrativeIntro;
	
	public AudioClip SpacePlacement1;

	public AudioClip SensorIntroduction1;
	public AudioClip SensorIntroduction2;
	public AudioClip SensorSet;
	public AudioClip ChosenItem;

	public AudioClip SuccessMessage;
	public AudioClip WelcomeGreeting;

	
	[Header("Narrative Minigame Clips")]
	public AudioClip ActivityInstructionA;
	public AudioClip ActivityInstructionB;
	public AudioClip ActivityInstructionC;
	
	[Header("Ambient Clips")]
	public AudioClip IndustrialSpaces;
	
	[Header("Music Clips")]
	public AudioClip SplashScreenMusic;
	public AudioClip AmbientIntro;

	[Header("Sound Effects")]
	public AudioClip ElevatorDoorOpen;
	public AudioClip TriggerSound;
	public AudioClip TorsoTransition;
	public AudioClip CrowdHospitalWaiting;
}