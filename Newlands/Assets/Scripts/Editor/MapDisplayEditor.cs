﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor (typeof (MapDisplay))]
public class MapDisplayEditor : Editor {

	MapDisplay mapDisplay;

	public override void OnInspectorGUI () {
		mapDisplay = (MapDisplay) target;

		if (DrawDefaultInspector ()) {
			if (mapDisplay.autoUpdate) {
				mapDisplay.GenerateTextureMap ();
			}
		}
		if (GUILayout.Button ("Generate Texture Map")) {
			mapDisplay.GenerateTextureMap ();
		} else if (GUILayout.Button ("Generate Mesh Map")) {
			mapDisplay.GenerateMeshMap ();
		}
	}
}