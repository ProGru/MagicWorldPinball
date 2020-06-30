using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyManipulator : MonoBehaviour
{
    public GameObject objectToManipulate;
    public GameObject circlePrefab;

    public Vector3[] vectors;
    public GameObject[] circles;

    private void Start()
    {
        MeshFilter mesh = objectToManipulate.GetComponent<MeshFilter>();
        vectors = mesh.mesh.vertices;
        circles = new GameObject[vectors.Length];
        for(int i =0;i<vectors.Length;i++)
        {
            circles[i] = Instantiate(circlePrefab,this.transform);
            circles[i].transform.localPosition = vectors[i];
        }
    }

    private void Update()
    {

        
        MeshFilter mesh = objectToManipulate.GetComponent<MeshFilter>();
        mesh.mesh.vertices = vectors;
    }
}
