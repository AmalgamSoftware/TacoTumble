using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SpawnEventType{pickup,affector,tip,wait};
public class EventNode{
	//frame offset
	public int timeOff;
	//type of spawn event
	public SpawnEventType eventType;
}
public class WaitNode: EventNode{
	public WaitNode(int timeo){
		timeOff = timeo;
		eventType = SpawnEventType.wait;
	}
}
public class TipNode : EventNode{
	public int tipNumber;
	public TipNode(int timeo,int tpn){
		timeOff = timeo;
		eventType = SpawnEventType.tip;
		tipNumber = tpn;
	}
}
public class AffectorNode : EventNode{
	public bool type;
	public int duration;
	//These two values should be between 0 and 1
	public float x;
	public float y;

	public AffectorNode(int time, bool typ){
		eventType = SpawnEventType.affector;
		timeOff = time;
		type = typ;
		duration = 300;
		x = Random.Range (0.05f, 0.95f);
		y = Random.Range (0.05f, 0.95f);
	}
	public AffectorNode(int time, bool typ, float _x, float _y){
		eventType = SpawnEventType.affector;
		timeOff = time;
		type = typ;
		x = _x;
		y = _y;
		duration = 300;
	}
	public AffectorNode(int time, bool typ, int dur, float _x, float _y){
		eventType = SpawnEventType.affector;
		timeOff = time;
		type = typ;
		duration = dur;
		x = _x;
		y = _y;
	} 

}
public class SpawnNode : EventNode{
	//type of pickup. 0 = beef, 1 = cheese, 2 = lettuce, 3 = sourcream, 4 = random from first 4
	// 5 = special beef, 6 = special cheese, 7 = special lettuce.
	public int type;
	//clockwise set of four possible directions
	public int direction;
	//offset in each direction. This SHOULD be between 0 and 1.
	public float offset;
	//gravity enabled? default = true
	public bool grav;
	//Spawn with all fields specified
	public SpawnNode(int time,int typ,int dir,float off){
		timeOff = time;
		type = typ;
		if (dir == 4) {
			direction = Random.Range (0, 4);
		} else {
			direction = dir;
		}
		if (off == 2f) {
			off = Random.Range (0f, 1f);
		}
		offset = off;
		eventType = SpawnEventType.pickup;
		grav = true;
	}
	//Specify gravity
	public SpawnNode(int time,int typ,int dir,float off,bool grv){
		timeOff = time;
		type = typ;
		if (dir == 4) {
			direction = Random.Range (0, 4);
		} else {
			direction = dir;
		}
		if (off == 2f) {
			off = Random.Range (0f, 1f);
		}
		offset = off;
		eventType = SpawnEventType.pickup;
		grav = grv;
	}
	//Random offset
	public SpawnNode(int time,int typ,int dir){
		timeOff = time;
		type = typ;
		if (dir == 4) {
			direction = Random.Range (0, 4);
		} else {
			direction = dir;
		}
		offset = Random.value;
		eventType = SpawnEventType.pickup;
		grav = true;
	}
	//All random, Special or Not
	public SpawnNode(int time, bool special){
		timeOff = time;
		if (special) {
			type = Random.Range (5, 8);
		} else {
			type = Random.Range (0, 4);
		}
		direction = Random.Range (0, 4);
		offset = Random.value;
		eventType = SpawnEventType.pickup;
		grav = true;
	}
}
