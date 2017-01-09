using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Entity_RarityData : ScriptableObject
{	
	public List<Param> param = new List<Param> ();

	[System.SerializableAttribute]
	public class Param
	{
		
		public int ID;
		public string RarityData;
		public int RarityHeavy;
	}
}