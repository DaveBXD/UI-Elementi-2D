using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaParadisana : MonoBehaviour {
	//uzglabas tekstu kurś pańemts no input lauka
	public string teksts;
	//lauks no kura es tekstu panemu
	public GameObject ievadesLauks;
	//teksta objekts kur attelo mainiga teksts aturu
	public GameObject tekstaAttelosanasLauks;

	public void darbibasArTekstu(){
		teksts = ievadesLauks.GetComponent<Text> ().text;
		tekstaAttelosanasLauks.GetComponent<Text> ().text = "Sveiks "+teksts.ToUpper()+"!";


	}
}