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
	public GameObject weaponRare;
	public GameObject weaponEpic;
	public GameObject armor;
	public GameObject armorRare;
	public GameObject armorEpic;
	public GameObject rings;
	public GameObject ringsRare;
	public GameObject ringsEpic;
	public GameObject footgearRare;
	public GameObject footgearEpic;
	//public GameObject footgearEpic;
	public GameObject Enemy;


	void Update(){

		if(waitTime <= 0 && spawnedBoss == false){
			Instantiate(footgearEpic, rooms[1].transform.position, Quaternion.identity);
			footgear.tag = "footgear";
			//Instantiate(Enemy, rooms[1].transform.position, Quaternion.identity);
			//Enemy.tag = "enemy";
			Debug.Log(rooms.Count);
			int xcount = Random.Range(2, rooms.Count);
			int ycount = Random.Range(1, 3);
			int enCount = Random.Range(1,10);
			int tempVal = 1;
			for(int x = 0; x < enCount; x++){
				Instantiate(Enemy, rooms[rooms.Count-tempVal].transform.position, Quaternion.identity);
				Enemy.tag = "enemy";
				tempVal++;
			}
			if(ycount == 1){
				Instantiate(rings, rooms[xcount].transform.position, Quaternion.identity);
				rings.tag = "rings";
			}
			if(ycount == 2){
				Instantiate(armor, rooms[xcount].transform.position, Quaternion.identity);
				armor.tag = "armor";
			}
			if(ycount == 3){
				Instantiate(weapon, rooms[xcount].transform.position, Quaternion.identity);
				weapon.tag = "weapon";
			}
			for (int i = 0; i < rooms.Count; i++) {
				if(i == rooms.Count-1){
					Instantiate(boss, rooms[i].transform.position, Quaternion.identity);
					boss.tag = "boss";
					spawnedBoss = true;
				}
				/*if(i == rooms.Count-2){
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
					
				}*/
			}
		} else {
			waitTime -= Time.deltaTime;
		}
	}
}
