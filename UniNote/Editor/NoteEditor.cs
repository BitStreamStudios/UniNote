using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(Note))]
public class NoteEditor : Editor
{
	bool editing = false;

	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();
		Note note = (Note)target;

		if(editing)
		{
			note.text = EditorGUILayout.TextField(note.text);
			if(GUILayout.Button("Done"))
				editing = false;
		}
		else
		{
			GUILayout.Label(note.text);
			if(GUILayout.Button("Edit Note"))
				editing = true;
		}

	}
}
