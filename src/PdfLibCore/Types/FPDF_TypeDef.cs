/*
This file is part of PdfCoreLib, a wrapper around the PDFium library for the .NET.
Inspired by the awesome work of PDFiumSharp by Tobias Meyer.

Copyright (C) 2021 Jan Baarsssen
License: Microsoft Reciprocal License (MS-RL)
*/

// AUTOGENERATED FILE
// DO NOT MODIFY
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace PdfLibCore.Types
{

	/// <summary>Handle to a FPDF_ACTION</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_ACTION : IHandle<FPDF_ACTION>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_ACTION Null => new FPDF_ACTION();

		private FPDF_ACTION(IntPtr ptr) => _pointer = ptr;

		FPDF_ACTION IHandle<FPDF_ACTION>.SetToNull() => new FPDF_ACTION(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_ACTION: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_ANNOTATION</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_ANNOTATION : IHandle<FPDF_ANNOTATION>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_ANNOTATION Null => new FPDF_ANNOTATION();

		private FPDF_ANNOTATION(IntPtr ptr) => _pointer = ptr;

		FPDF_ANNOTATION IHandle<FPDF_ANNOTATION>.SetToNull() => new FPDF_ANNOTATION(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_ANNOTATION: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_ATTACHMENT</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_ATTACHMENT : IHandle<FPDF_ATTACHMENT>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_ATTACHMENT Null => new FPDF_ATTACHMENT();

		private FPDF_ATTACHMENT(IntPtr ptr) => _pointer = ptr;

		FPDF_ATTACHMENT IHandle<FPDF_ATTACHMENT>.SetToNull() => new FPDF_ATTACHMENT(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_ATTACHMENT: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_BITMAP</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_BITMAP : IHandle<FPDF_BITMAP>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_BITMAP Null => new FPDF_BITMAP();

		private FPDF_BITMAP(IntPtr ptr) => _pointer = ptr;

		FPDF_BITMAP IHandle<FPDF_BITMAP>.SetToNull() => new FPDF_BITMAP(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_BITMAP: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_BOOKMARK</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_BOOKMARK : IHandle<FPDF_BOOKMARK>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_BOOKMARK Null => new FPDF_BOOKMARK();

		private FPDF_BOOKMARK(IntPtr ptr) => _pointer = ptr;

		FPDF_BOOKMARK IHandle<FPDF_BOOKMARK>.SetToNull() => new FPDF_BOOKMARK(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_BOOKMARK: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_CLIPPATH</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_CLIPPATH : IHandle<FPDF_CLIPPATH>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_CLIPPATH Null => new FPDF_CLIPPATH();

		private FPDF_CLIPPATH(IntPtr ptr) => _pointer = ptr;

		FPDF_CLIPPATH IHandle<FPDF_CLIPPATH>.SetToNull() => new FPDF_CLIPPATH(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_CLIPPATH: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_DEST</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_DEST : IHandle<FPDF_DEST>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_DEST Null => new FPDF_DEST();

		private FPDF_DEST(IntPtr ptr) => _pointer = ptr;

		FPDF_DEST IHandle<FPDF_DEST>.SetToNull() => new FPDF_DEST(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_DEST: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_DOCUMENT</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_DOCUMENT : IHandle<FPDF_DOCUMENT>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_DOCUMENT Null => new FPDF_DOCUMENT();

		private FPDF_DOCUMENT(IntPtr ptr) => _pointer = ptr;

		FPDF_DOCUMENT IHandle<FPDF_DOCUMENT>.SetToNull() => new FPDF_DOCUMENT(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_DOCUMENT: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_FONT</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_FONT : IHandle<FPDF_FONT>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_FONT Null => new FPDF_FONT();

		private FPDF_FONT(IntPtr ptr) => _pointer = ptr;

		FPDF_FONT IHandle<FPDF_FONT>.SetToNull() => new FPDF_FONT(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_FONT: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_FORMHANDLE</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_FORMHANDLE : IHandle<FPDF_FORMHANDLE>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_FORMHANDLE Null => new FPDF_FORMHANDLE();

		private FPDF_FORMHANDLE(IntPtr ptr) => _pointer = ptr;

		FPDF_FORMHANDLE IHandle<FPDF_FORMHANDLE>.SetToNull() => new FPDF_FORMHANDLE(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_FORMHANDLE: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_JAVASCRIPT_ACTION</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_JAVASCRIPT_ACTION : IHandle<FPDF_JAVASCRIPT_ACTION>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_JAVASCRIPT_ACTION Null => new FPDF_JAVASCRIPT_ACTION();

		private FPDF_JAVASCRIPT_ACTION(IntPtr ptr) => _pointer = ptr;

		FPDF_JAVASCRIPT_ACTION IHandle<FPDF_JAVASCRIPT_ACTION>.SetToNull() => new FPDF_JAVASCRIPT_ACTION(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_JAVASCRIPT_ACTION: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_LINK</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_LINK : IHandle<FPDF_LINK>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_LINK Null => new FPDF_LINK();

		private FPDF_LINK(IntPtr ptr) => _pointer = ptr;

		FPDF_LINK IHandle<FPDF_LINK>.SetToNull() => new FPDF_LINK(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_LINK: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_PAGE</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_PAGE : IHandle<FPDF_PAGE>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_PAGE Null => new FPDF_PAGE();

		private FPDF_PAGE(IntPtr ptr) => _pointer = ptr;

		FPDF_PAGE IHandle<FPDF_PAGE>.SetToNull() => new FPDF_PAGE(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_PAGE: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_PAGELINK</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_PAGELINK : IHandle<FPDF_PAGELINK>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_PAGELINK Null => new FPDF_PAGELINK();

		private FPDF_PAGELINK(IntPtr ptr) => _pointer = ptr;

		FPDF_PAGELINK IHandle<FPDF_PAGELINK>.SetToNull() => new FPDF_PAGELINK(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_PAGELINK: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_PAGEOBJECT</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_PAGEOBJECT : IHandle<FPDF_PAGEOBJECT>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_PAGEOBJECT Null => new FPDF_PAGEOBJECT();

		private FPDF_PAGEOBJECT(IntPtr ptr) => _pointer = ptr;

		FPDF_PAGEOBJECT IHandle<FPDF_PAGEOBJECT>.SetToNull() => new FPDF_PAGEOBJECT(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_PAGEOBJECT: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_PAGEOBJECTMARK</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_PAGEOBJECTMARK : IHandle<FPDF_PAGEOBJECTMARK>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_PAGEOBJECTMARK Null => new FPDF_PAGEOBJECTMARK();

		private FPDF_PAGEOBJECTMARK(IntPtr ptr) => _pointer = ptr;

		FPDF_PAGEOBJECTMARK IHandle<FPDF_PAGEOBJECTMARK>.SetToNull() => new FPDF_PAGEOBJECTMARK(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_PAGEOBJECTMARK: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_PAGERANGE</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_PAGERANGE : IHandle<FPDF_PAGERANGE>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_PAGERANGE Null => new FPDF_PAGERANGE();

		private FPDF_PAGERANGE(IntPtr ptr) => _pointer = ptr;

		FPDF_PAGERANGE IHandle<FPDF_PAGERANGE>.SetToNull() => new FPDF_PAGERANGE(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_PAGERANGE: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_PATHSEGMENT</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_PATHSEGMENT : IHandle<FPDF_PATHSEGMENT>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_PATHSEGMENT Null => new FPDF_PATHSEGMENT();

		private FPDF_PATHSEGMENT(IntPtr ptr) => _pointer = ptr;

		FPDF_PATHSEGMENT IHandle<FPDF_PATHSEGMENT>.SetToNull() => new FPDF_PATHSEGMENT(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_PATHSEGMENT: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_RECORDER</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_RECORDER : IHandle<FPDF_RECORDER>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_RECORDER Null => new FPDF_RECORDER();

		private FPDF_RECORDER(IntPtr ptr) => _pointer = ptr;

		FPDF_RECORDER IHandle<FPDF_RECORDER>.SetToNull() => new FPDF_RECORDER(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_RECORDER: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_SCHHANDLE</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_SCHHANDLE : IHandle<FPDF_SCHHANDLE>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_SCHHANDLE Null => new FPDF_SCHHANDLE();

		private FPDF_SCHHANDLE(IntPtr ptr) => _pointer = ptr;

		FPDF_SCHHANDLE IHandle<FPDF_SCHHANDLE>.SetToNull() => new FPDF_SCHHANDLE(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_SCHHANDLE: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_STRUCTELEMENT</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_STRUCTELEMENT : IHandle<FPDF_STRUCTELEMENT>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_STRUCTELEMENT Null => new FPDF_STRUCTELEMENT();

		private FPDF_STRUCTELEMENT(IntPtr ptr) => _pointer = ptr;

		FPDF_STRUCTELEMENT IHandle<FPDF_STRUCTELEMENT>.SetToNull() => new FPDF_STRUCTELEMENT(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_STRUCTELEMENT: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_STRUCTTREE</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_STRUCTTREE : IHandle<FPDF_STRUCTTREE>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_STRUCTTREE Null => new FPDF_STRUCTTREE();

		private FPDF_STRUCTTREE(IntPtr ptr) => _pointer = ptr;

		FPDF_STRUCTTREE IHandle<FPDF_STRUCTTREE>.SetToNull() => new FPDF_STRUCTTREE(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_STRUCTTREE: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_TEXTPAGE</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_TEXTPAGE : IHandle<FPDF_TEXTPAGE>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_TEXTPAGE Null => new FPDF_TEXTPAGE();

		private FPDF_TEXTPAGE(IntPtr ptr) => _pointer = ptr;

		FPDF_TEXTPAGE IHandle<FPDF_TEXTPAGE>.SetToNull() => new FPDF_TEXTPAGE(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_TEXTPAGE: 0x{_pointer.ToString("X16")}";
    }

	/// <summary>Handle to a FPDF_WIDGET</summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct FPDF_WIDGET : IHandle<FPDF_WIDGET>
	{
		private IntPtr _pointer;

		/// <summary>Gets a value indicating whether the handle is <c>null</c>.</summary>
		public bool IsNull => _pointer == IntPtr.Zero;

		/// <summary>Gets a handle representing <c>null</c>.</summary>
		public static FPDF_WIDGET Null => new FPDF_WIDGET();

		private FPDF_WIDGET(IntPtr ptr) => _pointer = ptr;

		FPDF_WIDGET IHandle<FPDF_WIDGET>.SetToNull() => new FPDF_WIDGET(Interlocked.Exchange(ref _pointer, IntPtr.Zero));

        public override string ToString() => $"FPDF_WIDGET: 0x{_pointer.ToString("X16")}";
    }
}
