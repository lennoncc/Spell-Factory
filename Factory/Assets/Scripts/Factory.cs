﻿using UnityEngine;

public class Factory : MonoBehaviour
{
    public enum Spells { Imposter, BlackHole, Meteor}

    private static int SerialID = 0;

    public MonoBehaviour GetNewInstance(Spells type)
    {


        //return Instantiate(GameObject);
        return null;
    }
}