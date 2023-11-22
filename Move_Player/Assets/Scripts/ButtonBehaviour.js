#pragma strict

var Cena: UnityEngine.SceneManagement.SceneManager;

function Start () {

}

function Update () {
}
function proxTela1() {
	Cena.LoadScene("scene");
}
function proxTela2(){
	Cena.LoadScene("instrucoes");
}
function proxTela3(){
	Cena.LoadScene("sobre");
}