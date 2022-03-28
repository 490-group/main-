using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour {

	public GameObject[] bottomRooms;
	public GameObject[] topRooms;
	public GameObject[] leftRooms;
	public GameObject[] rightRooms;

	public GameObject closedRoom;

	public List<GameObject> rooms;

	public float waitTime;
	private bool spawnedBoss;
	public GameObject boss;
	public GameObject footgear;
	public GameObject weapon;
	public GameObject armor;
	public GameObject rings;

	void Update(){

		if(waitTime <= 0 && spawnedBoss == false){
			for (int i = 0; i < rooms.Count; i++) {
				if(i == rooms.Count-1){
					Instantiate(boss, rooms[i].transform.position, Quaternion.identity);
					boss.tag = "boss";
					spawnedBoss = true;
				}
				if(i == rooms.Count-2){
					Instantiate(footgear, rooms[i].transform.position, Quaternion.identity);
					footgear.tag = "footgear";
					
				}
				if(i == rooms.Count-3){
					Instantiate(armor, rooms[i].transform.position, Quaternion.identity);
					armor.tag = "armor";
					
				}
				if(i == rooms.Count-4){
					Instantiate(weapon, rooms[i].transform.position, Quaternion.identity);
					weapon.tag = "weapon";
					
				}
				if(i == rooms.Count-5){
					Instantiate(rings, rooms[i].transform.position, Quaternion.identity);
					rings.tag = "rings";
					
				}
			}
		} else {
			waitTime -= Time.deltaTime;
		}
	}
}
