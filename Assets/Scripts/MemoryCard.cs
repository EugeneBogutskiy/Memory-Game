using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    //[SerializeField] private Sprite image;
    [SerializeField] private GameObject cardBack;
    [SerializeField] private SceneController controller;
    private int _id;
    public int id
    {
        get { return _id; }
    }

    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }
    void Start()
    {
    }

    public void OnMouseDown()
    {
        if (cardBack.activeSelf&&controller.canReveal)
        {
            cardBack.SetActive(false);
            controller.CanRevealed(this);
        }
        //if (cardBack.activeSelf)
        //{
        //    cardBack.SetActive(false);
        //}
    }

    public void Unreveal()
    {
        cardBack.SetActive(true);
    }

    void Update()
    {

    }
}
