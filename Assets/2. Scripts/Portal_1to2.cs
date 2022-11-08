using UnityEngine;

public class Portal_1to2 : Collidable
{
    public string[] sceneNames;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            // �÷��̾� �̵�
            string sceneName = sceneNames[1];
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }
}