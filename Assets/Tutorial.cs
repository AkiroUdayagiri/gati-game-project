using UnityEngine;
using UnityEngine.UI; // Use TMPro if using TextMeshPro

public class Tutorial : MonoBehaviour
{
    public GameObject Welcome, UseWASD, UseSpace;
    private float elapsedTime = 0f; // Track elapsed time

    private enum TutorialState { Welcome, UseWASD, UseSpace }
    private TutorialState currentState = TutorialState.Welcome;

    void Update()
    {
        elapsedTime += Time.deltaTime;

        switch (currentState)
        {
            case TutorialState.Welcome:
                if (Input.anyKeyDown)
                {
                    Welcome.SetActive(false);
                    UseWASD.SetActive(true);
                    currentState = TutorialState.UseWASD;
                    elapsedTime = 0f; // Reset timer
                }
                break;

            case TutorialState.UseWASD:
                if (elapsedTime >= 3f)
                {
                    UseWASD.SetActive(false);
                    UseSpace.SetActive(true);
                    currentState = TutorialState.UseSpace;
                    elapsedTime = 0f; // Reset timer
                }
                break;

            case TutorialState.UseSpace:
                if (elapsedTime >= 3f)
                {
                    UseSpace.SetActive(false); // Hide UseSpace after 3 seconds
                    // You can add additional behavior here if needed
                }
                break;
        }
    }
}
