using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore;

public class AdjustSprite : MonoBehaviour
{
    public float AddAD = 4f;
    public float AddBX = 4f;
    public TMP_SpriteAsset spriteAsset;

    [Button(ButtonSizes.Large)]
    public void Adjust()
    {
        foreach (TMP_SpriteGlyph glyph in spriteAsset.spriteGlyphTable)
        {
            glyph.metrics = new GlyphMetrics(glyph.metrics.width,glyph.metrics.height,
                glyph.metrics.horizontalBearingX+AddBX,
                glyph.metrics.horizontalBearingY,
                glyph.metrics.horizontalAdvance+AddAD);
        }
    }
    [Button(ButtonSizes.Large)]
    public void Reset()
    {
        foreach (TMP_SpriteGlyph glyph in spriteAsset.spriteGlyphTable)
        {
            glyph.metrics = new GlyphMetrics(glyph.metrics.width,glyph.metrics.height,
                0f,
                glyph.metrics.horizontalBearingY,
                64f);
        }
    }
    [Button(ButtonSizes.Large)]
    public void Specify(float bx, float ad)
    {
        foreach (TMP_SpriteGlyph glyph in spriteAsset.spriteGlyphTable)
        {
            glyph.metrics = new GlyphMetrics(glyph.metrics.width,glyph.metrics.height,
                bx,
                glyph.metrics.horizontalBearingY,
                ad);
        }
    }
}
