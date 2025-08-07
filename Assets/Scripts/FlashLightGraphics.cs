using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class FlashLightGraphics : MonoBehaviour
{
    public Slider intensitysliderUI;
    public Slider frequencysliderUI;
    public float intensity = 1.0f;
    public float frequency = 1.0f;


    List<SpriteRenderer> spriteRenderers = new List<SpriteRenderer>();
    void Start()
    {
        spriteRenderers = GetComponentsInChildren<SpriteRenderer>().ToList();
    }

    // Update is called once per frame
    void Update()
    {
        intensity = intensitysliderUI.value;
        frequency = frequencysliderUI.value;
        foreach (var spriteRenderer in spriteRenderers)
        {
            if (spriteRenderer != GetComponent<SpriteRenderer>())
            {
                spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, intensity);
            }

        }

        ElectronEmitter.instance.spawnRate = intensity * 8;

        if (BattaryCrg.instance.voltage >= 0)
        {
            ElectronEmitter.instance.travelDistance = frequency * 10;
        }
        else
        {
            ElectronEmitter.instance.travelDistance = (float)(frequency * 10 * (1 - (BattaryCrg.instance.voltage / -4)));
        }

    }
}
