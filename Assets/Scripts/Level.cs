using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {

    private GameObject camera;

    void Start() {
        camera = GameObject.FindGameObjectWithTag("MainCamera");

    }
    
    public void CarregarConfig(float xDirection) {

        camera.transform.position = new Vector2(camera.transform.position.x + xDirection, camera.transform.position.y);
    
    }

    public void CarregarPlanets(float yDirection)
    {

        camera.transform.position = new Vector2(camera.transform.position.x, camera.transform.position.y + yDirection);

    }

    public void StartGame(string scene) {
        Application.LoadLevel(scene);

    }

    public void SairJogo() {
        Application.Quit();

    }
}
