using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuberias : MonoBehaviour {

    [SerializeField] private int speed = 3;
    [SerializeField] float limiteInferior = -1;
    [SerializeField] float limiteSuperior = 1;
    [SerializeField] float distanciaDestruccion = -20;

    void Start () {
        float factorPosicion = Random.Range(limiteInferior, limiteSuperior);
        this.transform.position = new Vector3(
            transform.position.x, 
            transform.position.y+factorPosicion,
            transform.position.z);
	}
	
	void Update () {
        if (GameConfig.IsPlaying())
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            if (transform.position.x < distanciaDestruccion)
            {
                Destroy(this.gameObject);
            }
        }
	}
}
