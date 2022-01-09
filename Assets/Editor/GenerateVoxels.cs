using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GenerateVoxels : MonoBehaviour
{
    [MenuItem("zfz/generate")]
    public static void Generate()
    {
        const int length = 16;
        var box = GameObject.CreatePrimitive(PrimitiveType.Cube);

        var root = new GameObject("root");
        for (int x = 0; x < length; x++)
        {
            for (int y = 0; y < length; y++)
            {
                for (int z = 0; z < length; z++)
                {
                    var go = GameObject.Instantiate(box);
                    go.AddComponent<Rigidbody>().mass = 0.1f;
                    go.transform.SetParent(root.transform);
                    go.transform.localPosition = new Vector3(x + 0.5f - length / 2, y + 0.5f - length / 2, z + 0.5f - length / 2);
                }
            }
        }
        root.transform.localScale = Vector3.one * 0.1f;

        GameObject.DestroyImmediate(box);
    }
}
