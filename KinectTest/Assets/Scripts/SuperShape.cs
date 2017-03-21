using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class SuperShape : MonoBehaviour
{
    public int radius;
    public int resolution;
    
    public float m;
    public float n1;
    public float n2;
    public float n3;

    private Vector3[] vertices;
    private Mesh mesh;

    void Awake()
    {

    }

    void Start()
    {
        Generate();
    }

    void Update()
    {

    }

    private void Generate()
    {

        vertices = new Vector3[(resolution + 1) * (resolution + 1)];
        GetComponent<MeshFilter>().mesh = mesh = new Mesh();
        mesh.name = "Super Shape";

        for (int index = 0, i = 0; i <= resolution; i++) // latitude ( ||| )
        {
            float lat = ExtensionMethods.Map(i, 0, resolution, -Mathf.PI / 2, Mathf.PI / 2);
            float r2 = SuperFormula(lat, m, n1, n2, n3);
            for (int j = 0; j <= resolution; j++, index++) // longitude ( --- )
            {
                float lon = ExtensionMethods.Map(j, 0, resolution, -Mathf.PI, Mathf.PI);
                float r1 = SuperFormula(lon, m, n1, n2, n3);
                float x = radius * r1 * Mathf.Cos(lon) * r2 * Mathf.Cos(lat);
                float y = radius * r1 * Mathf.Sin(lon) * r2 * Mathf.Cos(lat);
                float z = radius * r2 * Mathf.Sin(lat);
                vertices[index] = new Vector3(x, y, z);
            }
        }
        mesh.vertices = vertices;

        int[] triangles = new int[resolution * resolution * 6];
        for (int ti = 0, vi = 0, y = 0; y < resolution; y++, vi++)
        {
            for (int x = 0; x < resolution; x++, ti += 6, vi++)
            {
                triangles[ti] = vi;
                triangles[ti + 1] = triangles[ti + 4] = vi + 1;
                triangles[ti + 2] = triangles[ti + 3] = vi + resolution + 1;
                triangles[ti + 5] = vi + resolution + 2;
            }
        }
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }

    float SuperFormula(float theta, float m, float n1, float n2, float n3)
    {
        float a = 1;
        float b = 1;
        float t1 = Mathf.Abs((1 / a) * Mathf.Cos(m * theta / 4));
        t1 = Mathf.Pow(t1, n2);
        float t2 = Mathf.Abs((1 / b) * Mathf.Sin(m * theta / 4));
        t2 = Mathf.Pow(t2, n3);
        float t3 = t1 + t2;
        float r = Mathf.Pow(t3, -1 / n1);
        return r;
    }

    void OnDrawGizmos()
    {
        //if (vertices == null) return;
        //Gizmos.color = Color.black;
        //for (int i = 0; i < vertices.Length; i++)
        //{
        //    Gizmos.DrawSphere(vertices[i], radius * 0.01f);
        //}
    }
}
