using System;
using UnityEngine;
using UnityEngine.UI;

public class BombButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject _bombPrefab;
    [SerializeField] private Transform _parent;

    public Action ActivateBomb;

    private Button _buttonPut;
    private GameObject _player;

    private void Start()
    {
        _buttonPut = GetComponent<Button>();
        _player = GameObject.FindGameObjectWithTag("Pig");

        ActivateBomb += ActivateBombButton;
        _buttonPut.onClick.AddListener(() => PutBomb());
    }
    
    private void ActivateBombButton()
    {
        _buttonPut.interactable = true;
    }

    private void PutBomb()
    {
        Instantiate(_bombPrefab, _player.transform.position, Quaternion.identity, _parent);
        _buttonPut.interactable = false;
    }
}
