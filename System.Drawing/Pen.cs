//
// Pen.cs: The Pen code
//
// Authors:
//   Miguel de Icaza (miguel@xamarin.com)
//
// Copyright 2011 Xamarin Inc
//
using System;
using System.Drawing.Drawing2D;
using MonoTouch.CoreGraphics;

namespace System.Drawing {

	public sealed partial class Pen : MarshalByRefObject, IDisposable, ICloneable {
		Brush brush;
		Color color;
		bool changed = true;
		bool isModifiable;
		float width;
		
		public Pen (Brush brush) : this (brush, 1f) {}
		public Pen (Color color) : this (color, 1f) {}

		public Pen (Brush brush, float width)
		{
			if (brush == null)
				throw new ArgumentNullException ("brush");
			this.brush = (Brush) brush.Clone ();
			var sb = brush as SolidBrush;
			if (sb != null)
				color = sb.Color;
		}

		public Pen (Color color, float width)
		{
			brush = new SolidBrush (color);
			this.width = width;
		}
		
		~Pen ()
		{
			Dispose (false);
		}

		public void Dispose ()
		{
			Dispose (true);
		}

		public void Dispose (bool disposing)
		{
			if (disposing){
			}
		}

		public object Clone ()
		{
			if (brush != null)
				return new Pen (brush, width);
			else
				return new Pen (color, width);
		}

		public float Width {
			get {
				return width;
			}

			set {
				width = value;
				changed = true;
			}
		}

		Matrix transform;
		public Matrix Transform {
			get {
				return transform;
			}

			set {
				transform = value;
			}
		}

		internal void Setup (Graphics graphics, bool fill)
		{
			brush.Setup (graphics, fill);
		}
	}
}