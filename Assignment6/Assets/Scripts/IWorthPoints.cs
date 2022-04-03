using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Anna Breuker
 * Assignment 6
 * An interface for objects tha are worth points, 
 * ensuring the amount of points will be added to the score.
 */
public interface IWorthPoints
{
    void GivePoints(float amount);
}
