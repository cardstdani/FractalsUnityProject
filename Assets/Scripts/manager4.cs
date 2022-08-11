using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class manager4 : MonoBehaviour
{
    public GameObject menu;
    public TextMeshProUGUI objectsText, iterationText;
    public Camera cameraComponent;
    public float speed, moveSpeed;
    public int iteration = 0;
    public int triangles = 1;

    void Update()
    {
        //move the camara and control the zoom amount
        cameraComponent.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * speed * Time.deltaTime * cameraComponent.orthographicSize;
        cameraComponent.transform.Translate(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f) * moveSpeed * cameraComponent.orthographicSize);

        //if press M key, add 1 iteration
        if (Input.GetKeyDown(KeyCode.M))
        {
            iteration++;
        }

        //activate/deactivate menu
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            menu.SetActive(true);

            iterationText.text = "Iteration: " + iteration;
            objectsText.text = "Triangles: " + triangles;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            menu.SetActive(false);
        }
    }

    public void salir()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("menu");
    }
}