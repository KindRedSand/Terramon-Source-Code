﻿using Microsoft.Xna.Framework.Graphics;
using Terramon.UI.Transformable;
using Terraria;
using Terraria.GameContent.UI.Elements;

namespace Terramon.UI
{
    // This UIHoverImageButton class inherits from UIImageButton. 
    // Inheriting is a great tool for UI design. 
    // By inheriting, we get the Image drawing, MouseOver sound, and fading for free from UIImageButton
    // We've added some code to allow the Button to show a text tooltip while hovered. 
    internal class UIHoverImageButton : TransformableUIButton
    {
        internal string HoverText;

        public float _visibilityActive = 1f;

        public UIHoverImageButton(Texture2D texture, string hoverText) 
        {
            HoverText = hoverText;
            Texture = texture;
        }

        protected override void DrawSelf(SpriteBatch spriteBatch)
        {
            base.DrawSelf(spriteBatch);

            //SetVisibility(_visibilityActive, _visibilityActive);

            if (IsMouseHovering) Main.hoverItemName = HoverText;
        }
    }
}