﻿using Slipe.Shared.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slipe.Shared.Enums
{
    /// <summary>
    /// Provides helper methods to translate certain enums to strings or other objects
    /// </summary>
    public class EnumTranslator
    {
        private static EnumTranslator instance;
        private static Dictionary<EasingFunctionEnum, string> easingFunctionDictionary;

        /// <summary>
        /// Get the singleton instance of this class
        /// </summary>
        public static EnumTranslator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EnumTranslator();
                }
                return instance;
            }
        }

        public EnumTranslator()
        {
            easingFunctionDictionary = new Dictionary<EasingFunctionEnum, string>();
            easingFunctionDictionary.Add(EasingFunctionEnum.LINEAR, "Linear");
            easingFunctionDictionary.Add(EasingFunctionEnum.INQUAD, "InQuad");
            easingFunctionDictionary.Add(EasingFunctionEnum.OUTQUAD, "OutQuad");
            easingFunctionDictionary.Add(EasingFunctionEnum.INOUTQUAD, "InOutQuad");
            easingFunctionDictionary.Add(EasingFunctionEnum.OUTINQUAD, "OutInQuad");
            easingFunctionDictionary.Add(EasingFunctionEnum.INELASTIC, "InElastic");
            easingFunctionDictionary.Add(EasingFunctionEnum.OUTELASTIC, "OutElastic");
            easingFunctionDictionary.Add(EasingFunctionEnum.INOUTELASTIC, "InOutElastic");
            easingFunctionDictionary.Add(EasingFunctionEnum.OUTINELASTIC, "OutInElastic");
            easingFunctionDictionary.Add(EasingFunctionEnum.INBACK, "InBack");
            easingFunctionDictionary.Add(EasingFunctionEnum.OUTBACK, "OutBack");
            easingFunctionDictionary.Add(EasingFunctionEnum.INOUTBACK, "InOutBack");
            easingFunctionDictionary.Add(EasingFunctionEnum.OUTINBACK, "OutInBack");
            easingFunctionDictionary.Add(EasingFunctionEnum.INBOUNCE, "InBounce");
            easingFunctionDictionary.Add(EasingFunctionEnum.OUTBOUNCE, "OutBounce");
            easingFunctionDictionary.Add(EasingFunctionEnum.INOUTBOUNCE, "InOutBounce");
            easingFunctionDictionary.Add(EasingFunctionEnum.OUTINBOUNCE, "OutInBounce");
            easingFunctionDictionary.Add(EasingFunctionEnum.SINECURVE, "SineCurve");
            easingFunctionDictionary.Add(EasingFunctionEnum.COSINECURVE, "CosineCurve");

        }

        /// <summary>
        /// Translates an EasingFunctionEnum to the proper string MTA can use
        /// </summary>
        public string TranslateEasingFunction(EasingFunctionEnum easing)
        {
            return easingFunctionDictionary.TryGetValue(easing, out string result) ? result : "Linear";
        }

        /// <summary>
        /// Translates a weapon enum to a lowercase name, useful for the jetpack functions
        /// </summary>
        public string TranslateWeapon(WeaponType weaponEnum)
        {
            switch(weaponEnum)
            {
                case WeaponType.Ak47:
                    return "ak-47";
                case WeaponType.Colt45:
                    return "colt 45";
                case WeaponType.Tec9:
                    return "tec-9";
                default:
                    return weaponEnum.ToString().ToLower();
            }

        }
    }
}
