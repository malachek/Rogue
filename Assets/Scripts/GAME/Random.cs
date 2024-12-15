using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    [Header("RNG")]
    [SerializeField] int modulus;

    [Header("Seeds")]
    [SerializeField] int Seed0;
    public List<int> SeedsList { get; private set; }
    public int Seed { get; private set; }

    private void Awake()
    {
        SeedsList = new List<int>();

        UpdateSeed(Seed0);

        PerlinLine(1000);
    }

    private void UpdateSeed(int newSeed)
    {
        SeedsList.Add(newSeed);
        Seed = newSeed;
    }

    public void PerlinLine(int count)
    {
        int pixel = 0;

        for (int i = 0; i < count; i++)
        {
            int deltaPixel = PRNG(i);
            pixel += deltaPixel;

            Debug.Log((pixel, deltaPixel));
        }
        Debug.Log(pixel);
    }

    public int PRNG(int inputValue /*, int inputSeed = 0*/)
    {

        return (inputValue * 1103515245 + 12345) % modulus;
    }

}
