using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemManager : MonoBehaviour {
public List<Item> inventory = new List<Item>();
private string newItemName = " ";
private string newItemCost = " ";
private string newItemDescription = " "; 

	void OnGUI(){

		newItemName = GUILayout.TextField(newItemName);
		newItemCost = GUILayout.TextField(newItemCost);
	    newItemDescription = GUILayout.TextField(newItemDescription);

		if(GUILayout.Button("Add New Item")){

			Item newItem = ScriptableObject.CreateInstance<Item>();
			newItem.name = newItemName;
			newItem.cost = System.Convert.ToInt32(newItemCost);
			newItem.description = newItemDescription; 

			inventory.Add(newItem);

		}

		if(GUILayout.Button("Add New Weapon")){
			
			Item newItem = ScriptableObject.CreateInstance<Weapon>();
			newItem.name = newItemName;
			newItem.cost = System.Convert.ToInt32(newItemCost);
			newItem.description = newItemDescription; 
			
			inventory.Add(newItem);
				
		}

		for(int i = 0; 1 < inventory.Count; i++){

			GUILayout.Label(inventory[i].name + " - " + 
			                inventory[i].description + " _ " +
			                inventory[i].cost + " _ " +
			                inventory[i].GetType());
	    
        }
	
	                                                           
	}
}



