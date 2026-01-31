using UnityEngine;

public enum SandıkType
{
    Win,
    Lose
}

public class Sandık : MonoBehaviour
{
    public SandıkType sandıkType;

    public ParticleSystem winEffect;
    public ParticleSystem loseEffect;

    private bool opened = false;



    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.CompareTag("Player") && !opened)
        {
            OpenBox();
        }
    }

    void OpenBox()
    {
        opened = true;

        if (sandıkType == SandıkType.Win)
        {

            GameManager.instance.WinGame();
        }
        else // Lose
        {
           

            GameManager.instance.LoseGame();
        }
    }
}
