﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter8_6
{
    public class CharacterSprite
    {
        public Sprite Sprite { get; set; }
        public CharacterData Data { get; set; }

        public CharacterSprite(Sprite sprite, CharacterData data)
        {
            Data = data;
            Sprite = sprite;
        }
    }
}
