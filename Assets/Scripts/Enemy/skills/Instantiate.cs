using UnityEngine;

internal class Instantiate
{
    private GameObject prefab;
    private Vector3 position;
    private Quaternion rotation;

    public Instantiate(GameObject prefab, Vector3 position, Quaternion rotation)
    {
        this.prefab = prefab;
        this.position = position;
        this.rotation = rotation;
    }
}