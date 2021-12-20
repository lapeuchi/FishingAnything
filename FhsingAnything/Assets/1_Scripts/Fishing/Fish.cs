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
        Kraken, Waterdragon
    }

    public FishItem curFish;
    public Item fishT;
    SpriteRenderer sr;
    public void Link()
    {
        switch (curFish)
        {
            case FishItem.Starfish:
                BagInven.instance.AddItem(GameManager.instance.itemL[36]);
                break;
            case FishItem.Plastic:
                BagInven.instance.AddItem(GameManager.instance.itemL[39]);
                break;
            case FishItem.Envelope:
                BagInven.instance.AddItem(GameManager.instance.itemL[17]);
                break;
            case FishItem.Seaweeds:
                BagInven.instance.AddItem(GameManager.instance.itemL[51]);
                break;
            case FishItem.Bracelet:
                BagInven.instance.AddItem(GameManager.instance.itemL[8]);
                break;
            case FishItem.Shrimp:
                BagInven.instance.AddItem(GameManager.instance.itemL[52]);
                break;
            case FishItem.hair:
                BagInven.instance.AddItem(GameManager.instance.itemL[22]);
                break;
            case FishItem.Bronze:
                BagInven.instance.AddItem(GameManager.instance.itemL[9]);
                break;
            case FishItem.Mermaid:
                BagInven.instance.AddItem(GameManager.instance.itemL[31]);
                break;
            case FishItem.Poseidon:
                BagInven.instance.AddItem(GameManager.instance.itemL[41]);
                break;
            case FishItem.Moss:
                BagInven.instance.AddItem(GameManager.instance.itemL[32]);
                break;
            case FishItem.Ice:
                BagInven.instance.AddItem(GameManager.instance.itemL[23]);
                break;
            case FishItem.Squid:
                BagInven.instance.AddItem(GameManager.instance.itemL[54]);
                break;
            case FishItem.Fishbread:
                BagInven.instance.AddItem(GameManager.instance.itemL[19]);
                break;
            case FishItem.Robofish:
                BagInven.instance.AddItem(GameManager.instance.itemL[46]);
                break;
            case FishItem.Jellyfish:
                BagInven.instance.AddItem(GameManager.instance.itemL[24]);
                break;
            case FishItem.Plankton:
                BagInven.instance.AddItem(GameManager.instance.itemL[38]);
                break;
            case FishItem.Scuttler:
                BagInven.instance.AddItem(GameManager.instance.itemL[45]);
                break;
            case FishItem.Salmon:
                BagInven.instance.AddItem(GameManager.instance.itemL[47]);
                break;
            case FishItem.Bass:
                BagInven.instance.AddItem(GameManager.instance.itemL[5]);
                break;
            case FishItem.Domfish:
                BagInven.instance.AddItem(GameManager.instance.itemL[15]);
                break;
            case FishItem.Facefish:
                BagInven.instance.AddItem(GameManager.instance.itemL[18]);
                break;
            case FishItem.AqaMan:
                BagInven.instance.AddItem(GameManager.instance.itemL[2]);
                break;
            case FishItem.Barnacleboy:
                BagInven.instance.AddItem(GameManager.instance.itemL[3]);
                break;
            case FishItem.Turtle:
                BagInven.instance.AddItem(GameManager.instance.itemL[55]);
                break;
            case FishItem.RainbowFish:
                BagInven.instance.AddItem(GameManager.instance.itemL[42]);
                break;
            case FishItem.Abalone:
                BagInven.instance.AddItem(GameManager.instance.itemL[0]);
                break;
            case FishItem.Crucian:
                BagInven.instance.AddItem(GameManager.instance.itemL[12]);
                break;
            case FishItem.Octopus:
                BagInven.instance.AddItem(GameManager.instance.itemL[35]);
                break;
            case FishItem.Polarbear:
                BagInven.instance.AddItem(GameManager.instance.itemL[40]);
                break;
            case FishItem.Seal:
                BagInven.instance.AddItem(GameManager.instance.itemL[50]);
                break;
            case FishItem.Penguin:
                BagInven.instance.AddItem(GameManager.instance.itemL[37]);
                break;
            case FishItem.Spongebob:
                BagInven.instance.AddItem(GameManager.instance.itemL[53]);
                break;
            case FishItem.Diver:
                BagInven.instance.AddItem(GameManager.instance.itemL[14]);
                break;
            case FishItem.Naturalman:
                BagInven.instance.AddItem(GameManager.instance.itemL[33]);
                break;
            case FishItem.Ancientkrug:
                BagInven.instance.AddItem(GameManager.instance.itemL[1]);
                break;
            case FishItem.Whiteshark:
                BagInven.instance.AddItem(GameManager.instance.itemL[58]);
                break;
            case FishItem.Blueshark:
                BagInven.instance.AddItem(GameManager.instance.itemL[7]);
                break;
            case FishItem.Crab:
                BagInven.instance.AddItem(GameManager.instance.itemL[11]);
                break;
            case FishItem.Catfish:
                BagInven.instance.AddItem(GameManager.instance.itemL[10]);
                break;
            case FishItem.Whale:
                BagInven.instance.AddItem(GameManager.instance.itemL[57]);
                break;
            case FishItem.Blowfish:
                BagInven.instance.AddItem(GameManager.instance.itemL[6]);
                break;
            case FishItem.Mackerel:
                BagInven.instance.AddItem(GameManager.instance.itemL[30]);
                break;
            case FishItem.Koi:
                BagInven.instance.AddItem(GameManager.instance.itemL[25]);
                break;
            case FishItem.Frog:
                BagInven.instance.AddItem(GameManager.instance.itemL[20]);
                break;
            case FishItem.Duck:
                BagInven.instance.AddItem(GameManager.instance.itemL[16]);
                break;
            case FishItem.Dearhorn:
                BagInven.instance.AddItem(GameManager.instance.itemL[13]);
                break;
            case FishItem.Ghostfish:
                BagInven.instance.AddItem(GameManager.instance.itemL[21]);
                break;
            case FishItem.Seafairycookie:
                BagInven.instance.AddItem(GameManager.instance.itemL[49]);
                break;
            case FishItem.Ninjaturtle:
                BagInven.instance.AddItem(GameManager.instance.itemL[34]);
                break;
            case FishItem.Kyogre:
                BagInven.instance.AddItem(GameManager.instance.itemL[28]);
                break;
            case FishItem.Seadragon:
                BagInven.instance.AddItem(GameManager.instance.itemL[48]);
                break;
            case FishItem.Krong:
                BagInven.instance.AddItem(GameManager.instance.itemL[27]);
                break;
            case FishItem.Leviathan:
                BagInven.instance.AddItem(GameManager.instance.itemL[29]);
                break;
            case FishItem.Baron:
                BagInven.instance.AddItem(GameManager.instance.itemL[4]);
                break;
            case FishItem.Herald:
                BagInven.instance.AddItem(GameManager.instance.itemL[44]);
                break;
            case FishItem.Rayquaza:
                BagInven.instance.AddItem(GameManager.instance.itemL[43]);
                break;
            case FishItem.Kraken:
                BagInven.instance.AddItem(GameManager.instance.itemL[26]);
                break;
            case FishItem.Waterdragon:
                BagInven.instance.AddItem(GameManager.instance.itemL[56]);
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
            Link();
            Fishing.instance.gameProcess = 4;
        }
    }
}