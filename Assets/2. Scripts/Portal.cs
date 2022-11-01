using UnityEngine;

public class Portal : Collidable
{
    public string[] sceneNames;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            // 플레이어 이동
            string sceneName = sceneNames[1];
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }
}