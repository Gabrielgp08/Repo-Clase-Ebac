using UnityEngine;

public class GenerarCuboAwake : MonoBehaviour
{
    Vector3[] vertices =
    {
        new Vector3 (0, 0, 0),
        new Vector3 (1, 0, 0),
        new Vector3 (1, 1, 0),
        new Vector3 (0, 1, 0),
        new Vector3 (0, 1, 1),
        new Vector3 (1, 1, 1),
        new Vector3 (1, 0, 1),
        new Vector3 (0, 0, 1),
    };
    int[] triangulos =
    {
        0, 2, 1,
        0, 3, 2,
        2, 3, 4,
        2, 4, 5,
        1, 2, 5,
        1, 5, 6,
        0, 7, 4,
        0, 4, 7,
        5, 4, 7,
        5, 7, 6,
        0, 6, 7,
        0, 1, 6,
    };

    void Awake()
    {
        var cubo = new GameObject("Cubo desde Awake");
        var meshFilter = cubo.AddComponent<MeshFilter>();

        var mesh = new Mesh();
        mesh.vertices = vertices;
        mesh.triangles = triangulos;
        mesh.RecalculateNormals();
        meshFilter.mesh = mesh;

        cubo.AddComponent<MeshRenderer>();
        cubo.transform.position = Vector3.zero;
    }
}
