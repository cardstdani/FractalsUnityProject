using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sierpinski : MonoBehaviour
{
    [SerializeField] float magicNumber = 1.5651f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            iteration();
        }
    }

    void iteration()
    {
        GameObject rightDownTriangle = Instantiate(this.gameObject, this.transform.position, this.transform.rotation);
        GameObject upTriangle = Instantiate(this.gameObject, this.transform.position, this.transform.rotation);
        GameObject leftDownTriangle = Instantiate(this.gameObject, this.transform.position, this.transform.rotation);

        rightDownTriangle.transform.position = new Vector3(rightDownTriangle.transform.position.x + (magicNumber), rightDownTriangle.transform.position.y - (magicNumber), rightDownTriangle.transform.position.z);
        rightDownTriangle.transform.localScale = new Vector3(rightDownTriangle.transform.localScale.x / 2, rightDownTriangle.transform.localScale.y / 2, rightDownTriangle.transform.localScale.z / 2);

        leftDownTriangle.transform.position = new Vector3(-leftDownTriangle.transform.position.x - (magicNumber), leftDownTriangle.transform.position.y - (magicNumber), leftDownTriangle.transform.position.z);
        leftDownTriangle.transform.localScale = new Vector3(leftDownTriangle.transform.localScale.x / 2, leftDownTriangle.transform.localScale.y / 2, leftDownTriangle.transform.localScale.z / 2);

        upTriangle.transform.position = new Vector3(upTriangle.transform.position.x, upTriangle.transform.position.y + (magicNumber), upTriangle.transform.position.z);
        upTriangle.transform.localScale = new Vector3(upTriangle.transform.localScale.x / 2, upTriangle.transform.localScale.y / 2, upTriangle.transform.localScale.z / 2);

        upTriangle.GetComponent<sierpinski>().magicNumber /= 2;
        leftDownTriangle.GetComponent<sierpinski>().magicNumber /= 2;
        rightDownTriangle.GetComponent<sierpinski>().magicNumber /= 2;

        GameObject.Find("SceneManager").GetComponent<manager4>().triangles += 3;

        Destroy(this);
    }
}