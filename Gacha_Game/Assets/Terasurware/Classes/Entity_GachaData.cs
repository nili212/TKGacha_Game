using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Entity_GachaData : ScriptableObject
{	
	public List<Param> param = new List<Param> ();

	[System.SerializableAttribute]
	public class Param
	{
		
		public int IdData;
		public string Name;
		public string Rarity;
		public int Heavy;
	}
}