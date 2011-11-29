//
// System.Drawing.Color.cs
//
// Author:
// Dennis Hayes (dennish@raytek.com)
// Ben Houston  (ben@exocortex.org)
//
// (C) 2002 Dennis Hayes
// Copyright (C) 2004,2006 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace System.Drawing {

	public enum KnownColor {
		ActiveBorder = 1,
		ActiveCaption = 2,
		ActiveCaptionText = 3,
		AppWorkspace = 4,
		Control = 5,
		ControlDark = 6,
		ControlDarkDark = 7,
		ControlLight = 8,
		ControlLightLight = 9,
		ControlText = 10,
		Desktop = 11,
		GrayText = 12,
		Highlight = 13,
		HighlightText = 14,
		HotTrack = 15,
		InactiveBorder = 16,
		InactiveCaption = 17,
		InactiveCaptionText = 18,
		Info = 19,
		InfoText = 20,
		Menu = 21,
		MenuText = 22,
		ScrollBar = 23,
		Window = 24,
		WindowFrame = 25,
		WindowText = 26,
		Transparent = 27,
		AliceBlue = 28,
		AntiqueWhite = 29,
		Aqua = 30,
		Aquamarine = 31,
		Azure = 32,
		Beige = 33,
		Bisque = 34,
		Black = 35,
		BlanchedAlmond = 36,
		Blue = 37,
		BlueViolet = 38,
		Brown = 39,
		BurlyWood = 40,
		CadetBlue = 41,
		Chartreuse = 42,
		Chocolate = 43,
		Coral = 44,
		CornflowerBlue = 45,
		Cornsilk = 46,
		Crimson = 47,
		Cyan = 48,
		DarkBlue = 49,
		DarkCyan = 50,
		DarkGoldenrod = 51,
		DarkGray = 52,
		DarkGreen = 53,
		DarkKhaki = 54,
		DarkMagenta = 55,
		DarkOliveGreen = 56,
		DarkOrange = 57,
		DarkOrchid = 58,
		DarkRed = 59,
		DarkSalmon = 60,
		DarkSeaGreen = 61,
		DarkSlateBlue = 62,
		DarkSlateGray = 63,
		DarkTurquoise = 64,
		DarkViolet = 65,
		DeepPink = 66,
		DeepSkyBlue = 67,
		DimGray = 68,
		DodgerBlue = 69,
		Firebrick = 70,
		FloralWhite = 71,
		ForestGreen = 72,
		Fuchsia = 73,
		Gainsboro = 74,
		GhostWhite = 75,
		Gold = 76,
		Goldenrod = 77,
		Gray = 78,
		Green = 79,
		GreenYellow = 80,
		Honeydew = 81,
		HotPink = 82,
		IndianRed = 83,
		Indigo = 84,
		Ivory = 85,
		Khaki = 86,
		Lavender = 87,
		LavenderBlush = 88,
		LawnGreen = 89,
		LemonChiffon = 90,
		LightBlue = 91,
		LightCoral = 92,
		LightCyan = 93,
		LightGoldenrodYellow = 94,
		LightGray = 95,
		LightGreen = 96,
		LightPink = 97,
		LightSalmon = 98,
		LightSeaGreen = 99,
		LightSkyBlue = 100,
		LightSlateGray = 101,
		LightSteelBlue = 102,
		LightYellow = 103,
		Lime = 104,
		LimeGreen = 105,
		Linen = 106,
		Magenta = 107,
		Maroon = 108,
		MediumAquamarine = 109,
		MediumBlue = 110,
		MediumOrchid = 111,
		MediumPurple = 112,
		MediumSeaGreen = 113,
		MediumSlateBlue = 114,
		MediumSpringGreen = 115,
		MediumTurquoise = 116,
		MediumVioletRed = 117,
		MidnightBlue = 118,
		MintCream = 119,
		MistyRose = 120,
		Moccasin = 121,
		NavajoWhite = 122,
		Navy = 123,
		OldLace = 124,
		Olive = 125,
		OliveDrab = 126,
		Orange = 127,
		OrangeRed = 128,
		Orchid = 129,
		PaleGoldenrod = 130,
		PaleGreen = 131,
		PaleTurquoise = 132,
		PaleVioletRed = 133,
		PapayaWhip = 134,
		PeachPuff = 135,
		Peru = 136,
		Pink = 137,
		Plum = 138,
		PowderBlue = 139,
		Purple = 140,
		Red = 141,
		RosyBrown = 142,
		RoyalBlue = 143,
		SaddleBrown = 144,
		Salmon = 145,
		SandyBrown = 146,
		SeaGreen = 147,
		SeaShell = 148,
		Sienna = 149,
		Silver = 150,
		SkyBlue = 151,
		SlateBlue = 152,
		SlateGray = 153,
		Snow = 154,
		SpringGreen = 155,
		SteelBlue = 156,
		Tan = 157,
		Teal = 158,
		Thistle = 159,
		Tomato = 160,
		Turquoise = 161,
		Violet = 162,
		Wheat = 163,
		White = 164,
		WhiteSmoke = 165,
		Yellow = 166,
		YellowGreen = 167,
#if NET_2_0
		ButtonFace = 168,
		ButtonHighlight = 169,
		ButtonShadow = 170,
		GradientActiveCaption = 171,
		GradientInactiveCaption = 172,
		MenuBar = 173,
		MenuHighlight = 174
#endif
	}
}
