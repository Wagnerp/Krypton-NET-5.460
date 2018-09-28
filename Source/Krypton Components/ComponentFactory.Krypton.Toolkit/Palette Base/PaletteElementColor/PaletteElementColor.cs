﻿// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2018, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.460)
//  Version 4.7.0.0  www.ComponentFactory.com
// *****************************************************************************

using System.Drawing;
using System.ComponentModel;

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// Storage for element color values.
	/// </summary>
    public class PaletteElementColor : Storage,
                                       IPaletteElementColor
    {
        #region Instance Fields
        private IPaletteElementColor _inheritElementColor;
        private Color _color1;
        private Color _color2;
        private Color _color3;
        private Color _color4;
        private Color _color5;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteElementColor class.
		/// </summary>
        /// <param name="inheritElementColor">Source for inheriting values.</param>
        /// <param name="needPaint">Delegate for notifying changes in value.</param>
        public PaletteElementColor(IPaletteElementColor inheritElementColor,
                                   NeedPaintHandler needPaint) 
		{
            // Remember inheritance
            _inheritElementColor = inheritElementColor;

            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Define default values
            _color1 = Color.Empty;
            _color2 = Color.Empty;
            _color3 = Color.Empty;
            _color4 = Color.Empty;
            _color5 = Color.Empty;
        }
        #endregion

		#region IsDefault
		/// <summary>
		/// Gets a value indicating if all values are default.
		/// </summary>
		[Browsable(false)]
		public override bool IsDefault => (Color1 == Color.Empty) &&
		                                  (Color2 == Color.Empty) &&
		                                  (Color3 == Color.Empty) &&
		                                  (Color4 == Color.Empty) &&
		                                  (Color5 == Color.Empty);

        #endregion

        #region SetInherit
        /// <summary>
        /// Sets the inheritence parent.
        /// </summary>
        public void SetInherit(IPaletteElementColor inheritElementColor)
        {
            _inheritElementColor = inheritElementColor;
        }
        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        /// <param name="state">Palette state to use when populating.</param>
        public void PopulateFromBase(PaletteState state)
        {
            Color1 = GetElementColor1(state);
            Color2 = GetElementColor2(state);
            Color3 = GetElementColor3(state);
            Color4 = GetElementColor4(state);
            Color5 = GetElementColor5(state);
        }
        #endregion

        #region Color1
        /// <summary>
        /// Gets and sets the first element color.
        /// </summary>
        [KryptonPersist(false)]
        [Category("Visuals")]
        [Description("First element color.")]
        [DefaultValue(typeof(Color), "")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public virtual Color Color1
        {
            get => _color1;

            set
            {
                if (_color1 != value)
                {
                    _color1 = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Reset the Color1 to the default value.
        /// </summary>
        public void ResetColor1() => Color1 = Color.Empty;

        /// <summary>
        /// Gets the first element color.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public Color GetElementColor1(PaletteState state) =>
            Color1 != Color.Empty ? Color1 : _inheritElementColor.GetElementColor1(state);

        #endregion

        #region Color2
        /// <summary>
        /// Gets and sets the second element color.
        /// </summary>
        [KryptonPersist(false)]
        [Category("Visuals")]
        [Description("Second element color.")]
        [DefaultValue(typeof(Color), "")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public virtual Color Color2
        {
            get => _color2;

            set
            {
                if (_color2 != value)
                {
                    _color2 = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Reset the Color2 to the default value.
        /// </summary>
        public void ResetColor2() => Color2 = Color.Empty;

        /// <summary>
        /// Gets the second element color.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public Color GetElementColor2(PaletteState state) =>
            Color2 != Color.Empty ? Color2 : _inheritElementColor.GetElementColor2(state);

        #endregion

        #region Color3
        /// <summary>
        /// Gets and sets the third element color.
        /// </summary>
        [KryptonPersist(false)]
        [Category("Visuals")]
        [Description("Third element color.")]
        [DefaultValue(typeof(Color), "")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public virtual Color Color3
        {
            get => _color3;

            set
            {
                if (_color3 != value)
                {
                    _color3 = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Reset the Color3 to the default value.
        /// </summary>
        public void ResetColor3() => Color3 = Color.Empty;

        /// <summary>
        /// Gets the third element color.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public Color GetElementColor3(PaletteState state) =>
            Color3 != Color.Empty ? Color3 : _inheritElementColor.GetElementColor3(state);

        #endregion

        #region Color4
        /// <summary>
        /// Gets and sets the fourth element color.
        /// </summary>
        [KryptonPersist(false)]
        [Category("Visuals")]
        [Description("Fourth element color.")]
        [DefaultValue(typeof(Color), "")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public virtual Color Color4
        {
            get => _color4;

            set
            {
                if (_color4 != value)
                {
                    _color4 = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Reset the Color4 to the default value.
        /// </summary>
        public void ResetColor4() => Color4 = Color.Empty;

        /// <summary>
        /// Gets the fourth element color.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public Color GetElementColor4(PaletteState state) =>
            Color4 != Color.Empty ? Color4 : _inheritElementColor.GetElementColor4(state);

        #endregion

        #region Color5
        /// <summary>
        /// Gets and sets the fifth element color.
        /// </summary>
        [KryptonPersist(false)]
        [Category("Visuals")]
        [Description("Fifth element color.")]
        [DefaultValue(typeof(Color), "")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public virtual Color Color5
        {
            get => _color5;

            set
            {
                if (_color5 != value)
                {
                    _color5 = value;
                    PerformNeedPaint(true);
                }
            }
        }

        /// <summary>
        /// Reset the Color5 to the default value.
        /// </summary>
        public void ResetColor5() => Color5 = Color.Empty;

        /// <summary>
        /// Gets the fifth element color.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>Color value.</returns>
        public Color GetElementColor5(PaletteState state) =>
            Color5 != Color.Empty ? Color5 : _inheritElementColor.GetElementColor5(state);

        #endregion
    }
}
