using UnityEngine;
using System.Collections;

[System.Serializable]
public class Item : ScriptableObject {

	public int cost = 0;
	public string name = " " ;
	public string description = " ";
	
}

[System.Serializable]
public class Weapon : Item {
	public int damage = 0;
        
}

[System.Serializable]
public class Armor : Item {
	public int denfense = 0; 
}
