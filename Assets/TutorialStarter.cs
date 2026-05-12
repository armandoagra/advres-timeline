using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.InputSystem;
public class TutorialStarter : MonoBehaviour
{
    [SerializeField] private PlayableDirector _playableDirector;
    private bool _hasPlayed = false;
    private bool _isWaitingForInput = false;
    [SerializeField] private GameObject _eCanvas;

    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame && !_hasPlayed)
        {
            _playableDirector.Play();
            _hasPlayed = true;
        }
        if (Keyboard.current.eKey.wasPressedThisFrame && _isWaitingForInput)
        {
            _playableDirector.Resume();
            _isWaitingForInput = false;
            _eCanvas.SetActive(false);
        }
    }

    public void WaitForInput()
    {
        _eCanvas.SetActive(true);
        _isWaitingForInput = true;
        _playableDirector.Pause();
    }
}

