using UnityEngine;

public class ColorAleatorioFixedUpdate : MonoBehaviour
{
    void FixedUpdate()
    {
        var meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
