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

    SpriteRenderer sr;
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
            //Inventory.instance.AddItem();
        }
    }
}