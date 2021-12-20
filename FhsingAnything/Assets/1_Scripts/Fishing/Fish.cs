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
        GameManager.instance.Money += money;
        //switch (curfish)
        //{
        //    case fishitem.starfish:
        //        baginven.instance.additem(gamemanager.instance.iteml[36]);
        //        break;
        //    case fishitem.plastic:
        //        baginven.instance.additem(gamemanager.instance.iteml[39]);
        //        break;
        //    case fishitem.envelope:
        //        baginven.instance.additem(gamemanager.instance.iteml[17]);
        //        break;
        //    case fishitem.seaweeds:
        //        baginven.instance.additem(gamemanager.instance.iteml[51]);
        //        break;
        //    case fishitem.bracelet:
        //        baginven.instance.additem(gamemanager.instance.iteml[8]);
        //        break;
        //    case fishitem.shrimp:
        //        baginven.instance.additem(gamemanager.instance.iteml[52]);
        //        break;
        //    case fishitem.hair:
        //        baginven.instance.additem(gamemanager.instance.iteml[22]);
        //        break;
        //    case fishitem.bronze:
        //        baginven.instance.additem(gamemanager.instance.iteml[9]);
        //        break;
        //    case fishitem.mermaid:
        //        baginven.instance.additem(gamemanager.instance.iteml[31]);
        //        break;
        //    case fishitem.poseidon:
        //        baginven.instance.additem(gamemanager.instance.iteml[41]);
        //        break;
        //    case fishitem.moss:
        //        baginven.instance.additem(gamemanager.instance.iteml[32]);
        //        break;
        //    case fishitem.ice:
        //        baginven.instance.additem(gamemanager.instance.iteml[23]);
        //        break;
        //    case fishitem.squid:
        //        baginven.instance.additem(gamemanager.instance.iteml[54]);
        //        break;
        //    case fishitem.fishbread:
        //        baginven.instance.additem(gamemanager.instance.iteml[19]);
        //        break;
        //    case fishitem.robofish:
        //        baginven.instance.additem(gamemanager.instance.iteml[46]);
        //        break;
        //    case fishitem.jellyfish:
        //        baginven.instance.additem(gamemanager.instance.iteml[24]);
        //        break;
        //    case fishitem.plankton:
        //        baginven.instance.additem(gamemanager.instance.iteml[38]);
        //        break;
        //    case fishitem.scuttler:
        //        baginven.instance.additem(gamemanager.instance.iteml[45]);
        //        break;
        //    case fishitem.salmon:
        //        baginven.instance.additem(gamemanager.instance.iteml[47]);
        //        break;
        //    case fishitem.bass:
        //        baginven.instance.additem(gamemanager.instance.iteml[5]);
        //        break;
        //    case fishitem.domfish:
        //        baginven.instance.additem(gamemanager.instance.iteml[15]);
        //        break;
        //    case fishitem.facefish:
        //        baginven.instance.additem(gamemanager.instance.iteml[18]);
        //        break;
        //    case fishitem.aqaman:
        //        baginven.instance.additem(gamemanager.instance.iteml[2]);
        //        break;
        //    case fishitem.barnacleboy:
        //        baginven.instance.additem(gamemanager.instance.iteml[3]);
        //        break;
        //    case fishitem.turtle:
        //        baginven.instance.additem(gamemanager.instance.iteml[55]);
        //        break;
        //    case fishitem.rainbowfish:
        //        baginven.instance.additem(gamemanager.instance.iteml[42]);
        //        break;
        //    case fishitem.abalone:
        //        baginven.instance.additem(gamemanager.instance.iteml[0]);
        //        break;
        //    case fishitem.crucian:
        //        baginven.instance.additem(gamemanager.instance.iteml[12]);
        //        break;
        //    case fishitem.octopus:
        //        baginven.instance.additem(gamemanager.instance.iteml[35]);
        //        break;
        //    case fishitem.polarbear:
        //        baginven.instance.additem(gamemanager.instance.iteml[40]);
        //        break;
        //    case fishitem.seal:
        //        baginven.instance.additem(gamemanager.instance.iteml[50]);
        //        break;
        //    case fishitem.penguin:
        //        baginven.instance.additem(gamemanager.instance.iteml[37]);
        //        break;
        //    case fishitem.spongebob:
        //        baginven.instance.additem(gamemanager.instance.iteml[53]);
        //        break;
        //    case fishitem.diver:
        //        baginven.instance.additem(gamemanager.instance.iteml[14]);
        //        break;
        //    case fishitem.naturalman:
        //        baginven.instance.additem(gamemanager.instance.iteml[33]);
        //        break;
        //    case fishitem.ancientkrug:
        //        baginven.instance.additem(gamemanager.instance.iteml[1]);
        //        break;
        //    case fishitem.whiteshark:
        //        baginven.instance.additem(gamemanager.instance.iteml[58]);
        //        break;
        //    case fishitem.blueshark:
        //        baginven.instance.additem(gamemanager.instance.iteml[7]);
        //        break;
        //    case fishitem.crab:
        //        baginven.instance.additem(gamemanager.instance.iteml[11]);
        //        break;
        //    case fishitem.catfish:
        //        baginven.instance.additem(gamemanager.instance.iteml[10]);
        //        break;
        //    case fishitem.whale:
        //        baginven.instance.additem(gamemanager.instance.iteml[57]);
        //        break;
        //    case fishitem.blowfish:
        //        baginven.instance.additem(gamemanager.instance.iteml[6]);
        //        break;
        //    case fishitem.mackerel:
        //        baginven.instance.additem(gamemanager.instance.iteml[30]);
        //        break;
        //    case fishitem.koi:
        //        baginven.instance.additem(gamemanager.instance.iteml[25]);
        //        break;
        //    case fishitem.frog:
        //        baginven.instance.additem(gamemanager.instance.iteml[20]);
        //        break;
        //    case fishitem.duck:
        //        baginven.instance.additem(gamemanager.instance.iteml[16]);
        //        break;
        //    case fishitem.dearhorn:
        //        baginven.instance.additem(gamemanager.instance.iteml[13]);
        //        break;
        //    case fishitem.ghostfish:
        //        baginven.instance.additem(gamemanager.instance.iteml[21]);
        //        break;
        //    case fishitem.seafairycookie:
        //        baginven.instance.additem(gamemanager.instance.iteml[49]);
        //        break;
        //    case fishitem.ninjaturtle:
        //        baginven.instance.additem(gamemanager.instance.iteml[34]);
        //        break;
        //    case fishitem.kyogre:
        //        baginven.instance.additem(gamemanager.instance.iteml[28]);
        //        break;
        //    case fishitem.seadragon:
        //        baginven.instance.additem(gamemanager.instance.iteml[48]);
        //        break;
        //    case fishitem.krong:
        //        baginven.instance.additem(gamemanager.instance.iteml[27]);
        //        break;
        //    case fishitem.leviathan:
        //        baginven.instance.additem(gamemanager.instance.iteml[29]);
        //        break;
        //    case fishitem.baron:
        //        baginven.instance.additem(gamemanager.instance.iteml[4]);
        //        break;
        //    case fishitem.herald:
        //        baginven.instance.additem(gamemanager.instance.iteml[44]);
        //        break;
        //    case fishitem.rayquaza:
        //        baginven.instance.additem(gamemanager.instance.iteml[43]);
        //        break;
        //    case fishitem.kraken:
        //        baginven.instance.additem(gamemanager.instance.iteml[26]);
        //        break;
        //    case fishitem.waterdragon:
        //        baginven.instance.additem(gamemanager.instance.iteml[56]);
        //        break;
        //}
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