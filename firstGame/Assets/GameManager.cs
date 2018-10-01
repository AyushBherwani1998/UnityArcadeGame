using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public float restartTime = 3f;
	bool gameHasEnded = false;
	public GameObject completeLevelUI;
	public void CompleteLevel(){
		completeLevelUI.SetActive(true);
		Invoke("Restart",restartTime);
	}
	
	public void EndGame(){
		if(gameHasEnded == false){
			gameHasEnded = true;
		
			Invoke("Restart",restartTime);
		}
		
	}

	void Restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);		
	}
}
