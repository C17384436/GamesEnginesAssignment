using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTerrain : MonoBehaviour
{
    //Variable to establish height and detail of the plain
    int heightScale = 5;
    float detailScale = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        //When the script is called, it creates a mesh and uses the PerlinNoise feature in order to transform the
        //plain from a flat surface to a randomly generated bumpy plain in order to make it look similar to a mountain
        //pass

        Mesh mesh = this.GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        for(int v = 0; v < vertices.Length; v++)
        {
            vertices[v].y = Mathf.PerlinNoise((vertices[v].x + this.transform.position.x) / detailScale, 
                                              (vertices[v].z + this.transform.position.z) / detailScale) * heightScale;
        }

        mesh.vertices = vertices;
        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
        this.gameObject.AddComponent<MeshCollider>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
