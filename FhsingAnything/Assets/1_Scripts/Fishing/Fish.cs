using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public int hp;
    public int money;
    public int size;

    public enum FishItem
    {
        Starfish, Plastic, Envelope, Seaweeds, Bracelet, Shrimp, hair, Bronze, Mermaid, Poseidon, Moss, Ice, Squid,
        Fishbread, Robofish, Jellyfish, Plankton, Scuttler, Salmon, Bass, Domfish, Facefish, AqaMan, Barnacleboy,
        Turtle, RainbowFish, Abalone, Crucian, Octopus, Polarbear, Seal, Penguin, Spongebob, Diver, Naturalman,
        Ancientkrug, Whiteshark, Blueshark, Crab, Catfish, Whale, Blowfish, Mackerel, Koi, Frog, Duck, Dearhorn,
        Ghostfish, Seafairycookie, Ninjaturtle, Kyogre, Seadragon, Krong, Leviathan, Baron, Herald, Rayquaza,
        Kraken, Bluedragon
    }

    public FishItem curFish;
    public Item fishT;
    SpriteRenderer sr;
    public void Link()
    {
        switch (curFish)
        {
            case FishItem.Starfish:
                Inventory.instance.AddItem(GameManager.instance.itemL[36]);
                break;
            case FishItem.Plastic:
                Inventory.instance.AddItem(GameManager.instance.itemL[39]);
                break;
            case FishItem.Envelope:
                Inventory.instance.AddItem(GameManager.instance.itemL[17]);
                break;
            case FishItem.Seaweeds:
                Inventory.instance.AddItem(GameManager.instance.itemL[51]);
                break;
            case FishItem.Bracelet:
                Inventory.instance.AddItem(GameManager.instance.itemL[8]);
                break;
            case FishItem.Shrimp:
                Inventory.instance.AddItem(GameManager.instance.itemL[52]);
                break;
            case FishItem.hair:
                Inventory.instance.AddItem(GameManager.instance.itemL[22]);
                break;
            case FishItem.Bronze:
                Inventory.instance.AddItem(GameManager.instance.itemL[9]);
                break;
            case FishItem.Mermaid:
                Inventory.instance.AddItem(GameManager.instance.itemL[31]);
                break;
            case FishItem.Poseidon:
                Inventory.instance.AddItem(GameManager.instance.itemL[41]);
                break;
        }
    }

    public void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        FishManager.instance.SetStatus(FishManager.instance.FishTier, ref hp, ref money, ref size);
        sr.sortingOrder = -1;
    }

    void Update()
    {
        if (Fishing.instance.gameProcess == 3) 
        {
            sr.sortingOrder = 2;
           // Inventory.instance.AddItem(Starfish);
        }
    }
}