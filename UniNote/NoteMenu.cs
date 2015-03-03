using UnityEngine;
using System.Collections;
using UnityEditor;

public class NoteMenu 
{
	[MenuItem ("Component/Note")]
	public static void addNote()
	{
		if(Selection.activeTransform != null)
		{
			Selection.activeGameObject.AddComponent(typeof(Note));
		}
	}
}
