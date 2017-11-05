using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadScript : MonoBehaviour {

	//public InstantiateCubes instantCubeScript;
	//List<GameObject> cubeList;
	//InstantiateCubes.

	Mesh mesh;
	Vector3[] vertices;
	//Matrix4x4 localToWorld;

	// Use this for initialization
	void Start () {
		//cubeList = instantCubeScript._sampleCube;
		mesh = this.GetComponent<MeshFilter>().mesh;
		vertices = mesh.vertices;
		//localToWorld = transform.localToWorldMatrix;
	}
	
	// Update is called once per frame
	void Update () {
		checkBlocks ();
	}

	//note: the pairs of vertices must match the sample number, ie 1024 must equal 1024 pairs of vertices (an edge)
	void checkBlocks() {
		for (int i = 0; i < InstantiateCubes._sampleCube.Length; i++) {

			//first vertex of edge
			//Vector3 vecPos1 = localToWorld.MultiplyPoint3x4(vertices [2*i]);
			//Vector3 newVecPos1 = new Vector3 (vecPos1.x, InstantiateCubes._sampleCube [i].transform.localScale.y, vecPos1.z);
			//vertices [2 * i] = newVecPos1;
			vertices [2*i].y = InstantiateCubes._sampleCube [i].transform.localScale.y/70;
			vertices [(2*i)+1].y = InstantiateCubes._sampleCube [i].transform.localScale.y/70;
			//Vector3 vecPos2 = localToWorld.MultiplyPoint3x4(vertices [(2*i)+1]);
			//Vector3 newVecPos2 = new Vector3 (vecPos2.x, InstantiateCubes._sampleCube [i].transform.localScale.y, vecPos2.z);
			//vertices [(2*i)+1] = newVecPos2;
			//vertices [(2*i)+1] = InstantiateCubes._sampleCube [i].transform.position.z;
		}
		mesh.vertices = vertices;
	}
}
