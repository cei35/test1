using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0;
    public LayerMask layerOrb;
    public LayerMask layerEnemy;

    void Update()
    {
        Vector3 deltaPosition = speed * Time.deltaTime * new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        transform.position += deltaPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ici");
        if (layerOrb == 1 << other.gameObject.layer)
        {
            Debug.Log("la");
            Destroy(other.gameObject);
            GameManager.instance.AddScore();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (layerEnemy == 1 << collision.gameObject.layer)
        {
            Debug.Log("icila");
            Time.timeScale = 0;
            //Destroy(gameObject);
        }
    }

}
