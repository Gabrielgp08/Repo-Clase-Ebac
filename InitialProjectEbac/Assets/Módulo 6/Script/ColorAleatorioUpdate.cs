using UnityEngine;

public class ColorAleatorioUpdate : MonoBehaviour
{
    void Update()
    {
        var meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
