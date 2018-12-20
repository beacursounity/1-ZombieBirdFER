using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour {

    [SerializeField] Transform prefabTuberia;
    [SerializeField] float ratioGeneracionTuberias = 2f;

	// Use this for initialization
	void Start () {

        InvokeRepeating("GeneratePipe", 0, ratioGeneracionTuberias);
	}
	
    void GeneratePipe()
    {
        //Generamos la tubería
        if (GameConfig.IsPlaying())
        {
            Instantiate(prefabTuberia, transform.position, Quaternion.identity);
        }
        
    }
}
