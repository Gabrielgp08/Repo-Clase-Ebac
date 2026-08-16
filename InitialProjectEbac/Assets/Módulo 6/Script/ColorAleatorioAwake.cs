using UnityEngine;

public class ColorAleatorioAwake : MonoBehaviour
{
    void Awake()
    {
        var meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
