using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreationScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cube1 =
           GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube1.transform.position = new Vector3(-32.63f, 0, -8.87f);
        var cubeRenderer = cube1.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", Color.blue);

        GameObject cube2 =
           GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube2.transform.position = new Vector3(23.96f, 0, -10.59f);
        var cubeRenderer2 = cube2.GetComponent<Renderer>();
        cubeRenderer2.material.SetColor("_Color", Color.blue);

        GameObject cube3 =
           GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube3.transform.position = new Vector3(-35.86f, 0, 22.55f);
        var cubeRenderer3 = cube3.GetComponent<Renderer>();
        cubeRenderer3.material.SetColor("_Color", Color.blue);

        GameObject cube4 =
           GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube4.transform.position = new Vector3(-35.74f, 0, 30.26f);
        var cubeRenderer4 = cube4.GetComponent<Renderer>();
        cubeRenderer4.material.SetColor("_Color", Color.blue);

        GameObject cube5 =
           GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube5.transform.position = new Vector3(-23.22f, 0, 15.57f);
        var cubeRenderer5 = cube5.GetComponent<Renderer>();
        cubeRenderer5.material.SetColor("_Color", Color.blue);

        GameObject cube6 =
           GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube6.transform.position = new Vector3(45.94f, 0, -12.30f);
        var cubeRenderer6 = cube6.GetComponent<Renderer>();
        cubeRenderer6.material.SetColor("_Color", Color.blue);

        GameObject cube7 =
           GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube7.transform.position = new Vector3(3.90f, 0, 14.54f);
        var cubeRenderer7 = cube7.GetComponent<Renderer>();
        cubeRenderer7.material.SetColor("_Color", Color.blue);

        GameObject cube8 =
           GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube8.transform.position = new Vector3(-16.16f, 0, -18.03f);
        var cubeRenderer8 = cube8.GetComponent<Renderer>();
        cubeRenderer8.material.SetColor("_Color", Color.blue);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
